using System;
using Xunit;
using Newtonsoft.Json;
using Shouldly;
using DevelApp.Utility.Model;

namespace Worflow.Core_UnitTest
{
    public class ModelSerialization
    {
        [Fact]
        public void KeyString_Serialization()
        {
            KeyString keyString = new KeyString(Guid.NewGuid().ToString());

            string output = JsonConvert.SerializeObject(keyString);

            KeyString deserializedKeyString = JsonConvert.DeserializeObject<KeyString>(output);

            deserializedKeyString.ShouldBe(keyString);
        }

        [Fact]
        public void SemanticVersionNumber_Serialization()
        {
            SemanticVersionNumber semanticVersionNumber = new SemanticVersionNumber(2,3,4);

            string output = JsonConvert.SerializeObject(semanticVersionNumber);

            SemanticVersionNumber deserializedSemanticVersionNumber = JsonConvert.DeserializeObject<SemanticVersionNumber>(output);

            deserializedSemanticVersionNumber.ShouldBe(semanticVersionNumber);
        }
    }
}
