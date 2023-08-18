namespace AbstractFactory.Knight_family;

internal sealed class KnightBattleFactory : IBattleFactory
{
    public FighterBase CreateFighter() => new Knight();

    public WeaponBase CreateWeapon() => new LongSword();
}