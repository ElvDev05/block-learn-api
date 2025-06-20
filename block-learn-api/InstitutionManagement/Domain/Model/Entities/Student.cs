using block_learn_api.InstitutionManagement.Domain.Model.Commands;
using block_learn_api.InstitutionManagement.Domain.Model.ValueObjects;

namespace block_learn_api.InstitutionManagement.Domain.Model.Entities
{
    public class Student
    {
        public int Id { get;  }
        public int UserId { get; private set; }
        public string FullName { get; private set; }

        public Student() { 
            UserId = 0;
            FullName = string.Empty;
        
        }

        public Student(int userId, string fullName) : this()
        {
            
            UserId = userId;
            FullName = fullName;
        }

        public Student(CreateStudentCommand command) : this(command.UserId,command.Name) { }
    }
}
