using System.Text.RegularExpressions;

namespace block_learn_api.InstitutionManagement.Domain.Model.ValueObjects
{
    public record Ruc(string Value)
    {
        public Ruc() : this(string.Empty) { }

        public string Value { get; init; } = Value;

        public static implicit operator string(Ruc ruc) => ruc.Value;

        public static Ruc Create(string value)
        {
            if (string.IsNullOrEmpty(value) || !Regex.IsMatch(value, @"^\d{11}$"))
                throw new ArgumentException("RUC must be exactly 11 numeric digits.");
            return new Ruc(value);
        }
    }
}
