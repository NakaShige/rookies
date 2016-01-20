using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 販売管理システム.Model.Data
{
    public delegate void ChangedDataDelegate();

    public class DataManager
    {
        private DataManager() { }

        public 仕入[] 仕入List { get { return m_仕入List.ToArray(); } }
        public 商品[] 商品List { get { return m_商品List.ToArray(); } }

        public bool 商品登録(string newItemName)
        {
            newItemName = newItemName.Trim();

            if (string.IsNullOrEmpty(newItemName))
                return false;

            if (m_商品List.Any(q => string.Compare(q.Name, newItemName, true) == 0))
                return false;

            m_商品List.Add(new 商品(newItemName));

            if (ChangedData != null)
                ChangedData();

            return true;
        }

        public void 仕入処理(商品 item, int 仕入, int 販売, int 個数, DateTime 仕入日)
        {
            if (item == null || 仕入 < 0 || 販売 < 0 || 個数 <= 0)
                return;

            var targetItem = m_仕入List.FirstOrDefault(q => q.商品 == item && q.仕入日 == 仕入日);
            if (targetItem == null)
            {
                m_仕入List.Add(new 仕入(item, 仕入, 販売, 個数, 仕入日));
            }
            else
            {
                targetItem.個数 += 個数;
            }
            
            if (ChangedData != null)
                ChangedData();
        }

        public void 販売処理(商品 item, int 販売数, DateTime 販売日)
        {
            if (item == null || 販売数 <= 0)
                return;

            if (販売数 > m_仕入List.Where(q => q.商品 == item).Sum(p => p.個数))
                return;

            int 残り販売数 = 販売数;
            var query = m_仕入List.Where(q => q.商品 == item && q.個数 > 0).OrderBy(q => q.仕入日);
            foreach (var 仕入Item in query)
            {
                int 在庫数 = 仕入Item.個数;

                if (残り販売数 > 仕入Item.個数)
                {
                    残り販売数 -= 在庫数;
                    仕入Item.個数 = 0;
                }
                else
                {
                    仕入Item.個数 -= 残り販売数;
                    残り販売数 = 0;
                }

                if (残り販売数 <= 0)
                    break;

                //残り販売数 -= 仕入Item.個数;
            }

            if (ChangedData != null)
                ChangedData();
        }

        public event ChangedDataDelegate ChangedData;

        private List<仕入> m_仕入List = new List<仕入>();
        private List<商品> m_商品List = new List<商品>();
        
        public static DataManager getInstance()
        {
            if (m_DataManager == null)
                m_DataManager = new DataManager();

            return m_DataManager;
        }
        private static DataManager m_DataManager = null;
    }
}
