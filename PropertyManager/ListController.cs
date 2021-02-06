using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serializer;


namespace PropertyManager
{
    
    [Serializable]
    public class ListController<T> : IListController<T>
    {
        private List<T> list;

        public ListController()
        {
            list = new List<T>();
        }
       
        public int Count => list.Count;

   
        /// adds an object to the list.
       
        public bool Add(T aType)
        {
            try
            {
                list.Add(aType);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

       
        /// adds objects to the list from a file
        public bool BinaryDeSerialize(string fileName)
        {
            list = Serialize.FileDeSerialize<List<T>>(fileName);
            return true;
        }

        
        /// saves the list to a file
        
        public bool BinarySerialize(string fileName)
        {
            Serialize.FileSerializer(list, fileName);
            return true;
        }

        ///  replaces object in list with new object given in parameter.
        
        public bool ChangeAt(T aType, int anIndex)
        {
            try
            {
                list.RemoveAt(anIndex);
                list.Insert(anIndex, aType);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public bool CheckIndex(int index)
        {
            throw new NotImplementedException();
        }
        
        /// clears the list.
        
        public void DeleteAll()
        {
            list.Clear();
        }

        
        /// deletes type in given position
       
        public bool DeleteAt(int anIndex)
        {
            try
            {
                list.RemoveAt(anIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        /// returns index of given position
       
        public T GetAt(int anIndex)
        {
            try
            {
                return list[anIndex];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list[anIndex];
        }

       
        /// returns an array with all objects.
       
        public string[] ToStringArray()
        {
            string[] array = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                array[i] = list[i].ToString();
            }
            return array;
        }
      /// returns a list with all the objects
        
        public List<string> ToStringList()
        {
            List<string> stringList = new List<string>();
            for (int i = 0; i < Count; i++)
            {
                stringList.Add(list[i].ToString());
            }
            return stringList;
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
