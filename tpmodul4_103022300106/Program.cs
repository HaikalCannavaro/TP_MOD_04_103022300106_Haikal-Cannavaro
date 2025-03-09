using System;
using tpmodul4_103022300106;
class Program
{
    static void Main()
    {
        Console.WriteLine("Table-Driven Approach:");
        Console.WriteLine("Kode Pos Batununggal: " + KodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Cijaura: " + KodePos.GetKodePos("Cijaura"));

        Console.WriteLine("\nState-Based Construction:");
        DoorMachine door = new DoorMachine();
        door.BukaPintu();
        door.KunciPintu();
    }
}
