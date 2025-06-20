using block_learn_api.InstitutionManagement.Domain.Model.Aggregates;
using block_learn_api.InstitutionManagement.Domain.Model.Entities;
using block_learn_api.InstitutionManagement.Domain.Model.Queries;
using block_learn_api.InstitutionManagement.Domain.Repositories;
using block_learn_api.InstitutionManagement.Domain.Services;

namespace block_learn_api.InstitutionManagement.Application.Internal.QueryServices
{
    public class InstitutionQueryService(IInstitutionRepository institutionRepository) : IInstitutionQueryService
    {
        public async Task<Institution?> Handle(GetInstitutionByIdQuery query)
        {
           return await institutionRepository.FindByIdAsync(query.institutionId);
        }

        public async Task<IEnumerable<Professor>> Handle(GetAllProfessorsByInstitutionIdQuery query)
        {
            return await institutionRepository.FindProfessorsByInstitutionIdAsync(query.InstitutionId);
        }

        public async Task<IEnumerable<Course>> Handle(GetAllCoursesByInstitutionIdQuery query)
        {
            return await institutionRepository.FindCoursesByInstitutionIdAsync(query.InstitutionId);
        }

        public async Task<IEnumerable<Student>> Handle(GetAllStudentsByInstitutionIdQuery query)
        {
            return await institutionRepository.FindStudentsByInstitutionIdAsync(query.InstitutionId);
        }
    }
}
