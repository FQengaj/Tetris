namespace Tetris
{
    partial class Lobby
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_credits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "Tetris";
            this.label1.AccessibleName = "title";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(151, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tetris";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "Tetris";
            this.label2.AccessibleName = "title";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(75, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to ";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(138, 195);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(171, 50);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // btn_credits
            // 
            this.btn_credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_credits.Location = new System.Drawing.Point(138, 251);
            this.btn_credits.Name = "btn_credits";
            this.btn_credits.Size = new System.Drawing.Size(171, 50);
            this.btn_credits.TabIndex = 3;
            this.btn_credits.Text = "Credits";
            this.btn_credits.UseVisualStyleBackColor = true;
            this.btn_credits.Click += new System.EventHandler(this.Btn_credits_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(438, 540);
            this.Controls.Add(this.btn_credits);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lobby";
            this.Text = "Tetris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_credits;
    }
}

