using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using pasantia_prototype.process.services;
using pasantia_prototype.process.interfaces;

namespace pasantia_prototype.gui
{
    public struct ListViewer
    {
        public IListViewer list;
        public string name;
    }

    public partial class MainDashboard : Form
    {
        private readonly Form             main_windows;
        private readonly IFileDialog      _dialog;
        private readonly List<ListViewer> _list_viewers;
        private readonly IFileHanlder     _fileHandler;
        public MainDashboard(Form main_windows)
        {
            InitializeComponent();
            this._list_viewers   = new List<ListViewer>();
            this._fileHandler    = (IFileHanlder) FileHandlerServ.get_instance();
            this._dialog         = new FileDialogServ();
            this.Text            = $"Bienvenido {Environment.UserName}";
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState     = FormWindowState.Maximized;
            this.main_windows    = main_windows;
            this.toolStripStatusLabel1.Text = "Ready";

            this.tableLayoutPanel1.Controls.OfType<ListView>()
                .ToList()
                .ForEach((item) =>
                {
                    this._list_viewers.Add(new ListViewer()
                    {
                        list = new ListViewerServ(item),
                        name = item.Name
                    });
                });

            this.setFileStackSpecificElement(this._fileHandler.get_prjPaths(), "listView1");
            this.setImgStackSpecificElement(this._fileHandler.get_imgPaths(), "listView3");

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
            this._dialog.open_dialog(false);

            string result = (this._dialog.get_content() as string);

            Console.WriteLine(result);
        }

        private void abrirProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._dialog.set_filter(process.enums.FileTypes.files, "Buscar proyecto");
            this._dialog.open_dialog(false);

            string result = (this._dialog.get_content() as string);

            Console.WriteLine(result);
        }

        private void importarImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._dialog.set_filter(process.enums.FileTypes.images, "Buscar imagenes");
            this._dialog.open_dialog(true);

            Array result = (this._dialog.get_content() as Array);
            this.setImgStackSpecificElement(result, "listView3");
            

        }

        private void setFileStackSpecificElement(Array data, string name)
        {
            this._list_viewers.Where((item) => item.name == name)
                .ToList()
                .ForEach((item) =>
                {
                    item.list.set_listPrj(data, this.contextMenuStrip1);
                });
        }

        private void setImgStackSpecificElement(Array data, string name)
        {
            this._list_viewers.Where((item) => item.name == name)
                .ToList()
                .ForEach((item) =>
                {
                    item.list.set_listImg(data, this.contextMenuStrip1);
                });
        }
    }
}
