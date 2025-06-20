namespace block_learn_api.InstitutionManagement.Domain.Model.Commands
{
    public record CreateCourseCommand(string Name, string Code, int Credits);
    
}
