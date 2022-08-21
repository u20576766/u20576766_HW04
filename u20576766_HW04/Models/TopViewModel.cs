using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20576766_HW04.Models
{
    public class TopViewModel : Merchandise
    {
        //Data Members
        private string tType;

        //Parameters
        public TopViewModel(int merchID, string name, string colour, string size, int quantity,string type) : base(merchID, name, colour, size, quantity)
        {
            tType = type;
        }

        //Properties
        public string Type
        {
            get { return tType; }
            set { tType = value; }
        }

        public override string AvailableStock()
        {
            return base.AvailableStock();
        }

        public override string FreeMerch()
        {
            return "You can get free " + Name + "s if you enter into our SEA LION fundraiser!";
        }
    }
}