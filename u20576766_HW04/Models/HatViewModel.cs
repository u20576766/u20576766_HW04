using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20576766_HW04.Models
{
    public class HatViewModel : Merchandise
    {
        //Data Members
        private string atType;

        //Parameters
        public HatViewModel(int merchID, string name, string colour, string size, int quantity, string type) : base(merchID, name, colour, size, quantity)
        {
            atType = type;
        }

        //Properties
        public string Type
        {
            get { return atType; }
            set { atType = value; }
        }

        public override string AvailableStock()
        {
            return base.AvailableStock()+ ", distributed equally between the Beanies, Bucket Hats and Caps.";
        }

        public override string FreeMerch()
        {
            return "You can get free " + Name + "s if you enter into our WHALE CONSERVATION fundraiser!";
        }
    }
}