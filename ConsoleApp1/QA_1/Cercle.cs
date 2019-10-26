using System;

namespace WinForm_Test.TestInterfaces
{
    class Cercle : IDessin
    {
        public void Draw()
        {
            Console.WriteLine("Un rond");
        }
    }
}
