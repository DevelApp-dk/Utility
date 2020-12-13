using DevelApp.Utility.Model;
using DevelApp.Utility.Exceptions;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.IO;

namespace Utility.UnitTests
{
    public class NamespaceTest
    {
        [Fact]
        public void ToFilePathTest()
        {
            //Works only on windows as Environment.NewLine is \
            NamespaceString namespaceString = new NamespaceString("Funny.Onion");
            string[] stringParts = namespaceString.ToFilePath.Split(Path.DirectorySeparatorChar);
            stringParts.Length.ShouldBe(2);
            if (stringParts.Length == 2)
            {
                stringParts[0].ShouldBe("Funny");
                stringParts[1].ShouldBe("Onion");
            }
        }

        [Fact]
        public void NamingPositive1()
        {
            string teststring = "F1unny.Onion";
            NamespaceString namespaceString = new NamespaceString(teststring);
            namespaceString.ToString().ShouldBe(teststring);
        }

        [Fact]
        public void NamingNegative1()
        {
            string teststring = "1Funny.Onion";
            Should.Throw<NamespaceStringException>(() => new NamespaceString(teststring));
        }
    }
}
