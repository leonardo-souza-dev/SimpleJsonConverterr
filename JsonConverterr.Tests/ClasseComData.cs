using System;
using System.Runtime.Serialization;

namespace JsonConverterr.Tests
{
    [DataContract]
    public class CustomTestClassComData
    {
        [DataMember(Name = "data")]
        public string Data { get; set; }

        public DateTime DataField
        {
            get
            {
                return Convert.ToDateTime(Data);
            }
        }
    }
}