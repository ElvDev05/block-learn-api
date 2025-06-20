using block_learn_api.InstitutionManagement.Domain.Model.Aggregates;
using block_learn_api.InstitutionManagement.Domain.Model.Entities;
using block_learn_api.InstitutionManagement.Domain.Repositories;
using block_learn_api.Shared.Infrastructure.Persistence.EFC.Configuration;
using block_learn_api.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace block_learn_api.InstitutionManagement.Infrastructure.Persistence.EFC.Repositories
{
    public class InstitutionRepository(AppDbContext context) : BaseRepository<Institution>(context), IInstitutionRepository
    {
        public Task<Course?> FindByInstitutionIdAndCourseIdAsync(int institutionId, int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<Professor?> FindByInstitutionIdAndProfessorIdAsync(int institutionId, int professorId)
        {
            throw new NotImplementedException();
        }

        public Task<Student?> FindByInstitutionIdAndStudentIdAsync(int institutionId, int studentId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Course>> FindCoursesByInstitutionIdAsync(int institutionId)
        {
            var institution = await Context.Set<Institution>()
                .Include(i => i.Courses)
                .FirstOrDefaultAsync(i => i.Id == institutionId);

            return institution.Courses;
        }

        public async Task<IEnumerable<Professor>> FindProfessorsByInstitutionIdAsync(int institutionId)
        {
            var institution = await Context.Set<Institution>()
               .Include(i => i.Professors)
               .FirstOrDefaultAsync(i => i.Id == institutionId);

            return institution.Professors;
        }

        public async Task<IEnumerable<Student>> FindStudentsByInstitutionIdAsync(int institutionId)
        {
            var institution = await Context.Set<Institution>()
                .Include(i => i.Students)
                .FirstOrDefaultAsync(i => i.Id == institutionId);

            return institution.Students;
        }

        public new async Task<Institution?> FindByIdAsync(int id) => await Context.Set<Institution>()
            .Include(i => i.Professors)
            .Include(i => i.Students)
            .Include(i => i.Courses)
            .FirstOrDefaultAsync(i => i.Id == id);


    }
}
