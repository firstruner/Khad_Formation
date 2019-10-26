using System;

namespace WinForm_Test.TestInterfaces
{
    class Triangle : IDessin
    {
        public void Draw()
        {
            Console.WriteLine("Un triangle");
        }
    }
}
