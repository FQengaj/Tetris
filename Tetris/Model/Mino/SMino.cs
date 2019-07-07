using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Model.Mino
{
    class SMino : Minos
    {
        public SMino()
        {
            this.id = 4;
            this.name = "SMino";
            this.color = Brushes.Green;
            this.body.Add(new Dim2D(1, 0));
            this.body.Add(new Dim2D(2, 0));
            this.body.Add(new Dim2D(1, 1));
            this.body.Add(new Dim2D(0, 1));
        }

        public override Minos rotateClockwise()
        {
            SMino result = new SMino();
            List<Dim2D> newBody = Clone(this.body);

            ori newori = ori.N;
            Dim2D fixpoint = this.body[0];
            switch (this.orient)
            {
                case ori.N:
                    newori = ori.E;

                    newBody[1].set(fixpoint.x, fixpoint.y + 1);
                    newBody[2].set(fixpoint.x - 1, fixpoint.y);
                    newBody[3].set(fixpoint.x - 1, fixpoint.y - 1);
                    break;
                case ori.E:
                    newori = ori.S;

                    newBody[1].set(fixpoint.x - 1, fixpoint.y);
                    newBody[2].set(fixpoint.x, fixpoint.y - 1);
                    newBody[3].set(fixpoint.x + 1, fixpoint.y - 1);
                    break;
                case ori.S:
                    newori = ori.W;

                    newBody[1].set(fixpoint.x, fixpoint.y -1);
                    newBody[2].set(fixpoint.x + 1, fixpoint.y);
                    newBody[3].set(fixpoint.x + 1, fixpoint.y + 1);
                    break;
                case ori.W:
                    newori = ori.N;

                    newBody[1].set(fixpoint.x + 1, fixpoint.y);
                    newBody[2].set(fixpoint.x, fixpoint.y + 1);
                    newBody[3].set(fixpoint.x - 1, fixpoint.y + 1);
                    break;
            }
            result.setBody(newBody);
            result.orient = newori;
            return result;
        }
    }
}
