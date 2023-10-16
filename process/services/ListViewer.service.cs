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

        public object set_listImg(Array element, object menuStrip)
        {
            return this._listViewer.set_listImg(element, menuStrip);
        }

        public object set_listPrj(Array elements, object menuStrip)
        {
            return this._listViewer.set_listPrj(elements, menuStrip);
        }
    }
}
