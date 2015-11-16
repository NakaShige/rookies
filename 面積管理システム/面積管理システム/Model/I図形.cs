using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面積管理システム.Model
{
    public interface I図形
    {
        string Name { get; }
        double 辺の長さ { get; set; }
        double 面積 { get; }
    }
}
