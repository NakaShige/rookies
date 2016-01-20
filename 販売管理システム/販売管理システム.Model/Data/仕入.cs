using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 販売管理システム.Model.Data
{
    public class 仕入
    {
        public 仕入(商品 item, int 仕入価格, int 販売価格, int 個数, DateTime 仕入日)
        {
            this.商品 = item;
            this.仕入価格 = 仕入価格;
            this.販売価格 = 販売価格;
            this.個数 = 個数;
            this.仕入日 = 仕入日;
        }

        public 商品 商品 { get; private set; }
        public int 仕入価格 { get; private set; }
        public int 販売価格 { get; private set; }
        public int 個数 { get; set; }
        public DateTime 仕入日 { get; private set; }

        public override string ToString()
        {
            return "商品:" + 商品.Name + ", 仕入:" + 仕入価格.ToString() + ", 販売:" + 販売価格.ToString() + ", 個数:" + 個数.ToString() + ", 仕入日:" + 仕入日.ToShortDateString();
        }
    }
}
