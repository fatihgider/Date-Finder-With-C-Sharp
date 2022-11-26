namespace TarihBulma
{
    partial class TarihBulma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbGunlukHaftalikSecim = new System.Windows.Forms.ComboBox();
            this.lblGunlukHaftalikSecim = new System.Windows.Forms.Label();
            this.lblGunHaftaSecim = new System.Windows.Forms.Label();
            this.cbGunHaftaSecim = new System.Windows.Forms.ComboBox();
            this.calBaslangicTarihi = new System.Windows.Forms.MonthCalendar();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.calBitisTarihi = new System.Windows.Forms.MonthCalendar();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPazartesi = new System.Windows.Forms.Button();
            this.btnSali = new System.Windows.Forms.Button();
            this.btnCarsamba = new System.Windows.Forms.Button();
            this.btnPersembe = new System.Windows.Forms.Button();
            this.btnCuma = new System.Windows.Forms.Button();
            this.btnCumartesi = new System.Windows.Forms.Button();
            this.btnPazar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbGunlukHaftalikSecim
            // 
            this.cbGunlukHaftalikSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGunlukHaftalikSecim.FormattingEnabled = true;
            this.cbGunlukHaftalikSecim.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık"});
            this.cbGunlukHaftalikSecim.Location = new System.Drawing.Point(12, 27);
            this.cbGunlukHaftalikSecim.Name = "cbGunlukHaftalikSecim";
            this.cbGunlukHaftalikSecim.Size = new System.Drawing.Size(264, 23);
            this.cbGunlukHaftalikSecim.TabIndex = 0;
            this.cbGunlukHaftalikSecim.SelectedIndexChanged += new System.EventHandler(this.cbGunlukHaftalikSecim_SelectedIndexChanged);
            // 
            // lblGunlukHaftalikSecim
            // 
            this.lblGunlukHaftalikSecim.AutoSize = true;
            this.lblGunlukHaftalikSecim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGunlukHaftalikSecim.Location = new System.Drawing.Point(12, 9);
            this.lblGunlukHaftalikSecim.Name = "lblGunlukHaftalikSecim";
            this.lblGunlukHaftalikSecim.Size = new System.Drawing.Size(204, 15);
            this.lblGunlukHaftalikSecim.TabIndex = 1;
            this.lblGunlukHaftalikSecim.Text = "Günlük veya Haftalık Seçim Yapınız:";
            // 
            // lblGunHaftaSecim
            // 
            this.lblGunHaftaSecim.AutoSize = true;
            this.lblGunHaftaSecim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGunHaftaSecim.Location = new System.Drawing.Point(12, 60);
            this.lblGunHaftaSecim.Name = "lblGunHaftaSecim";
            this.lblGunHaftaSecim.Size = new System.Drawing.Size(0, 15);
            this.lblGunHaftaSecim.TabIndex = 2;
            // 
            // cbGunHaftaSecim
            // 
            this.cbGunHaftaSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGunHaftaSecim.FormattingEnabled = true;
            this.cbGunHaftaSecim.Location = new System.Drawing.Point(12, 78);
            this.cbGunHaftaSecim.Name = "cbGunHaftaSecim";
            this.cbGunHaftaSecim.Size = new System.Drawing.Size(264, 23);
            this.cbGunHaftaSecim.TabIndex = 3;
            this.cbGunHaftaSecim.SelectedIndexChanged += new System.EventHandler(this.cbGunHaftaSecim_SelectedIndexChanged);
            // 
            // calBaslangicTarihi
            // 
            this.calBaslangicTarihi.Location = new System.Drawing.Point(288, 27);
            this.calBaslangicTarihi.MaxSelectionCount = 1;
            this.calBaslangicTarihi.Name = "calBaslangicTarihi";
            this.calBaslangicTarihi.TabIndex = 4;
            this.calBaslangicTarihi.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calBaslangicTarihi_DateChanged);
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(288, 9);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(136, 15);
            this.lblBaslangicTarihi.TabIndex = 5;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi Seçiniz:";
            // 
            // calBitisTarihi
            // 
            this.calBitisTarihi.Location = new System.Drawing.Point(288, 259);
            this.calBitisTarihi.MaxSelectionCount = 1;
            this.calBitisTarihi.Name = "calBitisTarihi";
            this.calBitisTarihi.TabIndex = 6;
            this.calBitisTarihi.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calBitisTarihi_DateChanged);
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBitisTarihi.Location = new System.Drawing.Point(288, 235);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(109, 15);
            this.lblBitisTarihi.TabIndex = 7;
            this.lblBitisTarihi.Text = "Bitiş Tarihi Seçiniz:";
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 15;
            this.lbSonuc.Location = new System.Drawing.Point(554, 27);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(136, 394);
            this.lbSonuc.TabIndex = 8;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSonuc.Location = new System.Drawing.Point(554, 9);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(95, 15);
            this.lblSonuc.TabIndex = 9;
            this.lblSonuc.Text = "Seçilen Tarihler:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 11;
            // 
            // btnPazartesi
            // 
            this.btnPazartesi.Location = new System.Drawing.Point(21, 107);
            this.btnPazartesi.Name = "btnPazartesi";
            this.btnPazartesi.Size = new System.Drawing.Size(75, 23);
            this.btnPazartesi.TabIndex = 12;
            this.btnPazartesi.Text = "Pazartesi";
            this.btnPazartesi.UseVisualStyleBackColor = true;
            this.btnPazartesi.Click += new System.EventHandler(this.btnPazartesi_Click);
            // 
            // btnSali
            // 
            this.btnSali.Location = new System.Drawing.Point(102, 107);
            this.btnSali.Name = "btnSali";
            this.btnSali.Size = new System.Drawing.Size(75, 23);
            this.btnSali.TabIndex = 13;
            this.btnSali.Text = "Salı";
            this.btnSali.UseVisualStyleBackColor = true;
            this.btnSali.Click += new System.EventHandler(this.btnSali_Click);
            // 
            // btnCarsamba
            // 
            this.btnCarsamba.Location = new System.Drawing.Point(183, 107);
            this.btnCarsamba.Name = "btnCarsamba";
            this.btnCarsamba.Size = new System.Drawing.Size(75, 23);
            this.btnCarsamba.TabIndex = 14;
            this.btnCarsamba.Text = "Çarşamba";
            this.btnCarsamba.UseVisualStyleBackColor = true;
            this.btnCarsamba.Click += new System.EventHandler(this.btnCarsamba_Click);
            // 
            // btnPersembe
            // 
            this.btnPersembe.Location = new System.Drawing.Point(21, 136);
            this.btnPersembe.Name = "btnPersembe";
            this.btnPersembe.Size = new System.Drawing.Size(75, 23);
            this.btnPersembe.TabIndex = 15;
            this.btnPersembe.Text = "Perşembe";
            this.btnPersembe.UseVisualStyleBackColor = true;
            this.btnPersembe.Click += new System.EventHandler(this.btnPersembe_Click);
            // 
            // btnCuma
            // 
            this.btnCuma.Location = new System.Drawing.Point(102, 136);
            this.btnCuma.Name = "btnCuma";
            this.btnCuma.Size = new System.Drawing.Size(75, 23);
            this.btnCuma.TabIndex = 16;
            this.btnCuma.Text = "Cuma";
            this.btnCuma.UseVisualStyleBackColor = true;
            this.btnCuma.Click += new System.EventHandler(this.btnCuma_Click);
            // 
            // btnCumartesi
            // 
            this.btnCumartesi.Location = new System.Drawing.Point(183, 136);
            this.btnCumartesi.Name = "btnCumartesi";
            this.btnCumartesi.Size = new System.Drawing.Size(75, 23);
            this.btnCumartesi.TabIndex = 17;
            this.btnCumartesi.Text = "Cumartesi";
            this.btnCumartesi.UseVisualStyleBackColor = true;
            this.btnCumartesi.Click += new System.EventHandler(this.btnCumartesi_Click);
            // 
            // btnPazar
            // 
            this.btnPazar.Location = new System.Drawing.Point(21, 166);
            this.btnPazar.Name = "btnPazar";
            this.btnPazar.Size = new System.Drawing.Size(75, 23);
            this.btnPazar.TabIndex = 18;
            this.btnPazar.Text = "Pazar";
            this.btnPazar.UseVisualStyleBackColor = true;
            this.btnPazar.Click += new System.EventHandler(this.btnPazar_Click);
            // 
            // TarihBulma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 448);
            this.Controls.Add(this.btnPazar);
            this.Controls.Add(this.btnCumartesi);
            this.Controls.Add(this.btnCuma);
            this.Controls.Add(this.btnPersembe);
            this.Controls.Add(this.btnCarsamba);
            this.Controls.Add(this.btnSali);
            this.Controls.Add(this.btnPazartesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.calBitisTarihi);
            this.Controls.Add(this.lblBaslangicTarihi);
            this.Controls.Add(this.calBaslangicTarihi);
            this.Controls.Add(this.cbGunHaftaSecim);
            this.Controls.Add(this.lblGunHaftaSecim);
            this.Controls.Add(this.lblGunlukHaftalikSecim);
            this.Controls.Add(this.cbGunlukHaftalikSecim);
            this.Name = "TarihBulma";
            this.Text = "Tarih Bulma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbGunlukHaftalikSecim;
        private Label lblGunlukHaftalikSecim;
        private Label lblGunHaftaSecim;
        private ComboBox cbGunHaftaSecim;
        private MonthCalendar calBaslangicTarihi;
        private Label lblBaslangicTarihi;
        private MonthCalendar calBitisTarihi;
        private Label lblBitisTarihi;
        private ListBox lbSonuc;
        private Label lblSonuc;
        private Label label1;
        private Label label2;
        private Button btnPazartesi;
        private Button btnSali;
        private Button btnCarsamba;
        private Button btnPersembe;
        private Button btnCuma;
        private Button btnCumartesi;
        private Button btnPazar;
    }
}