
namespace zavrsniRad
{
    partial class FormProdaja
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
            this.lblProdajaKar = new System.Windows.Forms.Label();
            this.btnOdrasli = new System.Windows.Forms.Button();
            this.lblOdrasli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNaslov2
            // 
            this.lblNaslov2.AutoSize = true;
            this.lblNaslov2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov2.Location = new System.Drawing.Point(231, 9);
            this.lblNaslov2.Name = "lblNaslov2";
            this.lblNaslov2.Size = new System.Drawing.Size(437, 78);
            this.lblNaslov2.TabIndex = 1;
            this.lblNaslov2.Text = "Turistički vlakić";
            this.lblNaslov2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProdajaKar
            // 
            this.lblProdajaKar.AutoSize = true;
            this.lblProdajaKar.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdajaKar.Location = new System.Drawing.Point(292, 87);
            this.lblProdajaKar.Name = "lblProdajaKar";
            this.lblProdajaKar.Size = new System.Drawing.Size(317, 59);
            this.lblProdajaKar.TabIndex = 2;
            this.lblProdajaKar.Text = "Prodaja karata";
            // 
            // btnOdrasli
            // 
            this.btnOdrasli.BackgroundImage = global::zavrsniRad.Properties.Resources.Untitled__1_;
            this.btnOdrasli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOdrasli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdrasli.Location = new System.Drawing.Point(65, 189);
            this.btnOdrasli.Name = "btnOdrasli";
            this.btnOdrasli.Size = new System.Drawing.Size(166, 191);
            this.btnOdrasli.TabIndex = 3;
            this.btnOdrasli.UseVisualStyleBackColor = true;
            // 
            // lblOdrasli
            // 
            this.lblOdrasli.AutoSize = true;
            this.lblOdrasli.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdrasli.Location = new System.Drawing.Point(91, 147);
            this.lblOdrasli.Name = "lblOdrasli";
            this.lblOdrasli.Size = new System.Drawing.Size(111, 39);
            this.lblOdrasli.TabIndex = 4;
            this.lblOdrasli.Text = "Odrasli";
            // 
            // FormProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(900, 697);
            this.Controls.Add(this.lblOdrasli);
            this.Controls.Add(this.btnOdrasli);
            this.Controls.Add(this.lblProdajaKar);
            this.Controls.Add(this.lblNaslov2);
            this.Name = "FormProdaja";
            this.Text = "Prodaja karata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov2;
        private System.Windows.Forms.Label lblProdajaKar;
        private System.Windows.Forms.Button btnOdrasli;
        private System.Windows.Forms.Label lblOdrasli;
    }
}