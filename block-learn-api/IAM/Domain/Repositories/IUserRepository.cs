using block_learn_api.IAM.Domain.Model.Aggregates;
using block_learn_api.Shared.Domain.Repositories;

namespace block_learn_api.IAM.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User?> FindByUsernameAsync(string username);
        bool ExistsByUsername(string username);
    }
}
