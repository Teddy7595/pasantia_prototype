using pasantia_prototype.process.types;

namespace pasantia_prototype.process.interfaces
{
    interface IItemList
    {
        object get_object();
        void build();
        void set_owner(object owner);
        void set_info(string[] info,TextStyle[] style);
        void set_image(string imgPath);
        void set_image(object image);
        void set_size(object size);
        void set_color(object color);
        void set_location(object location);
        void set_actions(EventAction[] actions);
        void update();
    }
}
