namespace Tehtava_8
{
    partial class RoomalaisetFM
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
            this.label2 = new System.Windows.Forms.Label();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.MuutaTB = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna numero väliltä 1-3999, niin muutan sen roomalaiseksi:";
            // 
            // TekstiTB
            // 
            this.TekstiTB.Location = new System.Drawing.Point(665, 131);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(108, 35);
            this.TekstiTB.TabIndex = 2;
            // 
            // MuutaTB
            // 
            this.MuutaTB.Location = new System.Drawing.Point(793, 126);
            this.MuutaTB.Name = "MuutaTB";
            this.MuutaTB.Size = new System.Drawing.Size(105, 46);
            this.MuutaTB.TabIndex = 3;
            this.MuutaTB.Text = "Muuta!";
            this.MuutaTB.UseVisualStyleBackColor = true;
            this.MuutaTB.Click += new System.EventHandler(this.MuutaTB_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(381, 204);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(165, 91);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "XXX";
            this.VastausLB.Visible = false;
            // 
            // RoomalaisetFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 323);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuutaTB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RoomalaisetFM";
            this.Text = "Numeroiden muutos latinalaisesta roomalaiseksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Button MuutaTB;
        private System.Windows.Forms.Label VastausLB;
    }
}

