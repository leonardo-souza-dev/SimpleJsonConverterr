using System.Runtime.Serialization;

namespace JsonConverterr.Tests
{
    [DataContract]
    public class ClasseSimples
    {
        [DataMember(Name = "foo")] 
        public string Foo { get; set; }
    }
}