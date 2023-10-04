using pasantia_prototype.process.services;
using pasantia_prototype.gui;
using System.Threading;
using System.Windows.Forms;
using pasantia_prototype.process.interfaces;

namespace pasantia_prototype
{
    public partial class OpenDialog : Form
    {
        private static System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();
        private object[] _initComponents;
        private int _components;

        public OpenDialog()
        {
            InitializeComponent();
            this._components = 0;
            this._initComponents = new object[]
            {
                FileHandlerServ.get_instance(),
            };

            this.label2.Text = null;
        }

        
        private void OpenDialog_Shown(object sender, System.EventArgs e)
        {
            this.progressBar1.Maximum   = 100;
            this.progressBar1.Minimum   = 0;
            this.progressBar1.Value     = 0;

            Timer.Interval = 25;
            Timer.Tick += new System.EventHandler(Timer_Tick);
            Timer.Start();
        }
        
        private void Timer_Tick(object sender, System.EventArgs e)
        {
            int VALUE   = this.progressBar1.Value;
            string TEXT = $"Cargando sistemas y preparando lanzamiento, espera... {VALUE}%";

            if (this.progressBar1.Value < 100)
            {
                this.label2.Text = TEXT.ToString();

                if (this._initComponents.Length > this.progressBar1.Value)
                {
                    if (this._components == 0)
                    {
                        ((IFileHanlder)this._initComponents[this._components]).verify_dirs();
                        ((IFileHanlder)this._initComponents[this._components]).verify_files();
                    }

                    this._components += 1;
                }

                this.progressBar1.Value += 1;

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
