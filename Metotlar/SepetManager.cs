using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi : "+ urun.Adi);
        }
    }
}
