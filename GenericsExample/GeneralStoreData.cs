using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public  class GeneralStoreData<T>
    {
        public List<T> item;
        public GeneralStoreData()
        {
            item=new List<T>();
        }
        public void AddItem(T newitem)
        {
           item.Add(newitem);
          Console.WriteLine($"{newitem} has added");

        }
        public List<T> GetItem()
        {
            return item;
        }
    }
}
