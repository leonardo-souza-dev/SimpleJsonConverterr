using System.Runtime.Serialization;

namespace SimpleJsonConverterr.Tests
{
    [DataContract]
    public class ClasseSimples
    {
        [DataMember(Name = "foo")] 
        public string Foo { get; set; }
    }
}