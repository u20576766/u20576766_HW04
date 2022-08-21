using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20576766_HW04.Models
{
    public abstract class Merchandise
    {
        //Data Members
        private int mID;
        private string mName;
        private string mColour;
        private string mSize;
        private int mQuantity;

        //Parameters
        public Merchandise(int merchID, string name, string colour, string size, int quantity)
        {
            mID = merchID;
            mName = name;
            mColour = colour;
            mSize = size;
            mQuantity = quantity;
        }

        //Properties
        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Colour
        {
            get { return mColour; }
            set { mColour = value; }
        }

        public string Size
        {
            get { return mSize; }
            set { mSize = value; }
        }

        public int Quantity
        {
            get { return mQuantity; }
            set { mQuantity = value; }
        }


        
        //Virtual Method
        public virtual string AvailableStock()
        {
            if (mQuantity > 1)
            {
                return "Only " + Quantity + " " + Name + "s are avalable in stock";
            }
            else
            {
                return "There are no "+ Name + "s available.";
            }
        }


        //Abstract Method
        public abstract string FreeMerch();
    }
}