namespace method_chaining.Entities;

public class SuperHero
{
    public string Name { get; set; } = string.Empty;
    public string SecretIdentity { get; set; } = string.Empty;
    public string Abilities { get; set; } = string.Empty;
    public string Equipment { get; set; } = string.Empty;

    public override string ToString() => $"Nome: { Name } {Environment.NewLine}" +
                                         $"Identidade Secreta: { SecretIdentity } {Environment.NewLine}" +
                                         $"Habilidades: { Abilities } {Environment.NewLine}" +
                                         $"Equipamentos: { Equipment }";
}
