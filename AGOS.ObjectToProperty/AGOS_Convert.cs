using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGOS.ObjectToProperty
{
    public interface AGOS_Convert
    {
        public List<Item> ConvertObjectToListProperty(object input);

        public List<Item> ConvertObjectToListProperty(object input, List<string> SelectedFields);

        public List<Item> ConvertObjectToListPropertyExcept(object input, List<string> Excepts);

    }
}
