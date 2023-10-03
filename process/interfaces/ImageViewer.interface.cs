using System;

namespace pasantia_prototype.process.interfaces
{
    interface IImageViewer
    {
        object _size { get; set; }
        object get_object();
        void set_visible(bool visible);
        void set_image(object image);
        void set_image(string path, object exception);
        void set_owner(object owner);
        void set_color(object color);
        void set_size(object size);
        void set_location(object location);
        void draw();
        void update();
        void close();
    }
}
