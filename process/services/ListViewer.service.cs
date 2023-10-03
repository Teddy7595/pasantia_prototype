using pasantia_prototype.process.interfaces;
using pasantia_prototype.process.base_class;
using System;

namespace pasantia_prototype.process.services
{
    internal class ListViewerServ : IListViewer
    {
        private readonly IListViewer _listViewer;
            
        public ListViewerServ()
        {
            this._listViewer = new ListViewerWin();
        }

        public object set_container(object container)
        {
            return this._listViewer.set_container(container);
        }

        public object set_elements(object[] elements)
        {
            return this._listViewer.set_elements(elements);
        }
    }
}
