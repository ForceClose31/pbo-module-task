namespace ConsoleApp5
{
    public class Processor
    {
        public string merk, tipe;
    }

    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    public class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
    public class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "Core i3";
        }
    }
    public class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Core i5";
        }
    }
    public class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Core i7";
        }
    }
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "Ryzen";
        }
    }
    public class ATHLON : AMD
    {
        public ATHLON()
        {
            base.tipe = "ATHLON";
        }
    }

    public class VGA
    {
        public string merk;
    }
    public class Nvidia : VGA
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    public class amd : VGA
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }

    public class Laptop
    {
        public string merk, tipe;
        public VGA vga;
        public Processor processor;
        
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }
    public class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    public class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    public class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    public class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "ROG";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak ctak ctak, error lagii!!!");
        }
    }
    public class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    } 
    public class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game.");
        }
    } 
    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }
    public class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
    internal class Program
    {   
        static void Main(string[] args)
        {
            Laptop laptop1, laptop2;
            Predator predator;
            ACER acer;

            laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new Corei5();

            laptop2 = new IdeaPad();
            laptop2.vga = new amd();
            laptop2.processor = new Ryzen();

            predator = new Predator();
            predator.vga = new amd();
            predator.processor = new Corei7();

            acer = new Predator();

            // Soal 1
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            // Soal 2
            laptop1.Ngoding();

            // Soal 3
            Console.WriteLine($"Spesifikasi lengkap laptop 1 : merk VGA {laptop1.vga.merk}, merk processor {laptop1.processor.merk}, tipe processor {laptop1.processor.tipe}");

            // Soal 4
            predator.BermainGame();

            // Soal 5
            acer.BermainGame();
        }
    }
}