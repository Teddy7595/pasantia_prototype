namespace pasantia_prototype.gui
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarImagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProyectoConImagenCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProyectoConArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarseAlRepositorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subirProyectosNuevosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.databaseToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.abrirProyectoToolStripMenuItem,
            this.importarImagenesToolStripMenuItem});
            resources.ApplyResources(this.filesToolStripMenuItem, "filesToolStripMenuItem");
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            resources.ApplyResources(this.abrirImagenToolStripMenuItem, "abrirImagenToolStripMenuItem");
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click);
            // 
            // abrirProyectoToolStripMenuItem
            // 
            this.abrirProyectoToolStripMenuItem.Name = "abrirProyectoToolStripMenuItem";
            resources.ApplyResources(this.abrirProyectoToolStripMenuItem, "abrirProyectoToolStripMenuItem");
            this.abrirProyectoToolStripMenuItem.Click += new System.EventHandler(this.abrirProyectoToolStripMenuItem_Click);
            // 
            // importarImagenesToolStripMenuItem
            // 
            this.importarImagenesToolStripMenuItem.Name = "importarImagenesToolStripMenuItem";
            resources.ApplyResources(this.importarImagenesToolStripMenuItem, "importarImagenesToolStripMenuItem");
            this.importarImagenesToolStripMenuItem.Click += new System.EventHandler(this.importarImagenesToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Checked = true;
            this.imageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarCamaraToolStripMenuItem,
            this.crearProyectoConImagenCamaraToolStripMenuItem,
            this.crearProyectoConArchivoToolStripMenuItem});
            resources.ApplyResources(this.imageToolStripMenuItem, "imageToolStripMenuItem");
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // configurarCamaraToolStripMenuItem
            // 
            this.configurarCamaraToolStripMenuItem.Name = "configurarCamaraToolStripMenuItem";
            resources.ApplyResources(this.configurarCamaraToolStripMenuItem, "configurarCamaraToolStripMenuItem");
            // 
            // crearProyectoConImagenCamaraToolStripMenuItem
            // 
            this.crearProyectoConImagenCamaraToolStripMenuItem.Name = "crearProyectoConImagenCamaraToolStripMenuItem";
            resources.ApplyResources(this.crearProyectoConImagenCamaraToolStripMenuItem, "crearProyectoConImagenCamaraToolStripMenuItem");
            // 
            // crearProyectoConArchivoToolStripMenuItem
            // 
            this.crearProyectoConArchivoToolStripMenuItem.Name = "crearProyectoConArchivoToolStripMenuItem";
            resources.ApplyResources(this.crearProyectoConArchivoToolStripMenuItem, "crearProyectoConArchivoToolStripMenuItem");
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarseAlRepositorioToolStripMenuItem,
            this.subirProyectosNuevosToolStripMenuItem,
            this.actualizarLocalToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            resources.ApplyResources(this.databaseToolStripMenuItem, "databaseToolStripMenuItem");
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            // 
            // conectarseAlRepositorioToolStripMenuItem
            // 
            this.conectarseAlRepositorioToolStripMenuItem.Name = "conectarseAlRepositorioToolStripMenuItem";
            resources.ApplyResources(this.conectarseAlRepositorioToolStripMenuItem, "conectarseAlRepositorioToolStripMenuItem");
            // 
            // subirProyectosNuevosToolStripMenuItem
            // 
            this.subirProyectosNuevosToolStripMenuItem.Name = "subirProyectosNuevosToolStripMenuItem";
            resources.ApplyResources(this.subirProyectosNuevosToolStripMenuItem, "subirProyectosNuevosToolStripMenuItem");
            // 
            // actualizarLocalToolStripMenuItem
            // 
            this.actualizarLocalToolStripMenuItem.Name = "actualizarLocalToolStripMenuItem";
            resources.ApplyResources(this.actualizarLocalToolStripMenuItem, "actualizarLocalToolStripMenuItem");
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            resources.ApplyResources(this.eliminarToolStripMenuItem, "eliminarToolStripMenuItem");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.listView2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView3, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.listView2, "listView2");
            this.listView2.HideSelection = false;
            this.listView2.Name = "listView2";
            this.tableLayoutPanel1.SetRowSpan(this.listView2, 3);
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView3
            // 
            this.listView3.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView3.CheckBoxes = true;
            resources.ApplyResources(this.listView3, "listView3");
            this.listView3.HotTracking = true;
            this.listView3.HoverSelection = true;
            this.listView3.Name = "listView3";
            this.listView3.ShowItemToolTips = true;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // MainDashboard
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainDashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarseAlRepositorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirProyectosNuevosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarCamaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearProyectoConImagenCamaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearProyectoConArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem importarImagenesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}