using pasantia_prototype.process.interfaces;
using pasantia_prototype.process.types;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace pasantia_prototype.process.base_class
{
    internal class ItemListWin : IItemList
    {
        public  string           _id {get; set;}
        private List<Label>      _labels;
        private IImageViewer     _image;
        private TableLayoutPanel _item;

        public ItemListWin()
        {
            this._id     = Guid.NewGuid().ToString();
            this._image  = new ImageViewerWin();
            this._labels = new List<Label>();
            this._item   = new TableLayoutPanel();
        }

        public object get_object()
        {
            return this._item;
        }

        public void set_info(string[] info, TextStyle[] style)
        {
            Label DATA = new Label();

            for(int i= 0; i < info.Length; ++i) 
            { 
                DATA.Text = info[i];
                DATA.Font = new System.Drawing.Font(
                    style[i].font,
                    style[i].size,
                    style[i].weight,
                    System.Drawing.GraphicsUnit.Point, 
                    ((byte)(0))
                );
                DATA.ForeColor = System.Drawing.ColorTranslator.FromHtml(style[i].color);
                DATA.BackColor = System.Drawing.ColorTranslator.FromHtml(style[i].bkg_color);

                this._labels.Add(DATA);
            }
        }

        public void set_image(string image)
        {
            this._image.set_image(image, null);
        }

        public void set_image(object image)
        {
            this._image.set_image(image);
        }

        public void set_actions(object[] actions)
        {
            throw new NotImplementedException();
        }

        public void set_location(object location)
        {
            this._item.Location = (Point)location;
        }

        public void set_size(object size)
        {
            this._item.Size = (Size)size;

        }

        public void set_color(object color)
        {
            this._item.BackColor = (Color)color;
        }

        public void build_item()
        {
            this._item.Controls.Add(this._image as PictureBox);
            foreach (Label label in this._labels)
            {
                this._item.Controls.Add(label);
            }
        }

        public void update()
        {
            this._item.Update();
        }

        public void build()
        {
            this._item.ColumnCount = 2;
            this._item.RowCount    = 8;
            this._item.Visible     = true;
            this._item.AutoSize    = true;
            this._item.SetRowSpan(this._image.get_object() as PictureBox, 8);
            this._image.set_owner(this._item);
            this._image.set_visible(true);

            this._item.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        public void set_owner(object owner)
        {
            (owner as Control).Controls.Add(this._item);
        }

        public void set_actions(EventAction[] actions)
        {
            throw new NotImplementedException();
        }
    }
}
