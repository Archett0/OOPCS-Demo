using System;
using System.IO;
using OOPCS;

public class ProcessFile
{
    static void CopyObject(Person? original)
    {
        _ = original ?? throw new ArgumentException("Parameter cannot be null", nameof(original));
    }

    public static void Main()
    {
        // FileStream fs = null;
        // try
        // {
        //     // Opens a text tile.
        //     fs = new FileStream(@"C:\Users\Artemis\Desktop\data.txt", FileMode.Open);
        //     var sr = new StreamReader(fs);
        //
        //     // A value is read from the file and output to the console.
        //     string line = sr.ReadLine();
        //     Console.WriteLine(line);
        // }
        // catch (FileNotFoundException e)
        // {
        //     Console.WriteLine($"[Data File Missing] {e}");
        //     throw new FileNotFoundException(@"[data.txt not in C:\Users\Artemis\Desktop]", e);
        // }
        // finally
        // {
        //     if (fs != null)
        //         fs.Close();
        // }
        try
        {
            try
            {
                CopyObject(null);
            }
            catch (Exception e)
            {
                Console.WriteLine("---start of inner catch---");
                Console.WriteLine(e);
                Console.WriteLine("SB");
                throw new AggregateException("THIS IS AN EXCEPTION!", e);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("---start of outer catch---");
            Console.WriteLine(e);
            Console.WriteLine("Zhu bi");
        }
        finally
        {
            Console.WriteLine("!");
        }

        Console.WriteLine("?");
    }
}