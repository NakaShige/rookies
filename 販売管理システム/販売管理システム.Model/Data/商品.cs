using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 販売管理システム.Model.Data
{
    public class 商品
    {
        public 商品(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
