using System.Collections.Generic;
namespace Harbour.Harbours
{
    public class Harbour
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Town { get; set; }

       public virtual decimal MaxShipSize {
            get { return 15.5m; }
        }

        public virtual int MaxShipsIn {
            get { return 5; }
        }

        public int ShipsInHarbor{get; set; }

        public virtual string WelcomeSpeech {
            get { return Name + " Calling!!!"; }
        }

        public virtual string GoodByeSpeech
        {
            get { return "Bye-Bye"; }
        }

        public virtual string IncomeSpeech
        {
            get { return Name + " " + Country + " " + Town + "\n" + WelcomeSpeech; }
        }
    }
}
