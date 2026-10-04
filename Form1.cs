namespace evtapsirigi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXirdala_Click(object sender, EventArgs e)
        {
            // M?bl?? bo?dursa
            if (string.IsNullOrWhiteSpace(txtMebleg.Text))
            {
                errorProvider1.SetError(txtMebleg, "M?bl?? daxil edin");
                return;
            }

            // M?bl??in düzgün daxil edilm?sini yoxlay?r?q
            int mebleg;

            if (!int.TryParse(txtMebleg.Text, out mebleg))
            {
                errorProvider1.SetError(txtMebleg, "Düzgün m?bl?? daxil edin");
                return;
            }

            // M?nfi v? ya s?f?r m?bl??
            if (mebleg <= 0)
            {
                errorProvider1.SetError(txtMebleg, "");
                MessageBox.Show(
                    "M?nfi v? ya s?f?r m?bl?? x?rdalanmaz",
                    "Diqq?t",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Düzgün m?bl?? daxil edilib
            errorProvider1.SetError(txtMebleg, "");

            // ?vv?lki n?tic?l?ri gizl?dirik
            pb500.Visible = false;
            pb200.Visible = false;
            pb100.Visible = false;
            pb50.Visible = false;
            pb20.Visible = false;
            pb10.Visible = false;
            pb5.Visible = false;
            pb1.Visible = false;

            lbl500.Visible = false;
            lbl200.Visible = false;
            lbl100.Visible = false;
            lbl50.Visible = false;
            lbl20.Visible = false;
            lbl10.Visible = false;
            lbl5.Visible = false;
            lbl1.Visible = false;

            // ?n böyük ?skinasdan ba?lay?r?q
            int qaliq = mebleg;

            int say500 = qaliq / 500;
            qaliq %= 500;

            int say200 = qaliq / 200;
            qaliq %= 200;

            int say100 = qaliq / 100;
            qaliq %= 100;

            int say50 = qaliq / 50;
            qaliq %= 50;

            int say20 = qaliq / 20;
            qaliq %= 20;

            int say10 = qaliq / 10;
            qaliq %= 10;

            int say5 = qaliq / 5;
            qaliq %= 5;

            int say1 = qaliq;

            // 500 manat
            if (say500 > 0)
            {
                pb500.Visible = true;
                lbl500.Visible = true;
                lbl500.Text = say500.ToString();
            }

            // 200 manat
            if (say200 > 0)
            {
                pb200.Visible = true;
                lbl200.Visible = true;
                lbl200.Text = say200.ToString();
            }

            // 100 manat
            if (say100 > 0)
            {
                pb100.Visible = true;
                lbl100.Visible = true;
                lbl100.Text = say100.ToString();
            }

            // 50 manat
            if (say50 > 0)
            {
                pb50.Visible = true;
                lbl50.Visible = true;
                lbl50.Text = say50.ToString();
            }

            // 20 manat
            if (say20 > 0)
            {
                pb20.Visible = true;
                lbl20.Visible = true;
                lbl20.Text = say20.ToString();
            }

            // 10 manat
            if (say10 > 0)
            {
                pb10.Visible = true;
                lbl10.Visible = true;
                lbl10.Text = say10.ToString();
            }

            // 5 manat
            if (say5 > 0)
            {
                pb5.Visible = true;
                lbl5.Visible = true;
                lbl5.Text = say5.ToString();
            }

            // 1 manat
            if (say1 > 0)
            {
                pb1.Visible = true;
                lbl1.Visible = true;
                lbl1.Text = say1.ToString();
            }
        }
    }
}
