using block_learn_api.IAM.Domain.Model.Commands;
using block_learn_api.IAM.Interfaces.REST.Resources;

namespace block_learn_api.IAM.Interfaces.REST.Transform
{
    public static class SignInCommandFromResourceAssembler
    {
        public static SignInCommand ToCommandFromResource(SignInResource resource)
        {
            return new SignInCommand(resource.Username, resource.Password);
        }
    }
}
