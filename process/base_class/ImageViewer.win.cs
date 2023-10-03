using pasantia_prototype.process.interfaces;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace pasantia_prototype.process.base_class
{
    internal class ImageViewerWin : IImageViewer
    {
        private readonly PictureBox _pictureBox;
        public object _size { get; set; }

        public ImageViewerWin()
        {
            this._pictureBox = new PictureBox();
        }

        public void close()
        {
            this._pictureBox.Dispose();
        }

        public void set_image(object image)
        {
            this._pictureBox.Image = (Image)image;
        }

        public void set_image(string path, object exception)
        {
            try
            {
                this._pictureBox.Image = Image.FromFile(path);
            }
            catch (Exception)
            {

                //MessageBox.Show(
                //    "No se pudo cargar la imagen", 
                //    "Error", 
                //    MessageBoxButtons.OK, 
                //    MessageBoxIcon.Error
                //);

                this._pictureBox.BackColor = Color.DarkGreen;
            }
        }

        public void set_location(object location)
        {
            this._pictureBox.Location = (Point)location;
        }

        public void set_owner_win(object owner)
        {
            (owner as Form).Controls.Add(this._pictureBox);
        }

        public void set_owner(object owner) 
        {
            try
            {
                (owner as Control)?.Controls.Add(this._pictureBox);

            }catch(InvalidCastException)
            {
                throw new InvalidCastException("No se pudo anexar el componente en el componente padre");
            }
        }

        public void set_color(object color)
        {
            this._pictureBox.BackColor = (Color)color;
        }

        public void update()
        {
            this._pictureBox.Update();
        }

        public void set_size(object size)
        {
            this._pictureBox.Size = (Size)size;
        }

        public void draw()
        {
            throw new NotImplementedException();
        }

        public object get_object()
        {
            return this._pictureBox;
        }

        public void set_visible(bool visible)
        {
            this._pictureBox.Visible = visible;
        }
    }
}
