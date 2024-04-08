namespace FinalEda
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void create_acc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register Register = new Register();
            Register.ShowDialog();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_In Log_In = new Log_In();
            Log_In.ShowDialog();
        }
    }
}