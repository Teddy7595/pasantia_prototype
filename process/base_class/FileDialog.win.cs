using pasantia_prototype.process.interfaces;
using pasantia_prototype.process.enums;
using System.Windows.Forms;

namespace pasantia_prototype.process.base_class
{
    internal class FileDialogWin : IFileDialog
    { 
        private readonly OpenFileDialog _fileDialog;

        public FileDialogWin()
        { 
            this._fileDialog = new OpenFileDialog();
        }


        public void close_dialog()
        {
            throw new System.NotImplementedException();
        }

        public object get_content()
        {
            throw new System.NotImplementedException();
        }

        public object open_dialog()
        {
            this._fileDialog.ShowDialog();
            return this._fileDialog;
        }

        public object _object()
        {
            throw new System.NotImplementedException();
        }

        public object set_filter(enums.FileTypes type, string title)
        {
            switch (type) 
            {
                case FileTypes.images:
                    this._fileDialog.Filter = "image | *.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    this._fileDialog.Title  = title;
                break;

                case FileTypes.files:
                    this._fileDialog.Filter = "archivos | *.ted";
                    this._fileDialog.Title  = title;
                break;

                default:
                    throw new System.Exception("Este tipo de archivo no es permitido o no esta establecido");
            }

            return this._fileDialog;
        }
    }
}
