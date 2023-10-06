using pasantia_prototype.process.interfaces;
using pasantia_prototype.process.types;
using System.Windows.Forms;
using System.IO;
using System;
using System.Xml.Linq;
using System.Drawing;

namespace pasantia_prototype.process.base_class
{
    internal class ListViewerWin : IListViewer
    {
        private IFileHanlder    _fileHandler;
        private ImageList       _imageList;
        private ListView        _listView;


        public ListViewerWin(object listView)
        {
            
            this._imageList     = new ImageList();
            this._listView      = (ListView) listView;
            this._fileHandler   = FileHandlerWin.get_instance();
            this._imageList.ImageSize = new System.Drawing.Size(60, 60);
        }

        public object set_container(object container)
        {
            try
            {
                this._listView = (ListView) container;
                this._listView.BackColor = System.Drawing.Color.AliceBlue;

                return true;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error al asignar el contenedor");
                return false;
            }
        }

        public object set_listImg(object element)
        {   
            try
            {

                return true;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error al asignar la lista de imagenes");
                return false;
            }
        }

        public object set_listImg(Array elements)
        {
            try
            {
                IItemList viewer  = new ItemListWin();

                foreach (var item in elements)
                {
                    FileInfo info     = (FileInfo) this._fileHandler.get_fileInfo(item.ToString());
                    ListViewItem data = new ListViewItem();
                    this._imageList.Images.Add(Image.FromFile(info.FullName));
                    this._listView.LargeImageList = this._imageList;

                    data.Text = info.Name;
                    data.SubItems.Add(info.FullName);
                    data.SubItems.Add(info.Extension);
                    data.SubItems.Add(info.CreationTime.ToString());
                    data.SubItems.Add(info.Length.ToString());
                    data.ImageIndex = this._imageList.Images.Count - 1;
                    data.Font = new System.Drawing.Font(
                        "Arial",
                        11,
                        System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point,
                        ((byte)(0))
                    );
                    this._listView.Items.Add(data);

                }
                return elements;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return null;
            }
        }

        public object set_listPrj(object[] elements)
        {
            throw new NotImplementedException();
        }
    }
}
