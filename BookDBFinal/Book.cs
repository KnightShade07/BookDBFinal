﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDBFinal
{
    class Book
    {
        public string BookIBSN { get; set; }

        public string Title { get; set; }

        public decimal Price{ get; set; }

        public override string ToString()
        {
            return BookIBSN;
        }
    }

}
