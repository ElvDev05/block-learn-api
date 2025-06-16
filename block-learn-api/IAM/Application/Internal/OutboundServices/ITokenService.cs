using block_learn_api.IAM.Domain.Model.Aggregates;

namespace block_learn_api.IAM.Application.Internal.OutboundServices
{
    public interface ITokenService
    {
        string GenerateToken(User user);
        Task<int?> ValidateToken(string token);
    }
}
