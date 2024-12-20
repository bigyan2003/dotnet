using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObject
{
    internal class AreaVolume
    {
        int l, b, h;
        void SetData(int x, int y, int z)
        {
            l = x;
            b = y;
            h = z;
        }
        void Show()
        {
            Console.WriteLine("Dimension of box l = {0} b = {1} h = {2}", l, b, h);
        }
        void Area()
        {
            Console.WriteLine("Area of a box {0}", (l * b));
        }

        void Volume()
        {
            Console.WriteLine("Volume of a box = {0}", (l * b * h));

        }

        public static void Main(string[] args)
        {
            AreaVolume areaVolume = new AreaVolume();
            areaVolume.SetData(10, 2, 3);
            areaVolume.Show();
            areaVolume.Area();
            areaVolume.Volume();
        }
    }
}
