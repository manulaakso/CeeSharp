namespace Tehtava_11
{
    partial class NopanHeittoFM
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
            this.label1 = new System.Windows.Forms.Label();
            this.HeitaBT = new System.Windows.Forms.Button();
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.Noppa01PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nopan heitto";
            // 
            // HeitaBT
            // 
            this.HeitaBT.Location = new System.Drawing.Point(94, 243);
            this.HeitaBT.Name = "HeitaBT";
            this.HeitaBT.Size = new System.Drawing.Size(252, 42);
            this.HeitaBT.TabIndex = 3;
            this.HeitaBT.Text = "Heitä!";
            this.HeitaBT.UseVisualStyleBackColor = true;
            this.HeitaBT.Click += new System.EventHandler(this.HeitaBT_Click);
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = global::Tehtava_11.Properties.Resources.rollingDice1;
            this.Noppa02PB.Location = new System.Drawing.Point(246, 107);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(100, 100);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa02PB.TabIndex = 2;
            this.Noppa02PB.TabStop = false;
            // 
            // Noppa01PB
            // 
            this.Noppa01PB.Image = global::Tehtava_11.Properties.Resources.rollingDice;
            this.Noppa01PB.Location = new System.Drawing.Point(94, 107);
            this.Noppa01PB.Name = "Noppa01PB";
            this.Noppa01PB.Size = new System.Drawing.Size(100, 100);
            this.Noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa01PB.TabIndex = 1;
            this.Noppa01PB.TabStop = false;
            // 
            // NopanHeittoFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 363);
            this.Controls.Add(this.HeitaBT);
            this.Controls.Add(this.Noppa02PB);
            this.Controls.Add(this.Noppa01PB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NopanHeittoFM";
            this.Text = "Nopan heitto";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Noppa01PB;
        private System.Windows.Forms.PictureBox Noppa02PB;
        private System.Windows.Forms.Button HeitaBT;
    }
}

