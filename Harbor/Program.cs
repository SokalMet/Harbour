
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harbour.Harbours.Countries.Towns.Khmelnitskiy;
using Harbour.ShipTypes;
using ShipInterface;


namespace Harbour
{
    public static class Program
    {
        public static T ToEnum<T>(string value)
        {
            return (T) Enum.Parse(typeof (T), value, true);
        }

        private static void Main(string[] args)
        {
            var astra = new Astra();
            var incomingShipNameList = new List<string>();
            var incomingShipList2 = new List<Ship>();
            do
            {
                Console.WriteLine(astra.WelcomeSpeech + ". The weather is " + astra.Weather());
                Console.Clear();
                Console.WriteLine("Tell me youre Name");
                var incomeShipName = Console.ReadLine();

                if (astra.Weather() == Enums.Enums.WeatherType.Bad)
                {
                    Console.WriteLine("Bad weather - IS OUR BREAK TIME! Come next time!");
                }
                else
                {
                    if (incomingShipNameList.Contains(incomeShipName))
                    {
                        Console.WriteLine(" Now " + astra.ShipsInHarbour.Count + " ship(s) in " + astra.Name);

                        Console.WriteLine("\n\nHello! How is youre staying here? If you want to leave " + astra.Name +
                                              " harbor - press \"y\"");
                        if (Console.ReadLine() == "y")
                        {
                            incomingShipNameList.Remove(incomeShipName);
                            Console.Clear();
                            Console.WriteLine(astra.GoodByeSpeech + "\n");
                            var shipToRemove = astra.ShipsInHarbour.FirstOrDefault(x => x.Name == incomeShipName);
                            astra.ShipsInHarbour.Remove(shipToRemove);
                            Console.WriteLine(shipToRemove.GetBeep());
                        }
                    }
                    else if (!incomingShipNameList.Contains(incomeShipName) && astra.ShipsInHarbour.Count < astra.MaxShipsIn)
                    {
                        Console.WriteLine(" Now " + astra.ShipsInHarbour.Count + " ship(s) in " + astra.Name);

                        Console.Write("Type Parameters OF Youre Ship :\nName - " + incomeShipName + "\n(SmallShip - press\"1\"; TooBigShip - press\"2\"; Tanker - press\"3\";) \nShip type - ");
                        var shipType = ToEnum<Enums.Enums.ShipTypes>(Console.ReadLine());
                        if (!astra.AdoptShipTypes.Contains(shipType))
                        {
                            Console.WriteLine("Yo'rs Ship Is Not For our Harbor!!!    Ok?");
                            Console.ReadKey();
                        }
                        Console.Write("Color - ");
                        var shipColor = Console.ReadLine();
                        Console.Write("Length ( no longer 11.0 meters) - ");
                        var shipLength = 0m;
                        try
                        {
                            shipLength = Convert.ToDecimal(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("You entered the wrong parameter");
                        }
                        if (shipLength > astra.MaxShipSize)
                        {
                            Console.WriteLine("You Are to LONG for our harbour!! Ok?");
                            Console.ReadKey();
                        }
                        else
                        {
                            var incomingShip = new IncomingShip(incomeShipName, shipType, shipColor, shipLength);
                            incomingShipList2.Add(incomingShip);
                            incomingShip.IncomeBeepCount = 2;
                            if ((incomingShipNameList.Count <= astra.MaxShipsIn) &&
                                (!incomingShipNameList.Contains(incomeShipName)) &&
                                (astra.AdoptShipTypes.Contains(incomingShip.IncomeShipType)))
                            {
                                if (incomingShip.IncomeBeepCount == 3)
                                {
                                    for (int i = 0; i < incomingShip.IncomeBeepCount; i++)
                                    {
                                        Console.WriteLine(incomingShip.GetBeep());
                                    }
                                    astra.ShipsInHarbour.Add(incomingShip);
                                    incomingShipNameList.Add(incomeShipName);
                                    Console.WriteLine("you are Welcome!!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    for (int i = 0; i < incomingShip.IncomeBeepCount; i++)
                                    {
                                        Console.WriteLine(incomingShip.GetBeep());
                                    }
                                    while (incomingShip.IncomeBeepCount != 3)
                                    {
                                        Console.WriteLine("Wrong number of BEEP'S,\nHow many beeps will U make now?");
                                        incomingShip.IncomeBeepCount = Convert.ToInt32(Console.ReadLine());

                                    }
                                    astra.ShipsInHarbour.Add(incomingShip);
                                    incomingShipNameList.Add(incomeShipName);
                                    incomingShipList2.Add(incomingShip);
                                }
                            }
                        }
                    }
                    else { Console.WriteLine("Sorry! Come enother time!"); } 
                }
                Console.WriteLine("Do you want to continue? (\"y/n\")");
            }
            while (Console.ReadLine() == "y");
        }
    }
}
