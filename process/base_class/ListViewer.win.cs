using pasantia_prototype.process.interfaces;
using System.Windows.Forms;
using System;

namespace pasantia_prototype.process.base_class
{
    internal class ListViewerWin : IListViewer
    {
        private ListBox _listBox;

        public ListViewerWin(object listBox)
        {
            this._listBox   = (ListBox) listBox;
        }

        public object set_container(object container)
        {
            try
            {
                this._listBox = (ListBox)container;

                this._listBox.BackColor = System.Drawing.Color.AliceBlue;

                return true;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error al asignar el contenedor");
                return false;
            }
        }

        public object set_elements(object[] elements)
        {
            try
            {

                return true;
            }
            catch (System.Exception e)
            {
                Console.WriteLine($"Error al asignar los elementos {e.Message}");
                return false;
            }
        }

    }
}
