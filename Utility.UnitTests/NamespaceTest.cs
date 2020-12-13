using DevelApp.Utility.Model;
using DevelApp.Utility.Exceptions;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Utility.UnitTests
{
    public class NamespaceTest
    {
        [Fact]
        public void ToFilePathTest()
        {
            //Works only on windows as Environment.NewLine is \
            NamespaceString namespaceString = new NamespaceString("Funny.Onion");
            namespaceString.ToFilePath.ShouldBe($"Funny\\Onion");
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
