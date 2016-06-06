using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harbour.Harbours.Countries.Towns.Khmelnitskiy;
using Harbour.ShipTypes;

namespace Harbour
{
    //  You could make control of your harbour using control commands/ All that 
    public class CommandsForHarbour
    {
        public void ToLong()
        {
            Console.WriteLine("You Are to LONG for our harbour!! Ok?");
            Console.ReadKey();
            
        }

        public void harboureFull()
        {
            Console.WriteLine("Sorry! No free spase!!");
            Console.ReadKey();
        }

        public void countOfIncomeBeep(int count)
        {
            if (count == 3) return;
            Console.WriteLine("Sorry! Wrong beep!!");
            Console.ReadKey();
        }
    }
}



//        public static Enums.Enums.ShipTypes incomeShip;

//        //public static bool Commands(Enums.Enums.CommandsForHarbour commands, string name, decimal maxSize, int maxCount,
//            Enums.Enums.ShipTypes shipType)
//        {
//            if (shipType == Enums.Enums.ShipTypes.SmallShip)
//            {

//                // var incomeShip = new SmallShip(name, shipType);
//                //Console.WriteLine(incomeShip.Name+" "+incomeShip.IncomeBeepRepeats());
//            }

//            if (shipType == Enums.Enums.ShipTypes.Tanker)
//            {
//                //var incomeShip = new Tanker(name, shipType);
//                //Console.WriteLine(incomeShip.Name);
//            }

//            if (shipType == Enums.Enums.ShipTypes.TooBigShip)
//            {
//                //var incomeShip = new TooBigShip(name, shipType);
//                //Console.WriteLine(incomeShip.Name);
//            }

//            Console.WriteLine(shipType);


//            switch (commands)
//            {
//                case Enums.Enums.CommandsForHarbour.Suitability:
//                    //            if ()
//                    //Console.WriteLine("Suit");
//                    return true;
//                    break;
//                    //case Enums.Enums.CommandsForHarbour.AddToList:
//                    Console.WriteLine("Ok-3");
//                    break;
//                case Enums.Enums.CommandsForHarbour.RemoveFromList:
//                    Console.WriteLine("Ok-4");
//                    break;
//                default:
//                    Console.WriteLine("No");
//                    break;
//            }

//        }
    
