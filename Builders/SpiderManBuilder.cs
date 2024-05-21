using method_chaining.Entities;
using method_chaining.Interfaces;

namespace method_chaining.Builders;

public class SpiderManBuilder : ISuperHeroBuilder
{
    private readonly SuperHero _superHero = new();

    public ISuperHeroBuilder BuildName(string name)
    {
        _superHero.Name = name;
        return this;
    }

    public ISuperHeroBuilder BuildSecretIdentity(string secretIdentity)
    {
        _superHero.SecretIdentity = secretIdentity;
        return this;
    }

    public ISuperHeroBuilder BuildAbilities(string abilities)
    {
        _superHero.Abilities = abilities;
        return this;
    }

    public ISuperHeroBuilder BuildEquipment(string equipment)
    {
        _superHero.Equipment = equipment;
        return this;
    }

    public SuperHero GetSuperHero()
    {
        return _superHero;
    }    
}
