using AbstractFactory.Knight_family;
using AbstractFactory.Samurai_family;

namespace AbstractFactory;

public static class CallingCode
{
    public static void Main()
    {
        var samuraiFactory = GetSamuraiFactory();
        var samurai = samuraiFactory.CreateFighter();
        samurai.ArmWith(samuraiFactory.CreateWeapon());
        
        var knightFactory = GetKnightFactory();
        var knight = knightFactory.CreateFighter();
        knight.ArmWith(knightFactory.CreateWeapon());

        samurai.Atack(knight);
    }

    // DI imitation
    private static IBattleFactory GetSamuraiFactory() =>
        new SamuraiBattleFactory();
    
    // DI imitation
    private static IBattleFactory GetKnightFactory() =>
        new KnightBattleFactory();
}