namespace Tetris
{
    partial class Tetris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        TetrisModel model = new TetrisModel();

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris));
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.MinoMovement = new System.Windows.Forms.Timer(this.components);
            this.pausePanel = new System.Windows.Forms.Panel();
            this.p_lbl2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_lbl = new System.Windows.Forms.Label();
            this.playField = new System.Windows.Forms.TetrisField();
            this.NextField3 = new System.Windows.Forms.TetrisField();
            this.NextField2 = new System.Windows.Forms.TetrisField();
            this.NextField1 = new System.Windows.Forms.TetrisField();
            this.HoldField = new System.Windows.Forms.TetrisField();
            this.points = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.Label();
            this.maxComb = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.pausePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(719, 291);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(161, 33);
            label1.TabIndex = 5;
            label1.Text = "Next Minos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(719, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 33);
            label2.TabIndex = 6;
            label2.Text = "Hold";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(3, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(104, 33);
            label4.TabIndex = 8;
            label4.Text = "Points:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.Desktop;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(202, 33);
            label5.TabIndex = 9;
            label5.Text = "Combo Count:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            label7.ForeColor = System.Drawing.SystemColors.Control;
            label7.Location = new System.Drawing.Point(3, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(224, 33);
            label7.TabIndex = 14;
            label7.Text = "Highest Combo:";
            // 
            // GameLoop
            // 
            this.GameLoop.Interval = 1000;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // MinoMovement
            // 
            this.MinoMovement.Interval = 1000;
            this.MinoMovement.Tick += new System.EventHandler(this.MinoMovement_Tick);
            // 
            // pausePanel
            // 
            this.pausePanel.BackColor = System.Drawing.Color.Transparent;
            this.pausePanel.Controls.Add(this.p_lbl2);
            this.pausePanel.Controls.Add(this.label3);
            this.pausePanel.Controls.Add(this.p_lbl);
            this.pausePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pausePanel.Location = new System.Drawing.Point(0, 0);
            this.pausePanel.Name = "pausePanel";
            this.pausePanel.Size = new System.Drawing.Size(937, 1269);
            this.pausePanel.TabIndex = 7;
            this.pausePanel.Visible = false;
            // 
            // p_lbl2
            // 
            this.p_lbl2.AutoSize = true;
            this.p_lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.125F);
            this.p_lbl2.ForeColor = System.Drawing.SystemColors.Control;
            this.p_lbl2.Location = new System.Drawing.Point(273, 394);
            this.p_lbl2.Name = "p_lbl2";
            this.p_lbl2.Size = new System.Drawing.Size(379, 47);
            this.p_lbl2.TabIndex = 2;
            this.p_lbl2.Text = "Press P to unpause";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // p_lbl
            // 
            this.p_lbl.AutoSize = true;
            this.p_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.125F);
            this.p_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.p_lbl.Location = new System.Drawing.Point(146, 299);
            this.p_lbl.Name = "p_lbl";
            this.p_lbl.Size = new System.Drawing.Size(636, 92);
            this.p_lbl.TabIndex = 0;
            this.p_lbl.Text = "Game is Paused";
            // 
            // playField
            // 
            this.playField.BackColor = System.Drawing.SystemColors.Control;
            this.playField.ColumnCount = 10;
            this.playField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.playField.Location = new System.Drawing.Point(12, 12);
            this.playField.Name = "playField";
            this.playField.RowCount = 20;
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.playField.Size = new System.Drawing.Size(652, 1250);
            this.playField.TabIndex = 0;
            // 
            // NextField3
            // 
            this.NextField3.ColumnCount = 5;
            this.NextField3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField3.Location = new System.Drawing.Point(725, 735);
            this.NextField3.Name = "NextField3";
            this.NextField3.RowCount = 5;
            this.NextField3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField3.Size = new System.Drawing.Size(200, 198);
            this.NextField3.TabIndex = 4;
            // 
            // NextField2
            // 
            this.NextField2.ColumnCount = 5;
            this.NextField2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField2.Location = new System.Drawing.Point(725, 531);
            this.NextField2.Name = "NextField2";
            this.NextField2.RowCount = 5;
            this.NextField2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField2.Size = new System.Drawing.Size(200, 198);
            this.NextField2.TabIndex = 3;
            // 
            // NextField1
            // 
            this.NextField1.ColumnCount = 5;
            this.NextField1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField1.Location = new System.Drawing.Point(725, 327);
            this.NextField1.Name = "NextField1";
            this.NextField1.RowCount = 5;
            this.NextField1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NextField1.Size = new System.Drawing.Size(200, 198);
            this.NextField1.TabIndex = 2;
            // 
            // HoldField
            // 
            this.HoldField.ColumnCount = 5;
            this.HoldField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HoldField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HoldField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HoldField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HoldField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HoldField.Location = new System.Drawing.Point(725, 48);
            this.HoldField.Name = "HoldField";
            this.HoldField.RowCount = 5;
            this.HoldField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HoldField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HoldField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HoldField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HoldField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HoldField.Size = new System.Drawing.Size(200, 198);
            this.HoldField.TabIndex = 1;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.SystemColors.Control;
            this.points.Location = new System.Drawing.Point(3, 33);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(146, 37);
            this.points.TabIndex = 10;
            this.points.Text = "1237123";
            // 
            // combo
            // 
            this.combo.AutoSize = true;
            this.combo.BackColor = System.Drawing.SystemColors.Desktop;
            this.combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.ForeColor = System.Drawing.SystemColors.Control;
            this.combo.Location = new System.Drawing.Point(3, 33);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(132, 42);
            this.combo.TabIndex = 11;
            this.combo.Text = "Nothin";
            // 
            // maxComb
            // 
            this.maxComb.AutoSize = true;
            this.maxComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxComb.ForeColor = System.Drawing.SystemColors.Control;
            this.maxComb.Location = new System.Drawing.Point(3, 33);
            this.maxComb.Name = "maxComb";
            this.maxComb.Size = new System.Drawing.Size(36, 37);
            this.maxComb.TabIndex = 15;
            this.maxComb.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(670, 939);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 318);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(label4);
            this.flowLayoutPanel2.Controls.Add(this.points);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(242, 100);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(label5);
            this.flowLayoutPanel3.Controls.Add(this.combo);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(13, 109);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(242, 100);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(label7);
            this.flowLayoutPanel4.Controls.Add(this.maxComb);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(13, 215);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(242, 100);
            this.flowLayoutPanel4.TabIndex = 18;
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(937, 1269);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pausePanel);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.playField);
            this.Controls.Add(this.NextField3);
            this.Controls.Add(this.NextField2);
            this.Controls.Add(this.NextField1);
            this.Controls.Add(this.HoldField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tetris";
            this.Text = "Tetris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tetris_KeyDown);
            this.pausePanel.ResumeLayout(false);
            this.pausePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TetrisField playField;
        private System.Windows.Forms.TetrisField HoldField;
        private System.Windows.Forms.TetrisField NextField1;
        private System.Windows.Forms.TetrisField NextField2;
        private System.Windows.Forms.TetrisField NextField3;
        public System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Timer MinoMovement;
        private System.Windows.Forms.Panel pausePanel;
        private System.Windows.Forms.Label p_lbl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label p_lbl;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label combo;
        private System.Windows.Forms.Label maxComb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    }
}