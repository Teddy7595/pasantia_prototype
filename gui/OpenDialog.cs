using pasantia_prototype.gui;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasantia_prototype
{
    public partial class OpenDialog : Form
    {
        static System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();
        public OpenDialog()
        {
            InitializeComponent();
            this.label2.Text = null;
        }

        
        private void OpenDialog_Shown(object sender, System.EventArgs e)
        {
            this.progressBar1.Maximum   = 100;
            this.progressBar1.Minimum   = 0;
            this.progressBar1.Value     = 0;

            Timer.Interval = 100;
            Timer.Tick += new System.EventHandler(Timer_Tick);
            Timer.Start();
        }
        
        private void Timer_Tick(object sender, System.EventArgs e)
        {
            int VALUE   = this.progressBar1.Value;
            string TEXT = $"Cargando sistemas y preparando lanzamiento, espera... {VALUE}%";

            if (this.progressBar1.Value < 100)
            {
                this.progressBar1.Value += 5;
                this.label2.Text = TEXT.ToString();
            }
            else
            {
                this.label2.Text = $"Inicializando escritorio, espera... {100}%";
                Timer.Stop();
                Thread.Sleep(1000);
                MainDashboard DASHBOARD = new MainDashboard(this);
                DASHBOARD.Show();
                Timer.Dispose();
                this.Hide();
            }
        }

    }
}
