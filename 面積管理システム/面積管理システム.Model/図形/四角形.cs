﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面積管理システム.Model.図形
{
    public class 四角形 : I図形
    {
        public 四角形(double d辺の長さ)
        {
            this.辺の長さ = d辺の長さ;
        }

        public string Name { get { return "四角形"; } }
        
        public double 辺の長さ { get; set; }

        public double 面積
        {
            get
            {
                return Math.Pow(辺の長さ, 2);
            }
        }
    }
}
