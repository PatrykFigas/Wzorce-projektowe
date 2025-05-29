using System;
using System.Collections.Generic;

public class PrintSpooler
{
    private static PrintSpooler _instance;
    private static readonly object _lock = new object();
    private Queue<string> _queue;

    // Prywatny konstruktor
    private PrintSpooler()
    {
        _queue = new Queue<string>();
    }

    // Statyczna metoda dostępu do instancji (Singleton)
    public static PrintSpooler GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new PrintSpooler();
                }
            }
        }
        return _instance;
    }

    public void AddJob(string job)
    {
        Console.WriteLine($"Dodawanie zadania: {job}");
        _queue.Enqueue(job);
    }

    public void PrintJob()
    {
        if (_queue.Count > 0)
        {
            string job = _queue.Dequeue();
            Console.WriteLine($"Drukowanie: {job}");
        }
        else
        {
            Console.WriteLine("Kolejka jest pusta.");
        }
    }
}
