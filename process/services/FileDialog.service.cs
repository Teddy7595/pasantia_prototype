using pasantia_prototype.process.base_class;
using pasantia_prototype.process.interfaces;

namespace pasantia_prototype.process.services
{
    internal class FileDialogServ : IFileDialog
    {
        private readonly FileDialogWin _dialog;

        public FileDialogServ()
        {
            this._dialog = new FileDialogWin();
        }

        public void close_dialog()
        {
            this._dialog.close_dialog();
        }

        public object get_content()
        {
            return this._dialog.get_content();
        }

        public object open_dialog(bool multiSelect)
        {
            return this._dialog.open_dialog(multiSelect);
        }

        public object _object()
        {
            return this._dialog;
        }

        public object set_filter(enums.FileTypes type, string title)
        {
            return this._dialog.set_filter(type, title);
        }
    }
}
