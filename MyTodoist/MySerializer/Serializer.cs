using System.Text;
using System.Text.Json;
using System.Xml.Serialization;


namespace MySerializer
{
    public class Serializer
    {
        public string SerializeJSON(object collection)
        {
            return JsonSerializer.Serialize(collection);
        }

        public object DeserializeJSON<T>(string str)
        {
            return JsonSerializer.Deserialize<T>(str)!;
        }

        public void SerializeXML<T>(FileStream fs, object obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            xmlSerializer.Serialize(fs, obj);
        }

        public object DeserializeXML<T>(string str)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (MemoryStream fst = new MemoryStream(Encoding.UTF8.GetBytes(str)))
            {
                return xmlSerializer.Deserialize(fst)!;
            }
        }

    }

}