namespace Tehtava_16
{
    partial class LaskuriForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minuutitCB = new System.Windows.Forms.ComboBox();
            this.sekunnitCB = new System.Windows.Forms.ComboBox();
            this.aikaLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuutit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekunnit:";
            // 
            // minuutitCB
            // 
            this.minuutitCB.FormattingEnabled = true;
            this.minuutitCB.Location = new System.Drawing.Point(44, 78);
            this.minuutitCB.Name = "minuutitCB";
            this.minuutitCB.Size = new System.Drawing.Size(121, 40);
            this.minuutitCB.TabIndex = 2;
            // 
            // sekunnitCB
            // 
            this.sekunnitCB.FormattingEnabled = true;
            this.sekunnitCB.Location = new System.Drawing.Point(208, 78);
            this.sekunnitCB.Name = "sekunnitCB";
            this.sekunnitCB.Size = new System.Drawing.Size(121, 40);
            this.sekunnitCB.TabIndex = 3;
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aikaLB.Location = new System.Drawing.Point(52, 155);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(284, 108);
            this.aikaLB.TabIndex = 4;
            this.aikaLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(27, 308);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(138, 43);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(198, 308);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(138, 43);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Interval = 1000;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // LaskuriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 436);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.sekunnitCB);
            this.Controls.Add(this.minuutitCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "LaskuriForm";
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.LaskuriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox minuutitCB;
        private System.Windows.Forms.ComboBox sekunnitCB;
        private System.Windows.Forms.Label aikaLB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}

