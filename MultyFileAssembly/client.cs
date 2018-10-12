using System;
using MusicalInstruments;

public class Program
{
    static void Main()
    {
        Guitar obj = new Guitar();
        obj.GuitarInfo();

        ElectricGuitar obj1 = new ElectricGuitar();
        obj1.ElectricGuitarInfo();

        AcousticGuitar obj2 = new AcousticGuitar();
        obj2.AcousticGuitarInfo();

        Console.ReadLine();
    }
}
