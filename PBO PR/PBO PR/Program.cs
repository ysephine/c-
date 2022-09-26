using System;
using System.Runtime.CompilerServices;

namespace untukProcessor
{
    class Processor
    {
        public string Merk, Type;
    }

    class Intel : Processor
    {
        public Intel()
        { base.Merk = "Intel"; }
    }
    class AMD : Processor
    {
        public AMD()
        { base.Merk = "AMD"; }
    }

    class Corei3 : Intel
    {
        public Corei3()
        { base.Type = "Core i3"; }
    }
    class Corei5 : Intel
    {
         public Corei5()
         { base.Type = "Core i5"; }
    }
    class Corei7 : Intel
     {
         public Corei7()
            { base.Type = "Core i7"; }
     }

    class Ryzen : AMD
     {
         public Ryzen()
         { base.Type = "RAYZEN"; }
     }
    class Athlon : AMD
    {
        public Athlon()
        { base.Type = "ATHLON"; }
    }
}

namespace untukVGA
{
    class VGA
    {
        public string Merk;
    }

    class Nvidia : VGA
    { public Nvidia()
        { base.Merk = "Nvidia"; }
    }

    class AMD : VGA
    {
        public AMD()
        { base.Merk = "AMD"; }
    }
}

class Laptop
{
    public string Merk, Type;
    public untukVGA.VGA VGA;
    public untukProcessor.Processor Processor;

    public void LaptopDinyalakan()
    { Console.WriteLine($"Laptop {Merk} {Type} menyala"); }
    public void LaptopDimatikan()
    { Console.WriteLine($"Laptop {Merk} {Type} mati"); }
}

class ASUS : Laptop
{
    public ASUS()
    { base.Merk = "ASUS"; }
}

class ACER : Laptop
{
    public ACER()
    { base.Merk = "ACER"; }
}

class Lenovo : Laptop
{
    public Lenovo()
    { base.Merk = "Lenovo"; }
}


class ROG : ASUS
{
    public ROG()
    { base.Type = "ROG"; }
}

class Vivobook : ASUS
{
    public Vivobook()
    { base.Type = "Vivobook"; }

    public void Ngoding()
    { Console.WriteLine("Ctak Ctak ERROR lagi!! "); }
}

class Swift : ACER
{
    public Swift()
    { base.Type = "Swift"; }
}

class Predator : ACER
{
    public Predator()
    { base.Type = "Predator"; }

    public void BermainGame()
    { Console.WriteLine($"Laptop {Merk} {Type} sedang memainkan game"); }
}

class Ideapad : Lenovo
{
    public Ideapad()
    { base.Type = "Ideapad"; }
}

class Legion : Lenovo
{
    public Legion()
    { base.Type = "Legion"; }
}

internal class program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();

        Laptop laptop2 = new Ideapad();

        Predator predator = new Predator();

        laptop1.VGA = new untukVGA.Nvidia();
        laptop1.Processor = new untukProcessor.Corei5();

        laptop2.VGA = new untukVGA.AMD();
        laptop2.Processor = new untukProcessor.Ryzen();

        predator.VGA = new untukVGA.AMD();
        predator.Processor = new untukProcessor.Corei7();

        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        //laptop1.ngoding();

        Console.WriteLine(laptop1.VGA.Merk);

        predator.BermainGame();

        ACER acer = new Predator();
        //acer.bermaingame();
    }
}