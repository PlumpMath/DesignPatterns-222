using System;

namespace AbstractFactory
{
    public class Fiesta : ISedan
    {
        public string GetName()
        {
            return "Fiesta";
        }
    }
}