using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Model.Mino
{
    public class Ghost : Minos
    {

        public Ghost()
        {
            init();
        }

        public Ghost(List<Dim2D> initbody)
        {
            init();
            setBody(initbody);
        }

        private void init()
        {
            this.id = -1;
            this.name = "Ghost";
            this.color = Brushes.SlateGray;
        }

        public void setBody(List<Dim2D> newBody)
        {
            this.body = new List<Dim2D>();
            foreach (Dim2D bdyPos in newBody)
            {
                this.body.Add(new Dim2D(bdyPos.x, bdyPos.y));
            }
        }


        public override Minos rotateClockwise(){ return null; }
    }
}
