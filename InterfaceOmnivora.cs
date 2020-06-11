using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Interface
{
  public class Omnivora : IHewan
  {
      public void PenggolonganMenurutMakanan()
      {
          Console.WriteLine("Omnivora adalah hewan pemakan tumbuhan maupun daging disebut omnivora.");
          Console.WriteLine("Musang adalah salah satu contoh omnivora.");
          Console.WriteLine("Contoh lainnya adalah beruang, ayam, bebek, dan tikus.Beruang selain makan ikan juga memakan buah-buahan dan madu. Ayam dan bebek sangat suka terhadap biji-bijian. Namun, keduanya juga sering makan cacing atau serangga kecil lainnya. Tikus seperti musang, ikan dan buah-buahan merupakan makanan kesukaannya.");
      }
  }
}
