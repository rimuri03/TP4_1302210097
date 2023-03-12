using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> kodePos = new Dictionary<string, string>() {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public string GetKodePos(string kelurahan)
    {
        if (kodePos.ContainsKey(kelurahan))
        {
            return kodePos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine("Kode Pos Batununggal: " + kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kujangsari: " + kodePos.GetKodePos("Kujangsari"));
        Console.WriteLine("Kode Pos Mengger: " + kodePos.GetKodePos("Mengger"));
        Console.WriteLine("Kode Pos Wates: " + kodePos.GetKodePos("Wates"));
        Console.WriteLine("Kode Pos Cijaura: " + kodePos.GetKodePos("Cijaura"));
        Console.WriteLine("Kode Pos Jatisari: " + kodePos.GetKodePos("Jatisari"));
        Console.WriteLine("Kode Pos Margasari: " + kodePos.GetKodePos("Margasari"));
        Console.WriteLine("Kode Pos Sekejati: " + kodePos.GetKodePos("Sekejati"));
        Console.WriteLine("Kode Pos Kebonwaru: " + kodePos.GetKodePos("Kebonwaru"));
        Console.WriteLine("Kode Pos Maleer: " + kodePos.GetKodePos("Maleer"));
        Console.WriteLine("Kode Pos Samoja: " + kodePos.GetKodePos("Samoja"));
    }
}