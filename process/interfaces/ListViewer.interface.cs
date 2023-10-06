using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasantia_prototype.process.interfaces
{
    public interface IListViewer
    {
        object set_container(object container);
        object set_listImg(object element);
        object set_listImg(Array elements);
        object set_listPrj(object[] elements);


    }
}
