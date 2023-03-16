using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGLibrary
{
    public class GGClass
    {
        public float AreaTrangle(float a, float h, float S)
        {
            a = 3;
            h = 5;
            S = (a * h) / 2;
            return (float)S;
        }

        public int AreaCircle(int R, int S)
        {
            R = 3;

            S = ((int)(Math.PI * Math.Pow(R, 2)));

            return S;
        }

        public float AreaSquare(int A,int S)
        {
            A = 4;

            S = (int)Math.Pow(A, 2);

            return S;
        }

        public int AreaRhomb(int d1, int d2, int S)
        {
            d1 = 4; 
            d2 = 8;

            S = (d1 * d2) / 2;

            return S;
        }

        public int AreaRectangle1(int h, int l, int S)
        {
            h = 3;
            l = 5;

            S = h * l;

            return S;
        }

        public int AreaRing(int R, int r)
        {
            double S = 3.14 * Math.Pow(R, 2) - Math.Pow(r, 2);

            return (int)S;
        }
    }
}
