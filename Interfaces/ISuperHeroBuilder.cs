using method_chaining.Entities;

namespace method_chaining.Interfaces;

public interface ISuperHeroBuilder
{
    ISuperHeroBuilder BuildName(string name);
    ISuperHeroBuilder BuildSecretIdentity(string secretIdentity);
    ISuperHeroBuilder BuildAbilities(string abilities);
    ISuperHeroBuilder BuildEquipment(string equipment);
    SuperHero GetSuperHero();    
}
