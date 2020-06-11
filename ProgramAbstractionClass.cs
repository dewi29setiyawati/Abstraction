using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;
//using AbstractClass.Interface;

namespace Abstraction.AbstractClass
{
    public abstract class Hewan
    {
        public abstract void PenggolonganMenurutMakanan();
    }

    public class Penjelasan : Hewan
    {
      public override void PenggolonganMenurutMakanan()
      {
        Console.WriteLine("Hewan adalah organisme eukariotik multiseluler yang membentuk kerajaan biologi Animalia. Dengan sedikit pengecualian, hewan mengkonsumsi bahan organik, menghirup oksigen, dapat bergerak, bereproduksi secara seksual, dan tumbuh dari bola sel yang berongga, blastula, selama perkembangan embrio. Lebih dari 1,5 juta spesies hewan yang masih hidup telah dideskripsikan sekitar 1 juta adalah serangga, tetapi diperkirakan ada lebih dari 7 juta spesies hewan secara total. Hewan memiliki panjang dari 8,5 mikrometer sampai 33,6 meter dan memiliki interaksi yang rumit dengan satu sama lain dan lingkungannya, membentuk jaring-jaring makanan yang rumit. Studi tentang hewan disebut zoologi.");
      }
    }

    public class Karnivora : Hewan
    {
        public override void PenggolonganMenurutMakanan()
        {
          Console.WriteLine("Karnivora adalah hewan yang makanan utamanya hewan lain. Hewan karnivora mudah dikenali karena memiliki bagian tubuh yang berbeda dengan hewan herbivora. ");
          Console.WriteLine("Ciri hewan karnivora mempunyai indra penglihat,pencium,dan pendengar yang baik.");
          Console.WriteLine("Contoh hewan karnivora antara lain : Burung elang, burung rajawali, burung hantu, Nyamuk, laba-laba, Harimau, singa, serigala, ular, komodo, bunglon, cicak, tokek, hiu, arwana, dan loha.");
        }
    }

    public class Herbivora : Hewan
    {
        public override void PenggolonganMenurutMakanan()
        {
          Console.WriteLine("Herbivora adalah hewan yang makanannya hanya berupa tumbuhan saja (rumput, daun-daunan, biji-bijian, dan buah-buahan) digolongkan sebagai hewan pemakan tumbuhan.");
          Console.WriteLine("Contoh hewan Herbivora yang makan dedaunan, yaitu kambing, kuda, gajah, dan sapi. Herbivora pemakan biji-bijian, antara lain, burung pipit,kenari, tupai, dan merpati. Herbivora pemakan buah adalah burung beo, ulat buah, dan jalak.");
        }
    }

    public class Omnivora : Hewan
    {
        public override void PenggolonganMenurutMakanan()
        {
          Console.WriteLine("Omnivora adalah hewan pemakan tumbuhan maupun daging disebut omnivora.");
          Console.WriteLine("Musang adalah salah satu contoh omnivora.");
          Console.WriteLine("Contoh lainnya adalah beruang, ayam, bebek, dan tikus.Beruang selain makan ikan juga memakan buah-buahan dan madu. Ayam dan bebek sangat suka terhadap biji-bijian. Namun, keduanya juga sering makan cacing atau serangga kecil lainnya. Tikus seperti musang, ikan dan buah-buahan merupakan makanan kesukaannya.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //UNTUK ABSTRACT
            Hewan hewan;

            Console.WriteLine();
            hewan = new Penjelasan();
            hewan.PenggolonganMenurutMakanan();

            Console.WriteLine();
            Console.WriteLine("Penggolongan Hewan Menurut Jenis Makanannya : ");

            Console.WriteLine();
            hewan = new Karnivora();
            hewan.PenggolonganMenurutMakanan();

            Console.WriteLine();
            hewan = new Herbivora();
            hewan.PenggolonganMenurutMakanan();

            Console.WriteLine();
            hewan = new Omnivora();
            hewan.PenggolonganMenurutMakanan();

            Console.ReadKey();
        }
    }
}
