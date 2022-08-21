using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20576766_HW04.Models
{
    public class HoodieViewModel : Merchandise
    {
        //Data Members
        private string hType;
        private bool hEngrave;

        //Parameters
        public HoodieViewModel(int merchID, string name, bool engrave, string colour, string size, int quantity, string type) : base(merchID, name, colour, size, quantity)
        {
            hType = type;
            hEngrave = engrave;
        }

        //Properties
        public string Type
        {
            get { return hType; }
            set { hType = value; }
        }

        public bool Engrave
        {
            get { return hEngrave; }
            set { hEngrave = value; }
        }

        public override string AvailableStock()
        {
            return base.AvailableStock();
        }

        public override string FreeMerch()
        {
            return "You can get free " + Name + "s if you enter into our PENGUIN LIFELINE fundraiser!";
        }
    }
}