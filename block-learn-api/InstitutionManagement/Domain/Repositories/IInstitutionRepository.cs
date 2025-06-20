using block_learn_api.InstitutionManagement.Domain.Model.Aggregates;
using block_learn_api.InstitutionManagement.Domain.Model.Entities;
using block_learn_api.Shared.Domain.Repositories;

namespace block_learn_api.InstitutionManagement.Domain.Repositories
{
    public interface IInstitutionRepository : IBaseRepository<Institution>
    {

        Task<Professor?> FindByInstitutionIdAndProfessorIdAsync(int institutionId,int professorId);
        Task<IEnumerable<Professor>> FindProfessorsByInstitutionIdAsync(int institutionId);



        Task<Student?> FindByInstitutionIdAndStudentIdAsync(int institutionId,int studentId);   

        Task<IEnumerable<Student>> FindStudentsByInstitutionIdAsync(int institutionId);


        Task<Course?> FindByInstitutionIdAndCourseIdAsync(int institutionId,int courseId);

        Task<IEnumerable<Course>> FindCoursesByInstitutionIdAsync(int institutionId);


    }
}
