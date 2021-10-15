using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SimpleJsonConverterr.Tests
{
    [DataContract]
    public class ClasseComplexa
    {
        [DataMember(Name = "lista")]
        public List<OutraLista> Lista { get; set; }
        
        [DataMember(Name = "outraLista")]
        public List<Lista> OutraLista { get; set; }
    }

    [DataContract]
    public class Lista
    {
        [DataMember(Name = "campo")]
        public string Campo { get; set; }
    }

    [DataContract]
    public class OutraLista
    {
        [DataMember(Name = "campoString")]
        public string CampoString { get; set; }
        
        [DataMember(Name = "campoBool")]
        public bool CampoBool { get; set; }
        
        [DataMember(Name = "campoInt")]
        public int CampoInt { get; set; }
        
        [DataMember(Name = "objeto")]
        public Objeto Objeto { get; set; }
    }

    [DataContract]
    public class Objeto
    {
        [DataMember(Name = "campo")]
        public string Campo { get; set; }
    }
}