using System;

namespace AbstractFactory
{
    public class Figo : IHatchBack
    {
        public string GetName()
        {
            return "Figo";
        }
    }
}