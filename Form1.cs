namespace hajoegyszeru_vinklarik1119
{
    public partial class Form1 : Form
    {
        List<Hajo> lista = new List<Hajo>();
        void betoltes()
        {
            FileStream fs = new FileStream("hajo.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                rtbadat.Text = rtbadat.Text + sor + "\n";
                Hajo h = new Hajo(sor);
                lista.Add(h);
            }
            int gyerek = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                lbszabadhely.Text = "Szabad helyek száma: " + lista[i].Szabadhelyek();
                if (lista[i].Neme == "gyerek")
                {
                    gyerek = gyerek + 1;
                }
                lbgyerek.Text = "Gyerek utasok száma: " + gyerek;
            }
            sr.Close();
            fs.Close();
        }
        void mentes()
        {
            if (cbnem.SelectedItem == null)
            {
                MessageBox.Show("Kérlek add meg a nemed!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbnem.Focus();
            }
            else if (txkat.TextLength == 0)
            {
                MessageBox.Show("Kérlek add meg a kategóriát", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txkat.Focus();
            }
            else if (txtervez.TextLength == 0)
            {
                MessageBox.Show("Kérlek add meg a tervezhetõ helyek számát!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtervez.Focus();
            }
            else if (txfoglalt.TextLength == 0)
            {
                MessageBox.Show("Kérlek add meg a foglalt helyek számát!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txfoglalt.Focus();
            }
        }
        public Form1()
        {
            InitializeComponent();
            betoltes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtervez_TextChanged(object sender, EventArgs e)
        {
            if (txtervez.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txtervez.Text);

                }
                catch
                {
                    MessageBox.Show("Csak egész számot adj meg!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtervez.Clear();
                    txtervez.Focus();
                }
            }
        }

        private void txfoglalt_TextChanged(object sender, EventArgs e)
        {
            if (txfoglalt.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txfoglalt.Text);
                }
                catch
                {
                    MessageBox.Show("Csak egész számot adj meg!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txfoglalt.Clear();
                    txfoglalt.Focus();
                }
            }
        }

        private void btment_Click(object sender, EventArgs e)
        {
            mentes();
        }
    }
}
