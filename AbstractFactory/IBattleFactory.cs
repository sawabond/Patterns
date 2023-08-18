namespace AbstractFactory;

public interface IBattleFactory
{
    FighterBase CreateFighter();

    WeaponBase CreateWeapon();
}