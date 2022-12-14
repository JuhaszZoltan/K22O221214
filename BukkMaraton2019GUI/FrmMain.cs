namespace BukkMaraton2019GUI
{
    public partial class FrmMain : Form
    {

        private static int[] tavok = { 16, 38, 54, 57, 94 };

        public FrmMain()
        {
            InitializeComponent();
            cb.SelectedIndex = 3;
            btn.Click += OnBtnClick;
        }

        private void OnBtnClick(object? sender, EventArgs e)
        {
            lblAVGkmph.Text = $"{tavok[cb.SelectedIndex] / TimeSpan.Parse(tb.Text).TotalHours:0.00}";
            lblAVGmps.Text = $"{tavok[cb.SelectedIndex] * 1000 / TimeSpan.Parse(tb.Text).TotalSeconds:0.00}";
        }
    }
}