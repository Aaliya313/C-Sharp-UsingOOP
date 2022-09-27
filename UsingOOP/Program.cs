using UsingOOP;

class Program
{
    private static void Main(string[] args)
    {
        //Running the pet class before it was made abstract
        //Pet p1 = new Pet(1, "Fido", 6, "Black");
        //Console.WriteLine(p1.Getname());
        //p1.gettingOlder();
        //Console.WriteLine(p1.Getage());

        //Running the dog class
        //Dog d1 = new Dog(2, "Fred Abbas", 5, "Brown", "Beagle");
        //d1.GettingOlder();
        //Console.WriteLine($"{d1.Getname()} will be {d1.Getage()} years old");
        //d1.Play();

        //Using pet class but creating a dog class from it
        Dog d1 = new Dog(2, "Fred Abbas", 5, "Brown", "Beagle");
        d1.GettingOlder();
        Console.WriteLine($"{d1.Getname()} will be {d1.Getage()} years old");
        d1.Jump(); //put brackets in when its a method
    }



}
