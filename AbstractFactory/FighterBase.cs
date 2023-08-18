namespace AbstractFactory;

public abstract class FighterBase
{
    public abstract int Health { get; protected set; }
    protected WeaponBase Weapon { get; private set; }

    public virtual void ArmWith(WeaponBase weapon) => Weapon = weapon;
    
    public int Atack(FighterBase target)
    {
        target.ReceiveDamage(Weapon.Damage);

        return Weapon.Damage;
    }

    public int ReceiveDamage(int damage) => Health -= damage;
}