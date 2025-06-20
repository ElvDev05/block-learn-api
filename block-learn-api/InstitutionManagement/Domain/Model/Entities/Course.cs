using block_learn_api.InstitutionManagement.Domain.Model.Commands;

namespace block_learn_api.InstitutionManagement.Domain.Model.Entities
{
    public class Course
    {

        public int Id { get; }
        public string Name { get; private set; }
        public string Code { get; private set; }
        public int Credits { get; private set; }

        public int ProfessorId { get; private set; }

        public Professor professor { get;  set; }


        public Course() { 
        
            Name = string.Empty;
            Code = string.Empty;
            Credits = 0;
        }



        public Course(string name, string code, int credits) : this()
        {
            Name = name;
            Code = code;
            Credits = credits;
        }

        public Course(CreateCourseCommand command)
            : this(command.Name,command.Code,command.Credits) { }



        public void AssignProfessor(int professorId, Professor professorAsign)
        {
            ProfessorId = professorId;
            professor = professorAsign;
        }

    }
}
