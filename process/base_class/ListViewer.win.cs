using pasantia_prototype.process.interfaces;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace pasantia_prototype.process.base_class
{
    internal class ListViewerWin : IListViewer
    {
        private readonly List<object> _list;
        private ListBox _listBox;

        public ListViewerWin()
        {
            this._list      = new List<object>();
            this._listBox   = new ListBox();
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
