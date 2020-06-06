using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDBFinal
{
    class Book
    {
        public string BookIBSN { get; set; }

        public string Title { get; set; }

        public decimal Price{ get; set; }


        public override string ToString()
        {
            //formerly pseudocode.
            if (ComboBox.Name = "cbBookTitle")
            {
                return Title;
            }
            else if(ComboBox.Name = "cbBookISBN")
            {
                return BookIBSN;
            }
            else if(ComboBox.Name = "cbPrice")
            {
                return Convert.ToString(Price);
            }
            else
            {
                return null;
            }
        }
        
        public string GetDisplayText(string seperator)
        {
            return $"{BookIBSN}{seperator}{Price}{seperator}" +
                $"{Title}";
        }
    }

}
