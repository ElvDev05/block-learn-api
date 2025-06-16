using block_learn_api.IAM.Domain.Model.Aggregates;
using block_learn_api.IAM.Interfaces.REST.Resources;

namespace block_learn_api.IAM.Interfaces.REST.Transform
{
    public static class UserResourceFromEntityAssembler
    {
        public static UserResource ToResourceFromEntity(User entity)
        {
            return new UserResource(entity.Id, entity.Username);
        }
    }
}
