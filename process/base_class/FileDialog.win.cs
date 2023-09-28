using pasantia_prototype.process.interfaces;
using pasantia_prototype.process.enums;
using System.Windows.Forms;

namespace pasantia_prototype.process.base_class
{
    internal class FileDialogWin : IFileDialog
    { 
        private readonly OpenFileDialog _fileDialog;
        private bool m_open;

        public FileDialogWin()
        { 
            this._fileDialog = new OpenFileDialog();
            this.m_open = false;
        }


        public void close_dialog()
        {
            this._fileDialog?.Dispose();
        }

        public object get_content()
        { 
            if (this.m_open)
                return this._fileDialog.FileNames;
            else 
                return this._fileDialog.FileName;
        }       

        public object open_dialog(bool multiSelect)
        {
            this._fileDialog.Multiselect = multiSelect;
            this.m_open = multiSelect;
            this._fileDialog.ShowDialog();
            return this._fileDialog;
        }

        public object _object()
        {
            return this._fileDialog;
        }

        public object set_filter(enums.FileTypes type, string title)
        {
            switch (type) 
            {
                case FileTypes.images:
                    this._fileDialog.Filter = "Image | *.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    this._fileDialog.Title  = title;
                break;

                case FileTypes.files:
                    this._fileDialog.Filter = "Archivos | *.ted";
                    this._fileDialog.Title  = title;
                break;

                default:
                    throw new System.Exception("Este tipo de archivo no es permitido o no esta establecido");
            }

            return this._fileDialog;
        }
    }
}
