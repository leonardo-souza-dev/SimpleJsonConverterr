using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JsonConverterr
{
    public static class JsonConverterr
    {
        public static T Desserializarr<T>(string body)
        {
            using var stream = new MemoryStream();
            using var writer = new StreamWriter(stream);
            writer.Write(body);
            writer.Flush();
            stream.Position = 0;
            
            return (T) new DataContractJsonSerializer(typeof(T)).ReadObject(stream);
        }
        
        public static string Serializarr<T>(T item)
        {
            using var ms = new MemoryStream();
            new DataContractJsonSerializer(typeof(T)).WriteObject(ms, item);
            
            return Encoding.Default.GetString(ms.ToArray());
        }
    }
}