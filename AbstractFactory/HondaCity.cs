using System;

namespace AbstractFactory
{
    public class HondaCity : ISedan
    {
        public string GetName()
        {
            return "Honda City";
        }
    }
}