using NUnit.Framework;
using System;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class Teste
    {
        public string Nome = "Fabio";
        public object StringObject = "String Object";

        public int Idade = 32;
        public object IntObject = 18;

        public bool IsMale = true;
        public object BoolObject = false;

        [Test]
        public void Test1()
        {
            string nomeString = "Fabio String";
            var nomeVar = "Fabio Var";
            object nomeObject = "";

            int numeroInt = 1;
            var numeroVar = 2;
            object numeroObject = 3;

            bool isMale = true;
            var isFemale = false;
            object isObject = true;

            Console.WriteLine($"Olá! meu nome é {nomeString} e tenho { numeroVar } anos! Sou Masculino? { isFemale }");

        }


    }
}