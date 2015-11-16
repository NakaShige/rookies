using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面積管理システム.Model
{
    public class 三角形 : I図形
    {
        public 三角形(double d辺の長さ)
        {
            this.辺の長さ = d辺の長さ;
        }

        public string Name { get { return "三角形"; } }

        public double 辺の長さ { get; set; }

        public double 面積
        {
            get
            {
                return Math.Pow(辺の長さ, 2) * Math.Sqrt(3.0) / 4.0;
            }
        }
    }
}
