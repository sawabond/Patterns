namespace AbstractFactory.Samurai_family;

internal sealed class Samurai : FighterBase
{
    public Samurai()
    {
        Health = 20;
    }

    public override int Health { get; protected set; }

    public override void ArmWith(WeaponBase weapon)
    {
        if (weapon is not Katana katana)
        {
            throw new Exception("Samurai can only fight with katanas");
        }
        
        base.ArmWith(katana);
    }
}