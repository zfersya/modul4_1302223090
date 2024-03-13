// See https://aka.ms/new-console-template for more information
using modul4_1302223090;
Console.WriteLine("\nSoal 1\n");

KodeBuah kodeBuah = new KodeBuah();

KodeBuah.NamaBuah namaBuah = KodeBuah.NamaBuah.Apel;
Console.WriteLine("Nama Buah "+ namaBuah + "    Kode Buah " + kodeBuah.GetKodeBuah(namaBuah) + "\n");
namaBuah = KodeBuah.NamaBuah.Blackberry;
Console.WriteLine("Nama Buah " + namaBuah + "   Kode Buah " + kodeBuah.GetKodeBuah(namaBuah));



