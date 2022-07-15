namespace Quiz;

public class PhotoDemo
{
    static void Main(string[] args)
    {
        Photo eightByTenPhoto = new Photo(8, 10);
        Photo tenByTwelvePhoto = new Photo(10, 12);
        Photo otherPhoto = new Photo(8, 20);
        Console.WriteLine(eightByTenPhoto);
        Console.WriteLine(tenByTwelvePhoto);
        Console.WriteLine(otherPhoto);

        MattedPhoto mattedPhoto = new MattedPhoto(8, 10, "Blue");
        Console.WriteLine(mattedPhoto);

        FramedPhoto framedPhoto = new FramedPhoto(10, 12, "Silver", "Light");
        Console.WriteLine(framedPhoto);
    }
}