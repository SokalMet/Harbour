
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
            Astra astra = new Astra();            
            var incomingShipNameList = new List<string>();
            var incomingShipList2 = new List<Ship>();
            
            do
            {
                var astraWeather = astra.Weather();
                Console.WriteLine(astra.WelcomeSpeech + ". The weather is " + astraWeather);
               
                Console.WriteLine("Tell me youre Name");
                
                var incomeShipName = Console.ReadLine();
                Console.Clear();

                if (astraWeather == Enums.Enums.WeatherType.Bad)
                {
                    Console.WriteLine("Bad weather - IS OUR BREAK TIME! Come next time!");
                }
                else
                {
                    Console.WriteLine(" Now " + astra.ShipsInHarbour.Count + " ship(s) in " + astra.Name);

                    if (incomingShipNameList.Contains(incomeShipName))
                    {
                       
                        Console.WriteLine("\n\nHello! How is your staying here? If you want to leave " + astra.Name +
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
                        Console.Write("Type Parameters OF Your Ship :\nName - " + 
                            incomeShipName + "\n(SmallShip - press\"1\"; TooBigShip - press\"2\"; Tanker - press\"3\";) \nShip type - ");
                        var shipType= Enums.Enums.ShipTypes.WRONG;
                        try { shipType = ToEnum<Enums.Enums.ShipTypes>(Console.ReadLine()); }
                        catch { break; }
                        Console.WriteLine(shipType);
                        while (astra.AdoptShipTypes.Contains(shipType)!=true)
                        {
                            Console.WriteLine("Your Ship Is Not For our Harbor!!! ");
                            shipType = ToEnum<Enums.Enums.ShipTypes>(Console.ReadLine());
                            Console.WriteLine(shipType);
                        }
                        Console.Write("Color - ");
                        var shipColor = Console.ReadLine();
                        Console.Write("Length - ");
                        var shipLength = Console.ReadLine();

                        //To enable filtering in ship SIZE 

                        //var sl = Convert.ToDecimal(shipLength);
                        //if (sl > astra.MaxShipSize)
                        //{
                        //    Console.WriteLine("You Are to LONG for our harbour!! Ok?");
                        //    Console.ReadKey();
                        //}
                        //else
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
                                    ErrorCounter errorCounter = new ErrorCounter();
                                    Beep1 beep1 = new Beep1();
                                    var z = 0;
                                    while (incomingShip.IncomeBeepCount != 3)
                                    {
                                        errorCounter.onError += beep1.WrongParameter;
                                        errorCounter.Count();
                                        Console.WriteLine("Wrong number of BEEP's, \nHow many beeps will U make now?");
                                        try { incomingShip.IncomeBeepCount = Convert.ToInt32(Console.ReadLine()); }
                                        catch { Console.WriteLine("ONLY number!"); }
                                    }
                                    
                                    astra.ShipsInHarbour.Add(incomingShip);
                                    incomingShipNameList.Add(incomeShipName);
                                    incomingShipList2.Add(incomingShip);
                                }
                            }
                        }
                    }
                    else { Console.WriteLine("Sorry! Come another time! \nDo you want to continue? (\"y/n\")"); } 
                }
                Console.WriteLine("Do you want to continue? (\"y/n\")");
            }
            while (Console.ReadLine() == "y");
        }
    }
}
