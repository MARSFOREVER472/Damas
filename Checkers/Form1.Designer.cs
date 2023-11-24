namespace Checkers
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.G = new System.Windows.Forms.Panel();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtJugador1 = new System.Windows.Forms.Label();
            this.txtJugador2 = new System.Windows.Forms.Label();
            this.nickPlayer1 = new System.Windows.Forms.TextBox();
            this.nickPlayer2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            this.SuspendLayout();
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.Gray;
            this.G.Location = new System.Drawing.Point(10, 10);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(604, 622);
            this.G.TabIndex = 0;
            // 
            // Player1
            // 
            this.Player1.Image = global::Checkers.Properties.Resources.g;
            this.Player1.Location = new System.Drawing.Point(620, 12);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(50, 50);
            this.Player1.TabIndex = 1;
            this.Player1.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.Image = global::Checkers.Properties.Resources.r;
            this.Player2.Location = new System.Drawing.Point(620, 582);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(50, 50);
            this.Player2.TabIndex = 2;
            this.Player2.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlayer1.Location = new System.Drawing.Point(676, 12);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(178, 46);
            this.lblPlayer1.TabIndex = 3;
            this.lblPlayer1.Text = "Score: 0";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer2.Location = new System.Drawing.Point(676, 582);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(178, 46);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "Score: 0";
            // 
            // txtJugador1
            // 
            this.txtJugador1.AutoSize = true;
            this.txtJugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJugador1.ForeColor = System.Drawing.Color.Green;
            this.txtJugador1.Location = new System.Drawing.Point(620, 65);
            this.txtJugador1.Name = "txtJugador1";
            this.txtJugador1.Size = new System.Drawing.Size(139, 37);
            this.txtJugador1.TabIndex = 5;
            this.txtJugador1.Text = "Player 1";
            // 
            // txtJugador2
            // 
            this.txtJugador2.AutoSize = true;
            this.txtJugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJugador2.ForeColor = System.Drawing.Color.Maroon;
            this.txtJugador2.Location = new System.Drawing.Point(620, 542);
            this.txtJugador2.Name = "txtJugador2";
            this.txtJugador2.Size = new System.Drawing.Size(141, 37);
            this.txtJugador2.TabIndex = 6;
            this.txtJugador2.Text = "Player 2";
            // 
            // nickPlayer1
            // 
            this.nickPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickPlayer1.Location = new System.Drawing.Point(765, 65);
            this.nickPlayer1.Name = "nickPlayer1";
            this.nickPlayer1.Size = new System.Drawing.Size(124, 32);
            this.nickPlayer1.TabIndex = 7;
            // 
            // nickPlayer2
            // 
            this.nickPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickPlayer2.Location = new System.Drawing.Point(767, 542);
            this.nickPlayer2.Name = "nickPlayer2";
            this.nickPlayer2.Size = new System.Drawing.Size(124, 32);
            this.nickPlayer2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 649);
            this.Controls.Add(this.nickPlayer2);
            this.Controls.Add(this.nickPlayer1);
            this.Controls.Add(this.txtJugador2);
            this.Controls.Add(this.txtJugador1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.G);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Juego de Damas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel G;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label txtJugador1;
        private System.Windows.Forms.Label txtJugador2;
        private System.Windows.Forms.TextBox nickPlayer1;
        private System.Windows.Forms.TextBox nickPlayer2;
    }
}

