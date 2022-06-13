using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AGOS.ObjectToProperty
{
    public class AGOS_Convert_Handle : AGOS_Convert
    {
        public List<Item> ConvertObjectToListProperty(object input)
        {
            List<Item> Items = new List<Item>();
            var props = input.GetType().GetProperties();
            foreach (var item in props)
            {
                Items.Add(new Item
                {
                    Key = item.Name,
                    Value = item.GetValue(input)
                });
            }
            return Items;
        }

        public List<Item> ConvertObjectToListProperty(object input, List<string> SelectedFields)
        {
            List<Item> Items = new List<Item>();
            var props = input.GetType().GetProperties();
            foreach (var item in props)
            {
                foreach (var select in SelectedFields)
                {
                    if (item.Name.Equals(select))
                    {
                        Items.Add(new Item
                        {
                            Key = item.Name,
                            Value = item.GetValue(input)
                        });
                    }
                }
            }
            return Items;
        }

        public List<Item> ConvertObjectToListPropertyExcept(object input, List<string> Excepts)
        {
            List<Item> Items = new List<Item>();
            var props = input.GetType().GetProperties();
            foreach (var item in props)
            {
                foreach (var select in Excepts)
                {
                    if (!item.Name.Equals(select))
                    {
                        Items.Add(new Item
                        {
                            Key = item.Name,
                            Value = item.GetValue(input)
                        });
                    }
                }
            }
            return Items;
        }
    }
}
