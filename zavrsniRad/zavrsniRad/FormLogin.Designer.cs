
namespace zavrsniRad
{
    partial class frmLogin
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPrijava = new System.Windows.Forms.Label();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.txtBoxKorIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxLoz = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(201, 44);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(437, 78);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Turistički vlakić";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrijava
            // 
            this.lblPrijava.AutoSize = true;
            this.lblPrijava.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijava.Location = new System.Drawing.Point(310, 138);
            this.lblPrijava.Name = "lblPrijava";
            this.lblPrijava.Size = new System.Drawing.Size(204, 59);
            this.lblPrijava.TabIndex = 1;
            this.lblPrijava.Text = "Prijavi se";
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorIme.Location = new System.Drawing.Point(240, 224);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(167, 29);
            this.lblKorIme.TabIndex = 2;
            this.lblKorIme.Text = "Korisničko ime:";
            // 
            // txtBoxKorIme
            // 
            this.txtBoxKorIme.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxKorIme.Location = new System.Drawing.Point(245, 256);
            this.txtBoxKorIme.Name = "txtBoxKorIme";
            this.txtBoxKorIme.Size = new System.Drawing.Size(355, 40);
            this.txtBoxKorIme.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(240, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lozinka:";
            // 
            // txtBoxLoz
            // 
            this.txtBoxLoz.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxLoz.Location = new System.Drawing.Point(245, 347);
            this.txtBoxLoz.MaxLength = 15;
            this.txtBoxLoz.Name = "txtBoxLoz";
            this.txtBoxLoz.PasswordChar = '*';
            this.txtBoxLoz.Size = new System.Drawing.Size(355, 40);
            this.txtBoxLoz.TabIndex = 5;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            this.btnPrijava.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrijava.FlatAppearance.BorderSize = 2;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.Location = new System.Drawing.Point(320, 425);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(200, 50);
            this.btnPrijava.TabIndex = 6;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(837, 617);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtBoxLoz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxKorIme);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.lblPrijava);
            this.Controls.Add(this.lblNaslov);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPrijava;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.TextBox txtBoxKorIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxLoz;
        private System.Windows.Forms.Button btnPrijava;
    }
}

