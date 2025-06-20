using block_learn_api.InstitutionManagement.Domain.Model.Aggregates;
using block_learn_api.InstitutionManagement.Domain.Model.Entities;
using block_learn_api.InstitutionManagement.Domain.Model.Queries;

namespace block_learn_api.InstitutionManagement.Domain.Services
{
    public interface IInstitutionQueryService
    {
        Task<Institution?> Handle(GetInstitutionByIdQuery query);
        Task<IEnumerable<Professor>> Handle(GetAllProfessorsByInstitutionIdQuery query);
        Task<IEnumerable<Course>> Handle(GetAllCoursesByInstitutionIdQuery query);
        Task<IEnumerable<Student>> Handle(GetAllStudentsByInstitutionIdQuery query);


    }
}
