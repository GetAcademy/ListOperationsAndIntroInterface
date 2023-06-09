﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ListOperationsAndIntroInterface.ListOps
{
    internal class ChessPlayer
    {
        public string? Name { get; set; }
        public string? Country { get; set; }
        public float Classic { get; set; }
        public float LatestChange { get; set; }
        public float Rapid { get; set; }
        public float Blitz { get; set; }
        public int Age { get; set; }

        public void Show()
        {
            Console.WriteLine($"{Name} ({Age}), {Country}  Ratings: {Classic} {LatestChange} {Rapid} {Blitz}");
            //Console.WriteLine(Name + " (" + Age + "), " + Country);
            // .InnerHTML +=? `${name} (${age})`
        }
    }

}
