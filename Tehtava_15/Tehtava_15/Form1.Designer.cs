namespace Tehtava_15
{
    partial class SekuntikelloForm
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
            this.TimeLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLB.Location = new System.Drawing.Point(28, 49);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(603, 108);
            this.TimeLB.TabIndex = 0;
            this.TimeLB.Text = "00:00:00.000";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(26, 210);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(141, 50);
            this.StartBT.TabIndex = 1;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(258, 210);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(141, 50);
            this.StopBT.TabIndex = 2;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.Location = new System.Drawing.Point(490, 210);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(141, 50);
            this.ResetBT.TabIndex = 3;
            this.ResetBT.Text = "Reset";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SekuntikelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 300);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimeLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SekuntikelloForm";
            this.Text = "Sekuntikello";
            this.Load += new System.EventHandler(this.SekuntikelloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Button ResetBT;
        private System.Windows.Forms.Timer timer1;
    }
}

