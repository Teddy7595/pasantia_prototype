using pasantia_prototype.process.interfaces;
using pasantia_prototype.process.base_class;
using System;

namespace pasantia_prototype.process.services
{
    internal class ListViewerServ : IListViewer
    {
        private readonly IListViewer _listViewer;
            
        public ListViewerServ(object listBox)
        {
            this._listViewer = new ListViewerWin(listBox);
        }

        public object set_container(object container)
        {
            return this._listViewer.set_container(container);
        }

        public object set_listImg(Array elements)
        {
            return this._listViewer.set_listImg(elements);
        }

        public object set_listImg(object element)
        {
            return this._listViewer.set_listImg(element);
        }

        public object set_listPrj(object[] elements)
        {
            return this._listViewer.set_listPrj(elements);
        }
    }
}
