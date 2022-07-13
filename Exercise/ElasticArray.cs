using System.Collections;

namespace Exercise;

public class ElasticArray
{
    public ArrayList Array { get; set; }

    public ElasticArray()
    {
        Array = new ArrayList();
    }

    public void AddInteger()
    {
        Console.Write("ENTER INTEGER TO ADD: ");
        var input = Console.ReadLine();
        if (int.TryParse(input, out var newInteger))
        {
            Array.Add(newInteger);
            Console.WriteLine("\n>>> INTEGER ADDED. <<<\n");
        }
        else
        {
            Console.WriteLine("\n>>> FAILED TO ADD INTEGER. CHECK YOUR INPUT. <<<\n");
        }
    }

    public void RemoveByValue()
    {
        Console.Write("ENTER INTEGER TO REMOVE: ");
        var input = Console.ReadLine();
        if (int.TryParse(input, out var newInteger))
        {
            Array.Remove(newInteger);
            Console.WriteLine("\n>>> INTEGER REMOVED. <<<\n");
        }
        else
        {
            Console.WriteLine("\n>>> FAILED TO REMOVE INTEGER. <<<\n");
        }
    }

    public void RemoveByIndex()
    {
        Console.Write("ENTER INTEGER INDEX TO REMOVE: ");
        var input = Console.ReadLine();
        if (int.TryParse(input, out var newInteger))
        {
            Array.RemoveAt(newInteger);
            Console.WriteLine("\n>>> INTEGER REMOVED. <<<\n");
        }
        else
        {
            Console.WriteLine("\n>>> FAILED TO REMOVE INTEGER. <<<\n");
        }
    }

    public void FindInteger()
    {
        Console.Write("ENTER INTEGER TO FIND INDEX: ");
        var input = Console.ReadLine();
        if (int.TryParse(input, out var newInteger))
        {
            var res = Array.IndexOf(newInteger);
            Console.WriteLine(
                res == -1
                ? "\n>>> INTEGER NOT FOUND. <<<\n"
                : $"\n>>> INTEGER IS AT: {res} <<<\n");
        }
        else
        {
            Console.WriteLine("\n>>> FAILED TO FIND INTEGER. <<<\n");
        }
    }

    public void GetSize()
    {
        if (Array.Count == 0)
        {
            Console.WriteLine("\n>>> EMPTY <<<\n");
        }
        else
        {
            Console.WriteLine("\n>>> ARRAY HAS {0} INTEGER(s). <<<\n", Array.Count);
        }
    }

    public void ShowContent()
    {
        if (Array.Count == 0)
        {
            Console.WriteLine("\n>>> EMPTY <<<\n");
            return;
        }
        Console.Write("VALUES:");
        foreach (var element in Array)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("\n");
    }

    public void ShowMenu()
    {
        Console.WriteLine("\n1. ADD INTEGER");
        Console.WriteLine("2. REMOVE INTEGER OF VALUE X");
        Console.WriteLine("3. REMOVE INTEGER AT POSITION X");
        Console.WriteLine("4. FIND INTEGER");
        Console.WriteLine("5. HOW MANY ELEMENTS RIGHT NOW?");
        Console.WriteLine("6. SHOW CONTENT\n");
        Console.Write("PLEASE CHOOSE ONE: ");
        var input = Console.ReadLine();
        var isValid = int.TryParse(input, out var choice);
        if (!isValid)
        {
            Console.WriteLine("\n>>> INVALID INPUT <<<\n");
            return;
        };

        switch (choice)
        {
            case 1:
                AddInteger();
                break;
            case 2:
                RemoveByValue();
                break;
            case 3:
                RemoveByIndex();
                break;
            case 4:
                FindInteger();
                break;
            case 5:
                GetSize();
                break;
            case 6:
                ShowContent();
                break;
            default:
                Console.WriteLine("\n>>> INVALID INPUT <<<\n");
                break;
        }
    }

}