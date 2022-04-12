namespace EncryptDecrypt
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
            this.cryptaaBT = new System.Windows.Forms.Button();
            this.salasanaBT = new System.Windows.Forms.Button();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.cryptattuTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cryptaaBT
            // 
            this.cryptaaBT.Location = new System.Drawing.Point(547, 39);
            this.cryptaaBT.Name = "cryptaaBT";
            this.cryptaaBT.Size = new System.Drawing.Size(175, 57);
            this.cryptaaBT.TabIndex = 0;
            this.cryptaaBT.Text = "Cryptaa";
            this.cryptaaBT.UseVisualStyleBackColor = true;
            this.cryptaaBT.Click += new System.EventHandler(this.cryptaaBT_Click);
            // 
            // salasanaBT
            // 
            this.salasanaBT.Location = new System.Drawing.Point(547, 140);
            this.salasanaBT.Name = "salasanaBT";
            this.salasanaBT.Size = new System.Drawing.Size(175, 57);
            this.salasanaBT.TabIndex = 1;
            this.salasanaBT.Text = "Näytä salasana";
            this.salasanaBT.UseVisualStyleBackColor = true;
            this.salasanaBT.Click += new System.EventHandler(this.salasanaBT_Click);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(40, 54);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(448, 26);
            this.salasanaTB.TabIndex = 2;
            // 
            // cryptattuTB
            // 
            this.cryptattuTB.Location = new System.Drawing.Point(40, 155);
            this.cryptattuTB.Name = "cryptattuTB";
            this.cryptattuTB.Size = new System.Drawing.Size(448, 26);
            this.cryptattuTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 346);
            this.Controls.Add(this.cryptattuTB);
            this.Controls.Add(this.salasanaTB);
            this.Controls.Add(this.salasanaBT);
            this.Controls.Add(this.cryptaaBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cryptaaBT;
        private System.Windows.Forms.Button salasanaBT;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.TextBox cryptattuTB;
    }
}

