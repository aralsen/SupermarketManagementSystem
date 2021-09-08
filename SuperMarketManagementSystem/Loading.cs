using System;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            MyProgress.Value = startpoint;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                LoginForm log = new LoginForm();
                this.Hide();
                log.Show();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
