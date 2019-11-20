using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyVectorTask
{
    public class ReadOnlyVector
    {
        public readonly double X;
        public readonly double Y;

        public ReadOnlyVector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public ReadOnlyVector Add(ReadOnlyVector other) => new ReadOnlyVector(other.X + this.X, other.Y + this.Y);

        public ReadOnlyVector WithX(double newX) => new ReadOnlyVector(newX, this.Y);

        public ReadOnlyVector WithY(double newY) => new ReadOnlyVector(this.X, newY);
    }
}
