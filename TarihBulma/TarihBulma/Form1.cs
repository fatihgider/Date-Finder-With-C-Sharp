namespace TarihBulma
{
    public partial class TarihBulma : Form
    {
        private bool PazartesiTiklama = false;
        private bool SaliTiklama = false;
        private bool CarsambaTiklama = false;
        private bool PersembeTiklama = false;
        private bool CumaTiklama = false;
        private bool CumartesiTiklama = false;
        private bool PazarTiklama = false;

        public TarihBulma()
        {
            InitializeComponent();
            cbGunHaftaSecim.Enabled = false;
            calBaslangicTarihi.Enabled = false;
            calBitisTarihi.Enabled = false;
            btnPazartesi.Visible = false;
            btnSali.Visible = false;
            btnCarsamba.Visible = false;
            btnPersembe.Visible = false;
            btnCuma.Visible = false;
            btnCumartesi.Visible = false;
            btnPazar.Visible = false;
    }

        public void cbGunlukHaftalikSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGunHaftaSecim.Enabled = true;
            

            if (cbGunlukHaftalikSecim.SelectedIndex == 0)
            {
                lblGunHaftaSecim.Text = "Kaç Günlük Sayýlacaðýný Seçiniz:";
                cbGunHaftaSecim.Items.Clear();
                lbSonuc.Items.Clear();

                for (int j = 1;j <= 31; j++)
                {
                    cbGunHaftaSecim.Items.Add(j+" Günlük");
                }

                btnPazartesi.Visible = false;
                btnSali.Visible = false;
                btnCarsamba.Visible = false;
                btnPersembe.Visible = false;
                btnCuma.Visible = false;
                btnCumartesi.Visible = false;
                btnPazar.Visible = false;

            }
            else if (cbGunlukHaftalikSecim.SelectedIndex == 1)
            {
                lblGunHaftaSecim.Text = "Kaç Haftalýk Sayýlacaðýný Seçiniz:";
                cbGunHaftaSecim.Items.Clear();
                lbSonuc.Items.Clear();

                btnPazartesi.Visible = true;
                btnSali.Visible = true;
                btnCarsamba.Visible = true;
                btnPersembe.Visible = true;
                btnCuma.Visible = true;
                btnCumartesi.Visible = true;
                btnPazar.Visible = true;

                for (int i = 1; i <= 8; i++)
                {
                    cbGunHaftaSecim.Items.Add(i + " Haftalýk");
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapýnýz!");
            }
        }

        private void cbGunHaftaSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            calBaslangicTarihi.Enabled = true;
            calBitisTarihi.Enabled = true;
        }

        private void calBaslangicTarihi_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = "Seçili Tarih: " + calBaslangicTarihi.SelectionRange.Start.ToShortDateString();
        }

        private void calBitisTarihi_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            if(cbGunlukHaftalikSecim.SelectedIndex == 0)
            {
                string cbSecilenDeger = cbGunHaftaSecim.Text;
                var degerler = cbSecilenDeger.Split(" ");
                var secilenDeger = Convert.ToInt32(degerler[0]);


                DateTime BaslangicTarihi = Convert.ToDateTime(calBaslangicTarihi.SelectionRange.Start.ToShortDateString());
                DateTime BitisTarihi = Convert.ToDateTime(calBitisTarihi.SelectionRange.End.ToShortDateString());

                label2.Text = "Seçili Tarih: " + calBitisTarihi.SelectionRange.End.ToShortDateString();

                var index = 0;
                lbSonuc.Items.Clear();
                for (; BaslangicTarihi <= BitisTarihi; BaslangicTarihi = BaslangicTarihi.AddDays(1))
                {
                    if (index % secilenDeger == 0)
                    {
                        string i = BaslangicTarihi.Date.ToShortDateString();

                        lbSonuc.Items.Add(i);
                    }

                    index++;
                }
            }
            else if(cbGunlukHaftalikSecim.SelectedIndex == 1)
            {
                //HAFTALIK HESAPLAMA

                DateTime BaslangicTarihi = Convert.ToDateTime(calBaslangicTarihi.SelectionRange.Start.ToShortDateString());
                DateTime BitisTarihi = Convert.ToDateTime(calBitisTarihi.SelectionRange.End.ToShortDateString());

                string cbSecilenDeger = cbGunHaftaSecim.Text;
                var degerler = cbSecilenDeger.Split(" ");
                var secilenDeger = Convert.ToInt32(degerler[0]);

                var index = 0;
                lbSonuc.Items.Clear();
                for (; BaslangicTarihi <= BitisTarihi; BaslangicTarihi = BaslangicTarihi.AddDays(1))
                {
                    if (index % secilenDeger == 0)
                    {
                        if(PazartesiTiklama == true)
                        {
                            string i = BaslangicTarihi.Date.ToShortDateString();
                            DayOfWeek Gunler = BaslangicTarihi.DayOfWeek;

                            if (Gunler == DayOfWeek.Monday)
                            {
                                lbSonuc.Items.Add(i + " " + Gunler);
                            }
                        }
                        if(SaliTiklama == true)
                        {
                            string i = BaslangicTarihi.Date.ToShortDateString();
                            DayOfWeek Gunler = BaslangicTarihi.DayOfWeek;

                            if (Gunler == DayOfWeek.Tuesday)
                            {
                                lbSonuc.Items.Add(i + " " + Gunler);
                            }
                        }
                        if (CarsambaTiklama == true)
                        {
                            string i = BaslangicTarihi.Date.ToShortDateString();
                            DayOfWeek Gunler = BaslangicTarihi.DayOfWeek;

                            if (Gunler == DayOfWeek.Wednesday)
                            {
                                lbSonuc.Items.Add(i + " " + Gunler);
                            }
                        }
                        if (PersembeTiklama == true)
                        {
                            string i = BaslangicTarihi.Date.ToShortDateString();
                            DayOfWeek Gunler = BaslangicTarihi.DayOfWeek;

                            if (Gunler == DayOfWeek.Thursday)
                            {
                                lbSonuc.Items.Add(i + " " + Gunler);
                            }
                        }
                        if (CumaTiklama == true)
                        {
                            string i = BaslangicTarihi.Date.ToShortDateString();
                            DayOfWeek Gunler = BaslangicTarihi.DayOfWeek;

                            if (Gunler == DayOfWeek.Friday)
                            {
                                lbSonuc.Items.Add(i + " " + Gunler);
                            }
                        }
                        if (CumartesiTiklama == true)
                        {
                            string i = BaslangicTarihi.Date.ToShortDateString();
                            DayOfWeek Gunler = BaslangicTarihi.DayOfWeek;

                            if (Gunler == DayOfWeek.Saturday)
                            {
                                lbSonuc.Items.Add(i + " " + Gunler);
                            }
                        }
                        if (PazarTiklama == true)
                        {
                            string i = BaslangicTarihi.Date.ToShortDateString();
                            DayOfWeek Gunler = BaslangicTarihi.DayOfWeek;

                            if (Gunler == DayOfWeek.Sunday)
                            {
                                lbSonuc.Items.Add(i + " " + Gunler);
                            }
                        }
                    }

                    index++;
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapýlmadý");
            }
        }

        private void btnPazartesi_Click(object sender, EventArgs e)
        {
            btnPazartesi.BackColor = Color.Red;
            PazartesiTiklama = true;
        }

        private void btnSali_Click(object sender, EventArgs e)
        {
            btnSali.BackColor = Color.Red;
            SaliTiklama=true;
        }

        private void btnCarsamba_Click(object sender, EventArgs e)
        {
            btnCarsamba.BackColor = Color.Red;
            CarsambaTiklama= true;
        }

        private void btnPersembe_Click(object sender, EventArgs e)
        {
            btnPersembe.BackColor = Color.Red;
            PersembeTiklama = true;
        }

        private void btnCuma_Click(object sender, EventArgs e)
        {
            btnCuma.BackColor = Color.Red;
            CumaTiklama = true;
        }

        private void btnCumartesi_Click(object sender, EventArgs e)
        {
            btnCumartesi.BackColor = Color.Red;
            CumartesiTiklama = true;
        }

        private void btnPazar_Click(object sender, EventArgs e)
        {
            btnPazar.BackColor = Color.Red;
            PazarTiklama = true;
        }
    }
}