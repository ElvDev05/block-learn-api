using block_learn_api.InstitutionManagement.Domain.Model.Aggregates;
using block_learn_api.InstitutionManagement.Domain.Model.Commands;
using block_learn_api.InstitutionManagement.Domain.Model.Entities;
using block_learn_api.InstitutionManagement.Domain.Repositories;
using block_learn_api.InstitutionManagement.Domain.Services;
using block_learn_api.Shared.Domain.Repositories;

namespace block_learn_api.InstitutionManagement.Application.Internal.CommandServices
{
    public class InstitutionCommandService(IInstitutionRepository institutionRepository, IUnitOfWork unitOfWork) : IInstitutionCommandService
    {
        public Task<Institution?> Handle(CreateInstitutionCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<Course?> Handle(CreateCourseCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<Professor?> Handle(CreateProfessorCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<Student?> Handle(CreateStudentCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
