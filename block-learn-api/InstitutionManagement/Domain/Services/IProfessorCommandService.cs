using block_learn_api.InstitutionManagement.Domain.Model.Commands;
using block_learn_api.InstitutionManagement.Domain.Model.Entities;

namespace block_learn_api.InstitutionManagement.Domain.Services
{
    public interface IProfessorCommandService
    {
        Task<Professor?> Handle(CreateProfessorCommand command);
    }
}
