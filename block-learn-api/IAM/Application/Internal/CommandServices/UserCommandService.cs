using block_learn_api.IAM.Application.Internal.OutboundServices;
using block_learn_api.IAM.Domain.Model.Aggregates;
using block_learn_api.IAM.Domain.Model.Commands;
using block_learn_api.IAM.Domain.Model.ValueObjects;
using block_learn_api.IAM.Domain.Repositories;
using block_learn_api.IAM.Domain.Services;
using block_learn_api.IAM.Infrastructure.Hashing.BCrypt.Services;
using block_learn_api.IAM.Infrastructure.Tokens.JWT.Services;
using block_learn_api.Shared.Domain.Repositories;
using System.Data;

namespace block_learn_api.IAM.Application.Internal.CommandServices
{
    public class UserCommandService(
     IUserRepository userRepository,
     IHashingService hashingService,
     ITokenService tokenService,
     IUnitOfWork unitOfWork
     ) : IUserCommandService
    {
        public async Task Handle(SignUpCommand command)
        {
            if (userRepository.ExistsByUsername(command.Username))
                throw new Exception($"Username {command.Username} is already taken");

            if (!Enum.TryParse<UserRole>(command.Role, true, out var role))
                throw new Exception($"Invalid role: {command.Role}");


            var hashedPassword = hashingService.HashPassword(command.Password);
            var user = new User(command.Username, hashedPassword).UpdateRole(role);
            try
            {
                await userRepository.AddAsync(user);
                await unitOfWork.CompleteAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"An error occurred while creating user: {e.Message}");
            }
        }

        public async Task<(User user, string token)> Handle(SignInCommand command)
        {
            var user = await userRepository.FindByUsernameAsync(command.Username);
            if (user is null || !hashingService.VerifyPassword(command.Password, user.PasswordHash))
                throw new Exception("Invalid username or password");
            var token = tokenService.GenerateToken(user);
            return (user, token);
        }
    }
}
