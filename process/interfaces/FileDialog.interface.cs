using System;

namespace pasantia_prototype.process.interfaces
{
    interface IFileDialog
    {
        Object _object();
        Object open_dialog();
        void close_dialog();
        Object get_content();
        object set_filter(enums.FileTypes type, string title);
    }
}
