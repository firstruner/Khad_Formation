using System;

namespace WinForm_Test.TestInterfaces
{
    class Carre : IDessin
    {
        public void Draw()
        {
            Console.WriteLine("Un carré");
        }
    }
}
