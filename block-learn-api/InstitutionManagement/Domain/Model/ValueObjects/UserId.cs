namespace block_learn_api.InstitutionManagement.Domain.Model.ValueObjects
{
    public record UserId(Guid Identifier)
    {
        public UserId() : this(Guid.NewGuid())
        {
        }
    }
}
