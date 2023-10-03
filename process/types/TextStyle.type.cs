using pasantia_prototype.process.enums;
using System;

namespace pasantia_prototype.process.types
{
    public struct TextStyle
    {
        public System.Drawing.FontStyle weight;
        public TextType  type { get; set; }
        public float     size;
        public string    color;
        public string    bkg_color;
        public string    font;
    }


}
