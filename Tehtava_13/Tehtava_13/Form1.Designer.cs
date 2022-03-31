namespace Tehtava_13
{
    partial class SuosikitForm
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
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.TarkastaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna nimesi, niin tarkastan onko se 50 suosituimman joukossa:";
            // 
            // NimiTB
            // 
            this.NimiTB.Location = new System.Drawing.Point(595, 41);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(155, 30);
            this.NimiTB.TabIndex = 1;
            // 
            // TarkastaBT
            // 
            this.TarkastaBT.Location = new System.Drawing.Point(595, 96);
            this.TarkastaBT.Name = "TarkastaBT";
            this.TarkastaBT.Size = new System.Drawing.Size(155, 34);
            this.TarkastaBT.TabIndex = 2;
            this.TarkastaBT.Text = "Tarkasta";
            this.TarkastaBT.UseVisualStyleBackColor = true;
            this.TarkastaBT.Click += new System.EventHandler(this.TarkastaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(34, 175);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(84, 25);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // SuosikitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 303);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.TarkastaBT);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SuosikitForm";
            this.Text = "Onko nimesi suosituimpien joukossa?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NimiTB;
        private System.Windows.Forms.Button TarkastaBT;
        private System.Windows.Forms.Label VastausLB;
    }
}

