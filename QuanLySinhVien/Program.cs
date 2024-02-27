using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {   
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
            quanLySinhVien.ShowDialog();
        }
    }
}
