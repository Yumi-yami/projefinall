namespace projefinal
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaşla = new System.Windows.Forms.Button();
            this.lblÇIK = new System.Windows.Forms.Button();
            this.lblEHO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaşla
            // 
            this.lblBaşla.BackColor = System.Drawing.Color.Lime;
            this.lblBaşla.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaşla.Location = new System.Drawing.Point(427, 458);
            this.lblBaşla.Name = "lblBaşla";
            this.lblBaşla.Size = new System.Drawing.Size(251, 136);
            this.lblBaşla.TabIndex = 0;
            this.lblBaşla.Text = "Başla";
            this.lblBaşla.UseVisualStyleBackColor = false;
            this.lblBaşla.Click += new System.EventHandler(this.lblBaşla_Click);
            // 
            // lblÇIK
            // 
            this.lblÇIK.BackColor = System.Drawing.Color.Red;
            this.lblÇIK.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÇIK.Location = new System.Drawing.Point(1081, 458);
            this.lblÇIK.Name = "lblÇIK";
            this.lblÇIK.Size = new System.Drawing.Size(251, 136);
            this.lblÇIK.TabIndex = 1;
            this.lblÇIK.Text = "Çık";
            this.lblÇIK.UseVisualStyleBackColor = false;
            this.lblÇIK.Click += new System.EventHandler(this.lblÇIK_Click);
            // 
            // lblEHO
            // 
            this.lblEHO.AutoSize = true;
            this.lblEHO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEHO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEHO.Location = new System.Drawing.Point(409, 228);
            this.lblEHO.Name = "lblEHO";
            this.lblEHO.Size = new System.Drawing.Size(923, 108);
            this.lblEHO.TabIndex = 2;
            this.lblEHO.Text = "Evcil Hayvan Oyunu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1710, 876);
            this.Controls.Add(this.lblEHO);
            this.Controls.Add(this.lblÇIK);
            this.Controls.Add(this.lblBaşla);
            this.Name = "Form1";
            this.Text = "Çık";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblBaşla;
        private System.Windows.Forms.Button lblÇIK;
        private System.Windows.Forms.Label lblEHO;
    }
}

