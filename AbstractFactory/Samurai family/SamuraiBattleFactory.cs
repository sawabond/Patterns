namespace AbstractFactory.Samurai_family;

internal sealed class SamuraiBattleFactory : IBattleFactory
{
    public FighterBase CreateFighter() => new Samurai();

    public WeaponBase CreateWeapon() => new Katana();
}