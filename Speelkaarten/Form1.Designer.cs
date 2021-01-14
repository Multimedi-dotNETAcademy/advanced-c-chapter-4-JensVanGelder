
namespace Speelkaarten
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.lblDrawn = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblDeck = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDrawn
            // 
            this.lblDrawn.AutoSize = true;
            this.lblDrawn.Location = new System.Drawing.Point(321, 41);
            this.lblDrawn.Name = "lblDrawn";
            this.lblDrawn.Size = new System.Drawing.Size(41, 13);
            this.lblDrawn.TabIndex = 0;
            this.lblDrawn.Text = "Drawn:";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(173, 36);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw Card";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.Location = new System.Drawing.Point(47, 41);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(36, 13);
            this.lblDeck.TabIndex = 2;
            this.lblDeck.Text = "Deck:";
            // 
            // btnShuffle
            // 
            this.btnShuffle.Enabled = false;
            this.btnShuffle.Location = new System.Drawing.Point(173, 81);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 3;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 660);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblDrawn);
            this.Name = "Form1";
            this.Text = "Speelkaarten";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrawn;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.Button btnShuffle;
    }
}

