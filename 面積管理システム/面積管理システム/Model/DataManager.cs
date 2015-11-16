using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面積管理システム.Model
{
    public delegate void ChangedDataEvent();

    public class DataManager
    {
        public void Add(I図形 fig)
        {
            m_図形List.Add(fig);

            if (OnChangedData != null)
                OnChangedData();
        }

        public void Remove(I図形 fig)
        {
            int index = m_図形List.IndexOf(fig);
            if (index >= 0)
            {
                this.Remove(index);
            }
        }

        public void Remove(int index)
        {
            m_図形List.RemoveAt(index);

            if (OnChangedData != null)
                OnChangedData();
        }

        public double 合計面積
        {
            get { return m_図形List.Sum(q => q.面積); }
        }

        public I図形[] Items
        {
            get
            {
                return m_図形List.ToArray();
            }
        }

        public I図形 SelectedItem
        {
            get { return m_SelectedItem; }
            set { m_SelectedItem = value; }
        }

        public bool IsSelected
        {
            get { return m_SelectedItem != null; }
        }

        private List<I図形> m_図形List = new List<I図形>();
        private I図形 m_SelectedItem;

        public event ChangedDataEvent OnChangedData;
    }
}
