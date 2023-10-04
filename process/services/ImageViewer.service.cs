using pasantia_prototype.process.interfaces;
using pasantia_prototype.process.base_class;
using System;

namespace pasantia_prototype.process.services
{
    internal class ImageViewerServ : IImageViewer
    {
        private readonly IImageViewer _imageViewer;
        public object _size { get; set; }

        public ImageViewerServ()
        {
            this._imageViewer = new ImageViewerWin();
        }

        public void close()
        {
            this._imageViewer.close();
        }

        public void draw()
        {
            this._imageViewer.draw();
        }

        public object get_object()
        {
            return this._imageViewer.get_object();
        }

        public void set_color(object color)
        {
            this._imageViewer.set_color(color);
        }

        public void set_image(object image)
        {
            this._imageViewer.set_image(image);
        }

        public void set_image(string path, object exception)
        {
            this._imageViewer.set_image(path, exception);
        }

        public void set_location(object location)
        {
            this._imageViewer.set_location(location);
        }

        public void set_owner(object owner)
        {
            this._imageViewer.set_owner(owner);
        }

        public void set_size(object size)
        {
            this._imageViewer.set_size(size);
        }

        public void set_visible(bool visible)
        {
            this._imageViewer.set_visible(visible);
        }

        public void update()
        {
            this._imageViewer.update();
        }
    }
}
