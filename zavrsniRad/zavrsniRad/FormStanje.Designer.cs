
namespace zavrsniRad
{
    partial class FormStanje
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
            this.lblNaslov2 = new System.Windows.Forms.Label();
            this.lblStanjeKase = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov2
            // 
            this.lblNaslov2.AutoSize = true;
            this.lblNaslov2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov2.Location = new System.Drawing.Point(155, 18);
            this.lblNaslov2.Name = "lblNaslov2";
            this.lblNaslov2.Size = new System.Drawing.Size(437, 78);
            this.lblNaslov2.TabIndex = 2;
            this.lblNaslov2.Text = "Turistički vlakić";
            this.lblNaslov2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStanjeKase
            // 
            this.lblStanjeKase.AutoSize = true;
            this.lblStanjeKase.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanjeKase.Location = new System.Drawing.Point(243, 96);
            this.lblStanjeKase.Name = "lblStanjeKase";
            this.lblStanjeKase.Size = new System.Drawing.Size(251, 59);
            this.lblStanjeKase.TabIndex = 3;
            this.lblStanjeKase.Text = "Stanje kase";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 370);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            this.btnZatvori.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnZatvori.FlatAppearance.BorderSize = 2;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(489, 512);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(200, 50);
            this.btnZatvori.TabIndex = 20;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // FormStanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(715, 594);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblStanjeKase);
            this.Controls.Add(this.lblNaslov2);
            this.Name = "FormStanje";
            this.Text = "Stanje kase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov2;
        private System.Windows.Forms.Label lblStanjeKase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZatvori;
    }
}