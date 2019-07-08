﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Model.Mino
{
    class LMino : Minos
    {
        public LMino()
        {
            this.id = 1;
            this.name = "LMino";
            this.color = Brushes.Orange;
            this.body.Add(new Dim2D(2, 0));
            this.body.Add(new Dim2D(2, 1));
            this.body.Add(new Dim2D(1, 1));
            this.body.Add(new Dim2D(0, 1));
        }

        public override Minos rotateClockwise()
        {
            return rotate(true);
        }

        public override Minos rotateCounterClockwise()
        {
            return rotate(false);
        }

        private Minos rotate(bool direction)
        {
            ori newori = getNextOrientation(direction);

            LMino result = new LMino();
            List<Dim2D> newBody = Clone(this.body);

            Dim2D fixpoint = this.body[2];
            switch (newori)
            {
                case ori.E:
                    newBody[0].set(fixpoint.x + 1, fixpoint.y + 1);
                    newBody[1].set(fixpoint.x, fixpoint.y + 1);
                    newBody[3].set(fixpoint.x, fixpoint.y - 1);

                    break;
                case ori.S:

                    newBody[0].set(fixpoint.x - 1, fixpoint.y + 1);
                    newBody[1].set(fixpoint.x - 1, fixpoint.y);
                    newBody[3].set(fixpoint.x + 1, fixpoint.y);
                    break;
                case ori.W:

                    newBody[0].set(fixpoint.x - 1, fixpoint.y - 1);
                    newBody[1].set(fixpoint.x, fixpoint.y - 1);
                    newBody[3].set(fixpoint.x, fixpoint.y + 1);
                    break;
                case ori.N:

                    newBody[0].set(fixpoint.x + 1, fixpoint.y - 1);
                    newBody[1].set(fixpoint.x + 1, fixpoint.y);
                    newBody[3].set(fixpoint.x - 1, fixpoint.y);
                    break;
            }

            result.setBody(newBody);
            result.orient = newori;
            return result;
        }
    }
}
