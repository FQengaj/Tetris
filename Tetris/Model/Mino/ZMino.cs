using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Model.Mino
{
    class ZMino : Minos
    {
        public ZMino()
        {
            this.id = 3;
            this.name = "ZMino";
            this.color = Brushes.Red;
            this.body.Add(new Dim2D(1, 0));
            this.body.Add(new Dim2D(2, 1));
            this.body.Add(new Dim2D(1, 1));
            this.body.Add(new Dim2D(0, 0));
        }


        public override Minos rotateClockwise()
        {
            ZMino result = new ZMino();
            List<Dim2D> newBody = Clone(this.body);

            ori newori = ori.N;
            Dim2D fixpoint = this.body[0];
            switch (this.orient)
            {
                case ori.N:
                    newori = ori.E;

                    newBody[1].set(fixpoint.x - 1, fixpoint.y + 1);
                    newBody[2].set(fixpoint.x - 1, fixpoint.y);
                    newBody[3].set(fixpoint.x, fixpoint.y - 1);
                    break;
                case ori.E:
                    newori = ori.S;

                    newBody[1].set(fixpoint.x - 1, fixpoint.y - 1);
                    newBody[2].set(fixpoint.x, fixpoint.y - 1);
                    newBody[3].set(fixpoint.x + 1, fixpoint.y);
                    break;
                case ori.S:
                    newori = ori.W;

                    newBody[1].set(fixpoint.x + 1, fixpoint.y - 1);
                    newBody[2].set(fixpoint.x + 1, fixpoint.y);
                    newBody[3].set(fixpoint.x, fixpoint.y + 1);
                    break;
                case ori.W:
                    newori = ori.N;

                    newBody[1].set(fixpoint.x + 1, fixpoint.y + 1);
                    newBody[2].set(fixpoint.x, fixpoint.y + 1);
                    newBody[3].set(fixpoint.x - 1, fixpoint.y);
                    break;
            }
            result.setBody(newBody);
            result.orient = newori;
            return result;
        }
    }
}
