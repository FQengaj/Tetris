using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Model.Mino
{
    class JMino : Minos
    {
        public JMino()
        {
            this.id = 2;
            this.name = "JMino";
            this.color = Brushes.DarkBlue;
            this.body.Add(new Dim2D(0, 0));
            this.body.Add(new Dim2D(0, 1));
            this.body.Add(new Dim2D(1, 1));
            this.body.Add(new Dim2D(2, 1));
        }

        

        public override Minos rotateClockwise()
        {
            JMino result = new JMino();
            List<Dim2D> newBody = Clone(this.body);

            ori newori = ori.N;

            Dim2D fixpoint = this.body[2];
            switch (this.orient)
            {
                case ori.N:
                    // now rotate 90° clockwise
                    newori = ori.E;

                    newBody[0].set(fixpoint.x + 1, fixpoint.y - 1);
                    newBody[1].set(fixpoint.x, fixpoint.y - 1);
                    newBody[3].set(fixpoint.x, fixpoint.y + 1);
                    break;
                case ori.E:
                    newori = ori.S;

                    newBody[0].set(fixpoint.x + 1, fixpoint.y + 1);
                    newBody[1].set(fixpoint.x + 1, fixpoint.y);
                    newBody[3].set(fixpoint.x - 1, fixpoint.y);
                    break;
                case ori.S:
                    newori = ori.W;

                    newBody[0].set(fixpoint.x - 1, fixpoint.y + 1);
                    newBody[1].set(fixpoint.x, fixpoint.y + 1);
                    newBody[3].set(fixpoint.x, fixpoint.y - 1);
                    break;
                case ori.W:
                    newori = ori.N;

                    newBody[0].set(fixpoint.x - 1, fixpoint.y - 1);
                    newBody[1].set(fixpoint.x - 1, fixpoint.y);
                    newBody[3].set(fixpoint.x + 1, fixpoint.y);
                    break;
            }

            result.setBody(newBody);
            result.orient = newori;
            return result;
        }
    }
}
