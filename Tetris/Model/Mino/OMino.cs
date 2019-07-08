using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Model.Mino
{
    class OMino : Minos
    {
        public OMino()
        {
            this.id = 5;
            this.name = "OMino";
            this.color = Brushes.Yellow;
            this.body.Add(new Dim2D(0, 0));
            this.body.Add(new Dim2D(0, 1));
            this.body.Add(new Dim2D(1, 0));
            this.body.Add(new Dim2D(1, 1));
        }

        public override Minos rotateClockwise()
        {
            return rotate();
        }

        public override Minos rotateCounterClockwise()
        {
            return rotate();
        }

        private Minos rotate()
        {
            OMino res = new OMino();
            res.setBody(this.body);
            return res;
        }
    }
}
