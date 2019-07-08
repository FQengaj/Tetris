using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tetris
{
    public abstract class Minos
    {
        public List<Dim2D> body = new List<Dim2D>();
        public Brush color;
        public ori orient = ori.N;
        public string name = "ParentMino";
        public int id = 7;

        public void Remove(Dim2D pos)
        {
            try
            {
                body.Remove(pos);
            }
            catch
            {
                Console.WriteLine("Failed to remove element" + pos);
            }
        }

        public List<Dim2D> getBody() { return this.body; }

        
        public override string ToString()
        {
            string result = this.name + "@ ";
            foreach(Dim2D pos in this.body)
            {
                result += pos.ToString() + ", ";
            }
            return result;
        }

        protected List<Dim2D> Clone(List<Dim2D> body)
        {
            List<Dim2D> res = new List<Dim2D>();
            foreach (Dim2D pos in body)
            {
                res.Add(new Dim2D(pos.x, pos.y));
            }
            return res;
        }

        internal void moveTo(Dim2D nextMove)
        {       
            for (int i = 0; i < this.body.Count; i++)
            {
                this.body[i] += nextMove;
            }
        }

        internal ori getNextOrientation(bool direction)
        {
            if (direction == true) // Clockwise
            {
                switch (this.orient)
                {
                    case ori.N:
                        return ori.W;
                    case ori.E:
                        return ori.N;
                    case ori.S:
                        return ori.E;
                    case ori.W:
                        return ori.S;
                }
            }
            else
            {
                switch (this.orient)
                {
                    case ori.N:
                        return ori.E;
                    case ori.E:
                        return ori.S;
                    case ori.S:
                        return ori.W;
                    case ori.W:
                        return ori.N;
                }

            }
            return ori.N;
        }


        public abstract Minos rotateClockwise();

        public abstract Minos rotateCounterClockwise();

        protected void setBody(List<Dim2D> newBody)
        {
            this.body = newBody;
        }

        //public abstract Minos Clone();

    }
}