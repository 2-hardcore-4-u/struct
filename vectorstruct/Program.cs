using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectorstruct
{
    struct Vector {
        public double x;
        public double y;
        public double z;
        public double vectorLength;
        //finding length start
        public double GetLength()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        //finding length end
        //constructor start
        public Vector(double xMain=0, double yMain=0, double zMain=0)
        {
            this.x = xMain;
            this.y = yMain;
            this.z = zMain;
            vectorLength = 0;
            vectorLength = GetLength();
        }
        //constructor end
        //normalize start
        public void Normalize()
        {
            if (vectorLength>0) {
                x /= vectorLength;
                y /= vectorLength;
                z /= vectorLength;
            }
        }
        //normalize end
        //console output start
        public void PrintVectorToConsole()
        {
            Console.WriteLine("(" + x + " " + y + " " + z + ")");
        }
        //console output end
        //basic operations start
        public static Vector operator +(Vector a, Vector b) => new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        public static Vector operator -(Vector a, Vector b) => new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
        public static Vector operator *(Vector a, Vector b) => new Vector(a.x * b.x, a.y * b.y, a.z * b.z);
        public static Vector operator /(Vector a, Vector b) => new Vector(a.x + b.x, a.y / b.y, a.z + b.z);
        //basic operations end
        //advanced operations start
        public static Vector NumberMultiply(Vector a, double b) => new Vector(a.x * b, a.y * b, a.z * b);
        public static Vector NumberDivide(Vector a, double b) => new Vector(a.x / b, a.y / b, a.z / b);
        //advanced operations end
    }
    class Program
    {
        static void Main()
        {
            Vector vector1 = new Vector(1, 2, 3);
            Vector vector2 = new Vector(4, 5, 6);
            Vector vector3 = vector1*vector2;
            Vector vector4 = Vector.NumberMultiply(vector2, 7);
            vector3.PrintVectorToConsole();
            vector4.PrintVectorToConsole();
            vector3.Normalize();
            vector3.PrintVectorToConsole();
            Console.ReadKey();
        }
    }
}