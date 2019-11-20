using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
        public Vector Add(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }
    }

    public class Segment
    {
        public Vector Begin = new Vector();
        public Vector End = new Vector();
    }

    public class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        public static double GetLength(Segment sgm)
        {
            double xLength = Math.Abs(sgm.Begin.X - sgm.End.X);
            double yLength = Math.Abs(sgm.Begin.Y - sgm.End.Y);
            return GetLength(new Vector { X = xLength, Y = yLength });
        }

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            double dotX = vector.X;
            double dotY = vector.Y;
            double sBeginX = segment.Begin.X;
            double sBeginY = segment.Begin.Y;
            double sEndX = segment.End.X;
            double sEndY = segment.End.Y;
            if (dotX >= sBeginX && dotX <= sEndX && dotY >= sBeginY && dotY <= sEndY)
            {
                double dx1 = sEndX - sBeginX;
                double dy1 = sEndY - sBeginY;
                double dx = dotX - sBeginX;
                double dy = dotY - sBeginY;
                double s = dx1 * dy - dx * dy1;
                if (s == 0)
                    return true;
                return false;
            }
            else return false;
        }


        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }
    }
}