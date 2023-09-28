using System;
using System.Windows.Forms;
using pasantia_prototype.process.base_class;
using pasantia_prototype.process.interfaces;
using pasantia_prototype.process.services;

namespace pasantia_prototype.gui
{
    public partial class MainDashboard : Form
    {
        private Form main_windows;
        private IFileDialog _dialog;
        public MainDashboard(Form main_windows)
        {
            InitializeComponent();
            this._dialog = new FileDialogServ();

            this.Text            = $"Bienvenido {Environment.UserName}";
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState     = FormWindowState.Maximized;
            this.main_windows    = main_windows;
            this.toolStripStatusLabel1.Text = "Ready";
            this.OnResizeLayout();

        }

        private void OnResizeLayout()
        {
            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.main_windows.Dispose();
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._dialog.set_filter(process.enums.FileTypes.images, "Buscar imagenes");
            this._dialog.open_dialog(true);

            Array result = (this._dialog.get_content() as  Array);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private void abrirProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._dialog.set_filter(process.enums.FileTypes.files, "Buscar proyecto");
            this._dialog.open_dialog(false);

            string result = (this._dialog.get_content() as string);

            Console.WriteLine(result);
        }


    }
}
