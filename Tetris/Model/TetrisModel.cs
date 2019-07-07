using System;
using System.Collections.Generic;
using Tetris.Model.Mino;

namespace Tetris
{
    public class TetrisModel
    {
        List<Dim2D> bannedDim2D = new List<Dim2D>(); // needs to be sorted every time .add is called
        List<Minos> placedMino = new List<Minos>();
        List<Minos> nextMino;

        public Ghost Ghost;
        Minos currMino;
        Minos hold = null;
        Dim2D startLocation = new Dim2D(4, -1);
        bool swapable = true;

        bool inCombo = false;
        int comboCount = 0;
        int Points = 0;

        Random r = new Random();

        public TetrisModel()
        {
            //todo init minos bla bla 
            this.nextMino = newRandomMinos(3);
            //this.hold = newRandomMino();
            this.currMino = newRandomMino();
            this.currMino.moveTo(startLocation);
            this.Ghost = new Ghost(currMino.getBody());
        }

        public int points { get { return this.Points; } }
        public int combocount { get { return this.comboCount; } }

        private List<Minos> newRandomMinos(int v)
        {
            List<Minos> result = new List<Minos>();
            for (int i = 0; i < v; i++)
            {
                result.Add(newRandomMino());
            }
            return result;
        }

        public Minos newRandomMino()
        {
            //return new LMino();
            int ri = this.r.Next(7);
            switch (ri)
            {
                case 0: return new TMino();
                case 1: return new LMino();
                case 2: return new JMino();
                case 3: return new ZMino();
                case 4: return new SMino();
                case 5: return new OMino();
                case 6: return new IMino();
                default:
                    throw new Exception("deamn boi whats this?");
            }


        }

        internal Minos rotateMino()
        {
            return currMino.rotateClockwise();
        }

        internal Minos getCurrMino()
        {
            return this.currMino;
        }

        internal Minos getHold()
        {
            return this.hold;
        }

        internal Minos getNextMino(int i)
        {
            return this.nextMino[i];
        }

        internal bool Hold()
        {
            if (this.swapable)
            {
                Minos currMinoCopy = emptyClassOf(this.currMino);

                if (this.hold == null)
                {
                    this.hold = currMinoCopy;
                    this.currMino = this.nextMino[0];
                    this.nextMino.RemoveAt(0);
                    this.nextMino.Add(newRandomMino());
                }
                else
                {
                    this.currMino = this.hold;
                    this.hold = currMinoCopy;

                }
                
                this.currMino.moveTo(startLocation);
                this.swapable = false;
                return true;
            }
            return false;
        }

        public Minos emptyClassOf(Minos target)
        {
            switch (target.id)
            {
                case 0: return new TMino(); 
                case 1: return new LMino();
                case 2: return new JMino();
                case 3: return new ZMino();
                case 4: return new SMino();
                case 5: return new OMino();
                case 6: return new IMino();
                default:
                    return new Ghost();
            }
        }

        internal void dropMino()
        {
            this.placedMino.Add(this.currMino);

            if(this.placedMino.Count >= 30)
            {
                for(int k = 0; k < this.placedMino.Count; k++)
                {
                    if (this.placedMino[k].getBody().Count == 0)
                    {
                        this.placedMino.RemoveAt(k);
                        k--;
                    }
                }
            }

            foreach (Dim2D pos in this.currMino.getBody())
            {
                this.bannedDim2D.Add(pos);
            }
            this.bannedDim2D.Sort();

            List<int> linesToClear = new List<int>();

            if (bannedDim2D.Count >= 10)
            {
                int blockCount = 0;
                int y = this.bannedDim2D[0].y;
                foreach(Dim2D curr in this.bannedDim2D)
                {
                    if (y.Equals(curr.y))
                    {
                        blockCount++;
                    }
                    else
                    {
                        y = curr.y;
                        blockCount = 1;
                    }
                    if (blockCount == 10)
                    {
                        linesToClear.Add(y);
                    }

                    if (linesToClear.Count == 4)
                    {
                        break;
                    }

                }

                foreach (Minos mino in this.placedMino)
                {
                    List<Dim2D> currBody = mino.getBody();
                    for(int i = currBody.Count-1; i >= 0; i--)
                    {
                        foreach(int yval in linesToClear)
                        {
                            if (currBody[i].y == yval)
                            {
                                currBody.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }

                for (int i = linesToClear.Count - 1; i >= 0; i--)
                {
                    foreach (Minos mino in this.placedMino)
                    {
                        List<Dim2D> currBody = mino.getBody();
                        for(int j = 0; j < currBody.Count; j++)
                        {
                            Dim2D pos = currBody[j];
                            if (pos.y < linesToClear[i])
                            {
                                currBody[j] += new Dim2D(0, 1);
                            }
                        }
                    }
                }

                List<Dim2D> newBannedPos = new List<Dim2D>();
                foreach(Minos mino in this.placedMino)
                {
                    newBannedPos.AddRange(mino.getBody());
                }
                bannedDim2D = newBannedPos;

            }

            int linesCleared = linesToClear.Count;
            if (linesCleared > 0)
            {
                inCombo = true;
                if (inCombo)
                {
                    comboCount += linesCleared;
                }
                Points += 100 * linesCleared * combocount; 
            }
            else
            {
                inCombo = false;
                comboCount = 0;
            }

            this.currMino = this.nextMino[0];
            this.currMino.moveTo(startLocation);
            this.nextMino[0] = this.nextMino[1];
            this.nextMino[1] = this.nextMino[2];
            this.nextMino[2] = newRandomMino();
            this.swapable = true;

        }

        internal void setCurrMino(Minos newCurrMino)
        {
            this.currMino = newCurrMino;
        }

        public List<Minos> getPlacedMino()
        {
            return placedMino;
        }


        public List<Dim2D> getBlockedPos()
        {
            return bannedDim2D;
        }

    }
}