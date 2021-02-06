using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Serializer
{
    //The class saves and returns from and to the filePath
    public class Serialize
    {

     
       // saves the object to the filepath
       
        public static void FileSerializer(Object obj, string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Create))
            {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stream, obj);
                
            }
        }
       //returns the object from that filepath.
        
        public static T FileDeSerialize<T>(string filePath)
        {
            Object anObject = null;
            
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                    BinaryFormatter bf = new BinaryFormatter();
                    anObject = bf.Deserialize(stream);
            }
            return (T)anObject;
        }
    }
}
