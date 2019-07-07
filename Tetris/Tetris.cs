using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Tetris : Form
    {

        //public bool debug = true;
        private bool pause = false;
        public Tetris()
        {
            this.InitializeComponent();


            this.playField.init(this.model, FieldType.MAIN);
            this.HoldField.init(this.model, FieldType.HOLD);
            this.NextField1.init(this.model, FieldType.NEXT1);
            this.NextField2.init(this.model, FieldType.NEXT2);
            this.NextField3.init(this.model, FieldType.NEXT3);
            this.playField.Focus();
            updateGhost();
            updatePoints();
        }

        public void restartGame()
        {
            this.model = new TetrisModel();
            this.playField.Model = this.model;
            this.HoldField.Model = this.model;
            this.NextField1.Model = this.model;
            this.NextField2.Model = this.model;
            this.NextField3.Model = this.model;
            

            this.GameLoop.Stop();
            this.MinoMovement.Stop();
            this.pause = false;

        }

        private void Tetris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                bool GameLoopisRunning = GameLoop.Enabled;
                MinoMovement.Stop();
                GameLoop.Stop();
                pause = true;
                pausePanel.Visible = true;
                DialogResult dr = MessageBox.Show("Exit the game?",
                      "Exit Dialog", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        this.Close();
                        break;
                    case DialogResult.No:
                        MinoMovement.Start();
                        if (GameLoopisRunning) { GameLoop.Start(); } else { GameLoop.Stop(); }
                        pausePanel.Visible = false;
                        pause = false;
                        break;
                }
            }
            if (e.KeyCode == Keys.P)
            {
                if (pause)
                {
                    pause = false;
                    MinoMovement.Start();
                }
                else
                {
                    pause = true;
                    MinoMovement.Stop();
                }
                pausePanel.Visible = pause;
            }
            else if (!pause)
            {
                bool changedPlayField = false;
                bool changedSideField = false;
                Dim2D nextMove = null;
                if (e.KeyCode == Keys.Down)
                {
                    nextMove = new Dim2D(0, 1);
                    Minos newCurrMino = simMoveTo(this.model.getCurrMino(), nextMove);
                    if (!isValid(newCurrMino))
                    {
                        GameLoop.Start();
                        return;
                    }
                    if (e.Shift)
                    {
                        this.model.getCurrMino().body.Clear();
                        foreach (Dim2D pos in this.model.Ghost.body)
                        {
                            this.model.getCurrMino().body.Add(new Dim2D(pos.x, pos.y));
                        }
                    }
                    else
                    {
                        this.model.setCurrMino(newCurrMino);
                    }
                    MinoMovement.Stop();
                    MinoMovement.Start();
                    changedPlayField = true;
                } // Move down
                else if (e.KeyCode == Keys.Right)
                {
                    GameLoop.Stop();
                    nextMove = new Dim2D(1, 0);
                    Minos newCurrMino = simMoveTo(this.model.getCurrMino(), nextMove);
                    if (!isValid(newCurrMino))
                    {
                        GameLoop.Start();
                        return;
                    }
                    if (e.Shift)
                    {
                        while (true)
                        {
                            Minos temp = simMoveTo(newCurrMino, nextMove);
                            if (isValid(temp))
                            {
                                newCurrMino = temp;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    this.model.setCurrMino(newCurrMino);
                    updateGhost();
                    changedPlayField = true;
                } // Move Right
                else if (e.KeyCode == Keys.Left)
                {
                    GameLoop.Stop();
                    nextMove = new Dim2D(-1, 0);
                    Minos newCurrMino = simMoveTo(this.model.getCurrMino(), nextMove);
                    if (!isValid(newCurrMino))
                    {
                        GameLoop.Start();
                        return;
                    }
                    if (e.Shift)
                    {
                        while (true)
                        {
                            Minos temp = simMoveTo(newCurrMino, nextMove);
                            if (isValid(temp))
                            {
                                newCurrMino = temp;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    this.model.setCurrMino(newCurrMino);
                    updateGhost();
                    changedPlayField = true;
                } // Move Left
                else if (e.KeyCode == Keys.Up)
                {
                    GameLoop.Stop();
                    Minos rotate = this.model.rotateMino();
                    if (true/*isValid(rotate)*/)
                    {   
                        this.model.setCurrMino(rotate);
                        updateGhost();
                        changedPlayField = true;
                    }
                    else
                    {

                    }//move mino to a valid Direction i.e. if it is out left move it to the right.
                } // Rotate Mino
                else  if (e.KeyCode == Keys.Space){

                    this.model.setCurrMino(letFall(this.model.getCurrMino()));
                    dropMino();
                    updateGhost();
                    updatePoints();
                } // skip to bottum
                else if (e.KeyCode == Keys.C)
                {
                
                    bool isSwaped = model.Hold();
                    if (isSwaped)
                    {
                        updateGhost();
                        changedPlayField = true;
                        changedSideField = true;
                    }
                } // Hold Mino
                else if (e.KeyCode == Keys.R)
                {
                    restartGame();
                    updateGhost();
                    updatePoints();
                    changedPlayField = true;
                    changedSideField = true;
                }
                if (changedPlayField)
                {

                    this.playField.Invalidate();
                    if (changedSideField)
                    {
                        this.HoldField.Invalidate();
                        this.NextField1.Invalidate();
                        this.NextField2.Invalidate();
                        this.NextField3.Invalidate();
                    }
                } // invalidate 
                if (!GameLoop.Enabled)
                {
                    GameLoop.Start();
                }
            }
            
        }

        private String strOf(ori oldOri)
        {
            switch (oldOri)
            {
                case ori.N:
                    return "North";
                case ori.E:
                    return "East";
                case ori.S:
                    return "South";
                case ori.W:
                    return "West";
            }
            return "";
        }

        private Minos letFall(Minos mino)
        {
            Dim2D down = new Dim2D(0, 1);

            Minos lastMove = mino;
            Minos simMove = simMoveTo(lastMove, down);
            while (isValid(simMove))
            {
                lastMove = simMove;
                simMove = simMoveTo(lastMove, down);
            }
            return lastMove;
        }

        private void updateGhost()
        {
            this.model.Ghost.setBody(letFall(this.model.getCurrMino()).getBody());
        }

        private void updatePoints()
        {
            int combocount = model.combocount;
            this.points.Text = model.points + "";
            this.combo.Text = combocount + "";
            this.combo.Font = new Font(this.points.Font.FontFamily, this.points.Font.Size+(3*combocount));


            int currMaxComb = Int32.Parse(maxComb.Text);
            if (currMaxComb < combocount)
                maxComb.Text = combocount + "";
        }

        private bool isValid(Minos newCurrMino)
        {
            foreach(Dim2D currPos in newCurrMino.body)
            {
                if (currPos.x > 9 || currPos.x < 0)
                {
                    return false;
                }
                if (currPos.y > 19)
                {
                    return false;
                }
                foreach (Dim2D blockedPos in model.getBlockedPos())
                {
                    if (currPos.Equals(blockedPos))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private Minos simMoveTo(Minos mino, Dim2D nextMove)
        {
            List<Dim2D> result = copybody(mino);

            for (int i = 0; i < mino.body.Count; i++)
            {
                result[i] += nextMove;
            }

            Minos res = model.emptyClassOf(mino);
            res.body = result;
            res.orient = mino.orient;

            return res;
        }

        private List<Dim2D> copybody(Minos mino)
        {
            List<Dim2D> result = new List<Dim2D>();
            foreach(Dim2D bdyPos in mino.getBody())
            {
                result.Add(new Dim2D(bdyPos.x, bdyPos.y));
            }
            return result;
        }

        private void MinoMovement_Tick(object sender, EventArgs e)
        {
            Dim2D nextMove = new Dim2D(0, 1);
            Minos newCurrMino = simMoveTo(this.model.getCurrMino(), nextMove);
            if (isValid(newCurrMino))
            {
                this.model.setCurrMino(newCurrMino);
                this.playField.Invalidate();
            }
            else
            {
                if (!GameLoop.Enabled)
                {
                    GameLoop.Start();
                }
            }
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            Dim2D nextMove = new Dim2D(0, 1);
            Minos newCurrMino = simMoveTo(this.model.getCurrMino(), nextMove);
            if (!isValid(newCurrMino))
            {
                dropMino();
            }
            else
            {
                GameLoop.Stop();
            }
        }

        private void dropMino()
        {
            GameLoop.Stop();
            MinoMovement.Stop();

            this.model.dropMino();
            updateGhost();
            updatePoints();

            this.playField.Invalidate();
            this.HoldField.Invalidate();
            this.NextField1.Invalidate();
            this.NextField2.Invalidate();
            this.NextField3.Invalidate();
            MinoMovement.Start();
        }
        
    }
}