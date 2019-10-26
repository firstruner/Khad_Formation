using System;
using System.Collections.Generic;
using QA_1;

namespace WinForm_Test.TestInterfaces
{
    public class Drawer
    {
        public void draw(List<IDessin> dessins)
        {
            foreach (IDessin dessin in dessins)
                dessin.Draw();
        }

        public IDessin GetDessin(EForme forme)
        {
            switch (forme)
            {
                case EForme.Cercle:
                    return new Cercle();
                case EForme.Carre:
                    return new Carre();
                case EForme.Triangle:
                    return new Triangle();
                default:
                    throw new ArgumentOutOfRangeException(nameof(forme), forme, null);
            }
        }
    }
}
