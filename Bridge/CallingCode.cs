using Bridge.Problem;
using Bridge.Solution;
using Truck = Bridge.Solution.Truck;

namespace Bridge;

public class CallingCode
{
    public static void Main()
    {
        var bad = new RedTruck();

        var good = new Truck(new RedCarColor());
        
        // If I need to add a new type of car - coupe
        // In the first case, I will need to create GreenCoupe & RedCoupe
        // In the second case, I will need to create Coupe only.
        // This composition over inheritance gives more flexibility
        
        //  1.            CarBase
        //             /           \
        //          Truck           LightCar
        //        /    \            /        \
        //  RedTruck GreenTruck RedLightCar GreenLightCar
        // ----------------------------------------------
        // 2.             CarBase <>------- Color
        //               /       \         /    \
        //         LightCar  Truck    RedColor GreenColor
        // ----------------------------------------------
    }
}