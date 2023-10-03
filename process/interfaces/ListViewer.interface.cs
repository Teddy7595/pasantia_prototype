using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasantia_prototype.process.interfaces
{
    interface IListViewer
    {
        object set_container(object container);
        object set_elements(object[] elements);

    }
}
