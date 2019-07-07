using System.Collections.Generic;
using Tetris;

namespace System.Windows.Forms
{
    internal class TetrisField : TableLayoutPanel
    {
        //implement as observer so it does not have to check every time

        private TetrisModel model;
        private FieldType mytype;

        public void init(TetrisModel model, FieldType mytype) {
            this.model = model;
            this.mytype = mytype;
        }

        public FieldType Type
        {
            get { return mytype; }
            set { mytype = value; }
        }
        public TetrisModel Model
        {
            set { model = value; }
        }

        protected override void OnCellPaint(TableLayoutCellPaintEventArgs e)
        {
            //nicht immer die bereits gesetzten setzen.
            base.OnCellPaint(e);
            Dim2D Cell = new Dim2D(e.Column, e.Row);
            if (this.model == null) return;
            List<Minos> myDispMino = getDispElem();

            if (myDispMino.Count == 0) return;

            foreach (Minos currMino in myDispMino)
            {
                if (currMino == null) continue;
                foreach (Dim2D currPos in currMino.getBody())
                {
                    if (Cell.Equals(currPos))
                        e.Graphics.FillRectangle(currMino.color, e.CellBounds);
                    else { }
                        //e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

                }
            }
        }

        private List<Minos> getDispElem()
        {
            List<Minos> result = new List<Minos>();

            switch (mytype)
            {
                case FieldType.MAIN:
                    result.AddRange(model.getPlacedMino());
                    result.Add(model.Ghost);
                    result.Add(model.getCurrMino());
                    break;
                case FieldType.HOLD:
                    result.Add(model.getHold());
                    break;
                case FieldType.NEXT1:
                    result.Add(model.getNextMino(0));
                    break;
                case FieldType.NEXT2:
                    result.Add(model.getNextMino(1));
                    break;
                case FieldType.NEXT3:
                    result.Add(model.getNextMino(2));
                    break;
            }

            return result;
        }
    }
}