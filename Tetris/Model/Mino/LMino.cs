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
            LMino result = new LMino();
            List<Dim2D> newBody = Clone(this.body);

            ori newori = ori.N;

            
            Dim2D fixpoint = this.body[2];
            switch (this.orient)
            {
                case ori.N:
                    // now rotate 90° clockwise

                    newBody[0].set(fixpoint.x + 1, fixpoint.y + 1);
                    newBody[1].set(fixpoint.x, fixpoint.y + 1);
                    newBody[3].set(fixpoint.x, fixpoint.y - 1);

                    newori = ori.E;
                    break;
                case ori.E:

                    newBody[0].set(fixpoint.x - 1, fixpoint.y + 1);
                    newBody[1].set(fixpoint.x - 1, fixpoint.y);
                    newBody[3].set(fixpoint.x + 1, fixpoint.y);

                    newori = ori.S;
                    break;
                case ori.S:

                    newBody[0].set(fixpoint.x - 1, fixpoint.y - 1);
                    newBody[1].set(fixpoint.x, fixpoint.y - 1);
                    newBody[3].set(fixpoint.x, fixpoint.y + 1);

                    newori = ori.W;
                    break;
                case ori.W:

                    newBody[0].set(fixpoint.x + 1, fixpoint.y - 1);
                    newBody[1].set(fixpoint.x + 1, fixpoint.y);
                    newBody[3].set(fixpoint.x - 1, fixpoint.y);

                    newori = ori.N;
                    break;
            }
            result.setBody(newBody);
            result.orient = newori;
            return result;
        }
    }
}