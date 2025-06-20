using block_learn_api.InstitutionManagement.Domain.Model.Commands;
using block_learn_api.InstitutionManagement.Domain.Model.ValueObjects;

namespace block_learn_api.InstitutionManagement.Domain.Model.Entities
{
    public class Professor
    {
        public int Id { get; }
        public int UserId { get; private set; } // FK al usuario IAM
        public string FullName { get; private set; }

        public Professor() {
            UserId = 0;
            FullName = string.Empty;
        }

        public Professor( int userId, string fullName) : this()
        {
            UserId = userId;
            FullName = fullName;
        }

        public Professor(CreateProfessorCommand command) 
            : this(command.UserId,command.Name) {}
    }
}
