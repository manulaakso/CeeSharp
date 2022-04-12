namespace Tehtava_20
{
    partial class YllapitoForm
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
            this.etunimiLB = new System.Windows.Forms.Label();
            this.sukunimiLB = new System.Windows.Forms.Label();
            this.idLB = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.oNroTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.puhTB = new System.Windows.Forms.TextBox();
            this.puhLB = new System.Windows.Forms.Label();
            this.onroLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.Tietotaulu = new System.Windows.Forms.DataGridView();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tietotaulu)).BeginInit();
            this.SuspendLayout();
            // 
            // etunimiLB
            // 
            this.etunimiLB.AutoSize = true;
            this.etunimiLB.Location = new System.Drawing.Point(12, 54);
            this.etunimiLB.Name = "etunimiLB";
            this.etunimiLB.Size = new System.Drawing.Size(82, 25);
            this.etunimiLB.TabIndex = 0;
            this.etunimiLB.Text = "Etunimi:";
            // 
            // sukunimiLB
            // 
            this.sukunimiLB.AutoSize = true;
            this.sukunimiLB.Location = new System.Drawing.Point(12, 99);
            this.sukunimiLB.Name = "sukunimiLB";
            this.sukunimiLB.Size = new System.Drawing.Size(99, 25);
            this.sukunimiLB.TabIndex = 1;
            this.sukunimiLB.Text = "Sukunimi:";
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Location = new System.Drawing.Point(12, 9);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(37, 25);
            this.idLB.TabIndex = 2;
            this.idLB.Text = "ID:";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(170, 9);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(185, 30);
            this.idTB.TabIndex = 3;
            // 
            // enimiTB
            // 
            this.enimiTB.Location = new System.Drawing.Point(170, 54);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(185, 30);
            this.enimiTB.TabIndex = 4;
            // 
            // snimiTB
            // 
            this.snimiTB.Location = new System.Drawing.Point(170, 99);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(185, 30);
            this.snimiTB.TabIndex = 5;
            // 
            // oNroTB
            // 
            this.oNroTB.Location = new System.Drawing.Point(629, 99);
            this.oNroTB.Name = "oNroTB";
            this.oNroTB.Size = new System.Drawing.Size(185, 30);
            this.oNroTB.TabIndex = 11;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(629, 54);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(185, 30);
            this.emailTB.TabIndex = 10;
            // 
            // puhTB
            // 
            this.puhTB.Location = new System.Drawing.Point(629, 9);
            this.puhTB.Name = "puhTB";
            this.puhTB.Size = new System.Drawing.Size(185, 30);
            this.puhTB.TabIndex = 9;
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.Location = new System.Drawing.Point(471, 9);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(83, 25);
            this.puhLB.TabIndex = 8;
            this.puhLB.Text = "Puhelin:";
            // 
            // onroLB
            // 
            this.onroLB.AutoSize = true;
            this.onroLB.Location = new System.Drawing.Point(471, 99);
            this.onroLB.Name = "onroLB";
            this.onroLB.Size = new System.Drawing.Size(131, 25);
            this.onroLB.TabIndex = 7;
            this.onroLB.Text = "Opiskelijanro:";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(471, 54);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(116, 25);
            this.emailLB.TabIndex = 6;
            this.emailLB.Text = "Sähköposti:";
            // 
            // Tietotaulu
            // 
            this.Tietotaulu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tietotaulu.Location = new System.Drawing.Point(13, 195);
            this.Tietotaulu.Name = "Tietotaulu";
            this.Tietotaulu.RowHeadersWidth = 62;
            this.Tietotaulu.RowTemplate.Height = 28;
            this.Tietotaulu.Size = new System.Drawing.Size(926, 174);
            this.Tietotaulu.TabIndex = 12;
            this.Tietotaulu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tietotaulu_CellClick);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(13, 150);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(148, 39);
            this.tyhjennaBT.TabIndex = 13;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(256, 150);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(148, 39);
            this.tallennaBT.TabIndex = 14;
            this.tallennaBT.Text = "Tallenna";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(499, 150);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(148, 39);
            this.paivitaBT.TabIndex = 15;
            this.paivitaBT.Text = "Päivitä";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(742, 150);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(148, 39);
            this.poistaBT.TabIndex = 16;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // YllapitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 381);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.Tietotaulu);
            this.Controls.Add(this.oNroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhTB);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.onroLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.idLB);
            this.Controls.Add(this.sukunimiLB);
            this.Controls.Add(this.etunimiLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YllapitoForm";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.YllapitoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tietotaulu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etunimiLB;
        private System.Windows.Forms.Label sukunimiLB;
        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.TextBox oNroTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox puhTB;
        private System.Windows.Forms.Label puhLB;
        private System.Windows.Forms.Label onroLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.DataGridView Tietotaulu;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
    }
}

