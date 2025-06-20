using block_learn_api.InstitutionManagement.Domain.Model.Aggregates;
using block_learn_api.InstitutionManagement.Domain.Model.Commands;
using block_learn_api.InstitutionManagement.Domain.Model.Entities;

namespace block_learn_api.InstitutionManagement.Domain.Services
{
    public interface IInstitutionCommandService
    {
        Task<Institution?> Handle(CreateInstitutionCommand command);
        Task<Course?> Handle(CreateCourseCommand command);
        Task<Professor?> Handle(CreateProfessorCommand command);
        Task<Student?> Handle(CreateStudentCommand command);

    }
}
