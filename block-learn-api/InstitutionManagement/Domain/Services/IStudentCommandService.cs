using block_learn_api.InstitutionManagement.Domain.Model.Commands;
using block_learn_api.InstitutionManagement.Domain.Model.Entities;

namespace block_learn_api.InstitutionManagement.Domain.Services
{
    public interface IStudentCommandService
    {
        Task<Student?> Handle(CreateStudentCommand command);
    }
}
