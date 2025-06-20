using block_learn_api.InstitutionManagement.Domain.Model.Commands;
using block_learn_api.InstitutionManagement.Domain.Model.Entities;
using block_learn_api.InstitutionManagement.Domain.Model.ValueObjects;

namespace block_learn_api.InstitutionManagement.Domain.Model.Aggregates
{
    public class Institution
    {
        public int Id { get; }
        public string Name { get; private set; }
        public Ruc RUC { get; private set; }
        public string Address { get; private set; }

        public ICollection<Professor> Professors { get; private set; } = new List<Professor>();
        public ICollection<Course> Courses { get; private set; } = new List<Course>();
        public ICollection<Student> Students { get; private set; } = new List<Student>();

        // Constructor protegido para EF Core
        public Institution() { 
        
            Name = String.Empty;
            RUC = new Ruc();
            Address = String.Empty;
            Professors = new List<Professor>();
            Students = new List<Student>();
            Courses = new List<Course>();

        
        }

        // Constructor de dominio
        public Institution(string name, string ruc, string address)
        {
            Name = name;
            RUC = new Ruc(ruc);
            Address = address;
        }

        public Institution(CreateInstitutionCommand command)
            : this(command.Name,command.Ruc,command.Address) { }




        // Métodos de dominio
        public void AddProfessor(Professor professor)
        {
            if (Professors.Any(p => p.UserId == professor.UserId))
                throw new InvalidOperationException("Professor already registered in this institution.");
            Professors.Add(professor);
        }

        public void AddStudent(Student student)
        {
            if (Students.Any(s => s.UserId == student.UserId))
                throw new InvalidOperationException("Student already registered in this institution.");
            Students.Add(student);
        }

        public void AddCourse(Course course)
        {
            if (Courses.Any(c => c.Code == course.Code))
                throw new InvalidOperationException("A course with this code already exists.");
            Courses.Add(course);
        }
    }
}
