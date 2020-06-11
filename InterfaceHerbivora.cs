using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Interface
{
  public class Herbivora : IHewan
  {
    public void PenggolonganMenurutMakanan()
    {
        Console.WriteLine("Herbivora adalah hewan yang makanannya hanya berupa tumbuhan saja (rumput, daun-daunan, biji-bijian, dan buah-buahan) digolongkan sebagai hewan pemakan tumbuhan.");
        Console.WriteLine("Contoh hewan Herbivora yang makan dedaunan, yaitu kambing, kuda, gajah, dan sapi. Herbivora pemakan biji-bijian, antara lain, burung pipit,kenari, tupai, dan merpati. Herbivora pemakan buah adalah burung beo, ulat buah, dan jalak.");
    }
  }
}
