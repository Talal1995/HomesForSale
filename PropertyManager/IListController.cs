using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManager
{
    //Interface IListController which mangae the list
    //Fatima & Talal
    interface IListController<T>
    {
         
       
        int Count { get; }

        bool Add(T aType);

        bool DeleteAt(int anIndex);

        bool ChangeAt(T aType, int anIndex);

        T GetAt(int anIndex);

        bool CheckIndex(int index);
       
        void DeleteAll();

        List<string> ToStringList();
       
        string[] ToStringArray();
       
        bool BinarySerialize(string fileName);
        bool BinaryDeSerialize(string fileName);
        bool XMLSerialize(string fileName);
    }

}
