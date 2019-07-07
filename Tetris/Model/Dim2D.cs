using System;

namespace Tetris
{
    public class Dim2D : IEquatable<Dim2D>, IComparable
    {
        public int x;
        public int y;

        public Dim2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Dim2D other = obj as Dim2D;
            if (other == null) return false;
            else return Equals(other);
        }

        public bool Equals(Dim2D other)
        {
            if (other == null) return false;
            bool sameX = this.x.Equals(other.x);

            return (sameX) ? this.y.Equals(other.y) : sameX;
        }

        public static Dim2D operator +(Dim2D t, Dim2D o)
        {
            return new Dim2D(t.x + o.x, t.y + o.y);
        }

        internal void set(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "("+ this.x +", "+ this.y +")" ;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -1;
            Dim2D other = obj as Dim2D;
            int yComp = this.y.CompareTo(other.y);
            if (yComp == 0)
            {
                return this.x.CompareTo(other.x);
            }
            else
            {
                return -1 * yComp;
            }
                
        }
    }
}