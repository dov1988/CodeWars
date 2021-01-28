using NUnit.Framework;
using System.Collections.Generic;

namespace Kata17
{
    //Your start-up's BA has told marketing that your website has a large audience in Scandinavia and surrounding countries. Marketing thinks it would be great to welcome visitors to the site in their own language. Luckily you already use an API that detects the user's location, so this is an easy win.
    //The Task
    //Think of a way to store the languages as a database (eg an object). The languages are listed below so you can copy and paste!
    //Write a 'welcome' function that takes a parameter 'language' (always a string), and returns a greeting - if you have it in your database. It should default to English if the language is not in the database, or in the event of an invalid input.
    //The Database
    //{ "english", "welcome"},
    //{ "czech", "vitejte"},
    //{ "danish", "velkomst"},
    //{ "dutch", "welkom"},
    //{ "estonian", "tere tulemast"},
    //{ "finnish", "tervetuloa"},
    //{ "flemish", "welgekomen"},
    //{ "french", "bienvenue"},
    //{ "german", "willkommen"},
    //{ "irish", "failte"},
    //{ "italian", "benvenuto"},
    //{ "latvian", "gaidits"},
    //{ "lithuanian", "laukiamas"},
    //{ "polish", "witamy"},
    //{ "spanish", "bienvenido"},
    //{ "swedish", "valkommen"},
    //{ "welsh", "croeso"}
    public static class Kata
    {
        public static string Greet(string language)
        {
            return new Dictionary<string, string>()
            {

                { "english", "Welcome"},
                { "czech", "Vitejte"},
                { "danish", "Velkomst"},
                { "dutch", "Welkom"},
                { "estonian", "Tere tulemast"},
                { "finnish", "Tervetuloa"},
                { "flemish", "Welgekomen"},
                { "french", "Bienvenue"},
                { "german", "Willkommen"},
                { "irish", "Failte"},
                { "italian", "Benvenuto"},
                { "latvian", "Gaidits"},
                { "lithuanian", "Laukiamas"},
                { "polish", "Witamy"},
                { "spanish", "Bienvenido"},
                { "swedish", "Valkommen"},
                { "welsh", "Croeso"}

            }.TryGetValue(language, out string value) ? value : "Welcome";
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Welcome", Kata.Greet("english"));
            Assert.AreEqual("Welkom", Kata.Greet("dutch"));
            Assert.AreEqual("Welcome", Kata.Greet("IP_ADDRESS_INVALID"));
            Assert.AreEqual("Welcome", Kata.Greet(""));
            Assert.AreEqual("Welcome", Kata.Greet("2"));
        }
    }
}