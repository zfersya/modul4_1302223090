// See https://aka.ms/new-console-template for more information
using modul4_1302223090;
using System.ComponentModel.Design;
Console.WriteLine("\nSoal 1\n");
KodeBuah kodeBuah = new KodeBuah();
KodeBuah.NamaBuah namaBuah = KodeBuah.NamaBuah.Apel;
Console.WriteLine("Nama Buah "+ namaBuah + "    Kode Buah " + kodeBuah.GetKodeBuah(namaBuah) + "\n");
namaBuah = KodeBuah.NamaBuah.Blackberry;
Console.WriteLine("Nama Buah " + namaBuah + "   Kode Buah " + kodeBuah.GetKodeBuah(namaBuah));


Console.WriteLine("\nSoal 2\n");
PosisiKarakterGame.State state = PosisiKarakterGame.State.Berdiri;
string[] karakterState = { "Tengkurap", "Jongkok", "Berdiri", "Terbang"};
while (true)
{
    Console.WriteLine(karakterState[(int)state]);
    Console.WriteLine("Masukkan Command :");
    string command = Console.ReadLine();
    switch (state)
    {
        case PosisiKarakterGame.State.Berdiri:
            Console.WriteLine("Posisi Standby");
            if (command == "W")
                state = PosisiKarakterGame.State.Terbang;
            else if (command == "S")
                state = PosisiKarakterGame.State.Jongkok;
            else
                state = PosisiKarakterGame.State.Berdiri;
            break;
        case PosisiKarakterGame.State.Terbang:
            if (command == "X")
                state = PosisiKarakterGame.State.Jongkok;
            else if (command == "S")
                state = PosisiKarakterGame.State.Berdiri;
            else
                state = PosisiKarakterGame.State.Terbang;
            break;
        case PosisiKarakterGame.State.Jongkok:
            if (command == "W")
                state = PosisiKarakterGame.State.Berdiri;
            else if (command == "S")
                state = PosisiKarakterGame.State.Tengkurap;
            else
                state = PosisiKarakterGame.State.Jongkok;
            break;
        case PosisiKarakterGame.State.Tengkurap:
            
            if (command == "W")
                state = PosisiKarakterGame.State.Jongkok;
            else
                state = PosisiKarakterGame.State.Tengkurap;
            break;

    }
    
}
