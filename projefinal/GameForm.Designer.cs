namespace projefinal
{
    partial class GameForm
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
            this.pbTilki = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbleğlence = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnyemek = new System.Windows.Forms.Button();
            this.btnoyun = new System.Windows.Forms.Button();
            this.Btnuyku = new System.Windows.Forms.Button();
            this.progressBarYemek = new System.Windows.Forms.ProgressBar();
            this.prgEglence = new System.Windows.Forms.ProgressBar();
            this.barUyku = new System.Windows.Forms.ProgressBar();
            this.tmrDurumAzalma = new System.Windows.Forms.Timer(this.components);
            this.pnlGece = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrUyku = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTilki)).BeginInit();
            this.pnlGece.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTilki
            // 
            this.pbTilki.Location = new System.Drawing.Point(771, 199);
            this.pbTilki.Name = "pbTilki";
            this.pbTilki.Size = new System.Drawing.Size(753, 560);
            this.pbTilki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTilki.TabIndex = 0;
            this.pbTilki.TabStop = false;
            this.pbTilki.Click += new System.EventHandler(this.pbTilki_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENERJİ";
            // 
            // Lbleğlence
            // 
            this.Lbleğlence.AutoSize = true;
            this.Lbleğlence.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbleğlence.Location = new System.Drawing.Point(80, 402);
            this.Lbleğlence.Name = "Lbleğlence";
            this.Lbleğlence.Size = new System.Drawing.Size(214, 77);
            this.Lbleğlence.TabIndex = 2;
            this.Lbleğlence.Text = "EĞLENCE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 77);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOKLUK";
            // 
            // btnyemek
            // 
            this.btnyemek.Location = new System.Drawing.Point(93, 279);
            this.btnyemek.Name = "btnyemek";
            this.btnyemek.Size = new System.Drawing.Size(82, 54);
            this.btnyemek.TabIndex = 4;
            this.btnyemek.Text = "Yemek";
            this.btnyemek.UseVisualStyleBackColor = true;
            this.btnyemek.Click += new System.EventHandler(this.btnyemek_Click);
            // 
            // btnoyun
            // 
            this.btnoyun.Location = new System.Drawing.Point(93, 482);
            this.btnoyun.Name = "btnoyun";
            this.btnoyun.Size = new System.Drawing.Size(82, 54);
            this.btnoyun.TabIndex = 5;
            this.btnoyun.Text = "Oyun";
            this.btnoyun.UseVisualStyleBackColor = true;
            this.btnoyun.Click += new System.EventHandler(this.btnoyun_Click);
            // 
            // Btnuyku
            // 
            this.Btnuyku.Location = new System.Drawing.Point(93, 696);
            this.Btnuyku.Name = "Btnuyku";
            this.Btnuyku.Size = new System.Drawing.Size(82, 54);
            this.Btnuyku.TabIndex = 6;
            this.Btnuyku.Text = "Uyku";
            this.Btnuyku.UseVisualStyleBackColor = true;
            this.Btnuyku.Click += new System.EventHandler(this.Btnuyku_Click);
            // 
            // progressBarYemek
            // 
            this.progressBarYemek.Location = new System.Drawing.Point(213, 279);
            this.progressBarYemek.Name = "progressBarYemek";
            this.progressBarYemek.Size = new System.Drawing.Size(412, 54);
            this.progressBarYemek.TabIndex = 7;
            // 
            // prgEglence
            // 
            this.prgEglence.Location = new System.Drawing.Point(213, 482);
            this.prgEglence.Name = "prgEglence";
            this.prgEglence.Size = new System.Drawing.Size(412, 54);
            this.prgEglence.TabIndex = 8;
            // 
            // barUyku
            // 
            this.barUyku.Location = new System.Drawing.Point(213, 705);
            this.barUyku.Name = "barUyku";
            this.barUyku.Size = new System.Drawing.Size(412, 54);
            this.barUyku.TabIndex = 9;
            // 
            // tmrDurumAzalma
            // 
            this.tmrDurumAzalma.Interval = 5000;
            this.tmrDurumAzalma.Tick += new System.EventHandler(this.tmrDurumAzalma_Tick);
            // 
            // pnlGece
            // 
            this.pnlGece.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlGece.Controls.Add(this.button1);
            this.pnlGece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGece.Location = new System.Drawing.Point(0, 0);
            this.pnlGece.Name = "pnlGece";
            this.pnlGece.Size = new System.Drawing.Size(1639, 929);
            this.pnlGece.TabIndex = 10;
            this.pnlGece.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1379, 842);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Çık";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tmrUyku
            // 
            this.tmrUyku.Interval = 2000;
            this.tmrUyku.Tick += new System.EventHandler(this.tmrUyku_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 929);
            this.Controls.Add(this.barUyku);
            this.Controls.Add(this.prgEglence);
            this.Controls.Add(this.progressBarYemek);
            this.Controls.Add(this.Btnuyku);
            this.Controls.Add(this.btnoyun);
            this.Controls.Add(this.btnyemek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbleğlence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTilki);
            this.Controls.Add(this.pnlGece);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbTilki)).EndInit();
            this.pnlGece.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTilki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbleğlence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnyemek;
        private System.Windows.Forms.Button btnoyun;
        private System.Windows.Forms.Button Btnuyku;
        private System.Windows.Forms.ProgressBar progressBarYemek;
        private System.Windows.Forms.ProgressBar prgEglence;
        private System.Windows.Forms.ProgressBar barUyku;
        private System.Windows.Forms.Timer tmrDurumAzalma;
        private System.Windows.Forms.Panel pnlGece;
        private System.Windows.Forms.Timer tmrUyku;
        private System.Windows.Forms.Button button1;
    }
}