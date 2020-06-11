using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
  public class Karnivora : Hewan
  {
    public override void PenggolonganMenurutMakanan()
    {
      Console.WriteLine("Karnivora adalah hewan yang makanan utamanya hewan lain. Hewan karnivora mudah dikenali karena memiliki bagian tubuh yang berbeda dengan hewan herbivora. ");
      Console.WriteLine("Ciri hewan karnivora mempunyai indra penglihat,pencium,dan pendengar yang baik.");
      Console.WriteLine("Contoh hewan karnivora antara lain : Burung elang, burung rajawali, burung hantu, Nyamuk, laba-laba, Harimau, singa, serigala, ular, komodo, bunglon, cicak, tokek, hiu, arwana, dan loha.");
    }
  }
}
