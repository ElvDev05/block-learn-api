using block_learn_api.IAM.Domain.Model.Aggregates;
using block_learn_api.IAM.Domain.Model.Queries;

namespace block_learn_api.IAM.Domain.Services
{
    public interface IUserQueryService
    {
        Task<IEnumerable<User>> Handle(GetAllUsersQuery query);
        Task<User?> Handle(GetUserByIdQuery query);
        Task<User?> Handle(GetUserByRoleQuery query);
        Task<User?> Handle(GetUserByUsernameQuery query);

    }
}
