using NUnit.Framework;
using System.Linq;

namespace SimpleJsonConverterr.Tests
{
    public class JsonConverterTests
    {
        [Test]
        public void QuandoClasseComData_DeveDesserializar()
        {
            // arrange
            var json = "{\"data\":\"2021-10-05T18:07:24+0200\"}";

            // act
            var aAssert = JsonConverterr.Desserializarr<CustomTestClassComData>(json);
            var result = JsonConverterr.Desserializarr<CustomTestClassComData>(json);

            // assert
            Assert.NotNull(result);
            Assert.AreEqual("2021-10-05T18:07:24+0200", result.Data);
            Assert.AreEqual(2021, result.DataField.Year);
            Assert.AreEqual(10, result.DataField.Month);
            Assert.AreEqual(5, result.DataField.Day);
        }
        
        [Test]
        public void QuandoClasseComplexa_DeveDesserializar()
        {
            // arrange
            var json = "{\"lista\": [" +
                          "{\"campoString\":\"trendy\", \"campoBool\":false, \"campoInt\":123, \"objeto\":{\"campo\":\"willy\"}}, " +
                          "{\"campoString\":\"wally\", \"campoBool\":true, \"campoInt\":5000, \"objeto\":{\"campo\":\"awesome\"}}, " +
                          "{\"campoString\":\"bob\", \"campoBool\":false, \"campoInt\":-1, \"objeto\":{\"campo\":\"alice\"}}" +
                          "]}"; 

            // act
            var result = JsonConverterr.Desserializarr<ClasseComplexa>(json);

            // assert
            Assert.NotNull(result);
            Assert.True(result.Lista.Any());
            Assert.AreEqual("trendy", result.Lista[0].CampoString);
            Assert.AreEqual(false, result.Lista[0].CampoBool);
            Assert.AreEqual(123, result.Lista[0].CampoInt);
            Assert.NotNull(result.Lista[0].Objeto);
            Assert.AreEqual("willy", result.Lista[0].Objeto.Campo);
            
            Assert.AreEqual("wally", result.Lista[1].CampoString);
            Assert.AreEqual(true, result.Lista[1].CampoBool);
            Assert.AreEqual(5000, result.Lista[1].CampoInt);
            Assert.NotNull(result.Lista[1].Objeto);
            Assert.AreEqual("awesome", result.Lista[1].Objeto.Campo);
            
            Assert.AreEqual("bob", result.Lista[2].CampoString);
            Assert.AreEqual(false, result.Lista[2].CampoBool);
            Assert.AreEqual(-1, result.Lista[2].CampoInt);
            Assert.NotNull(result.Lista[2].Objeto);
            Assert.AreEqual("alice", result.Lista[2].Objeto.Campo);
        }
        
        [Test]
        public void QuandoClasseSimples_DeveDesserializar()
        {
            // arrange
            var json = "{\"foo\":\"bar\"}";

            // act
            var result = JsonConverterr.Desserializarr<ClasseSimples>(json);

            // assert
            Assert.NotNull(result);
            Assert.AreEqual("bar", result.Foo);
        }
        
        [Test]
        public void QuandoClasseSimples_DeveSerializar()
        {
            // arrange
            var entidade = new ClasseSimples {Foo = "bar"};

            // act
            var result = JsonConverterr.Serializarr(entidade);

            // assert
            Assert.NotNull(result);
            Assert.AreEqual("{\"foo\":\"bar\"}", result);
        }
    }
}
