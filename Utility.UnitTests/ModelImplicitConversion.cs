using System;
using Xunit;
using Newtonsoft.Json;
using Manatee.Json;
using DevelApp.Utility.Model;

namespace Worflow.Core_UnitTest
{
    public class ModelImplicitConversion
    {
        [Fact]
        public void KeyString_ImplicitConversion()
        {
            KeyString keyString = Guid.NewGuid().ToString();

            string output = keyString;
        }

        [Fact]
        public void SemanticVersionNumber_ImplicitConversion()
        {
            SemanticVersionNumber semanticVersionNumber = "2.3.4";
            SemanticVersionNumber semanticVersionNumber2 = new Version(1,2,3);

            string output = semanticVersionNumber;
            Version outputVersion = semanticVersionNumber2;
        }
    }
}
