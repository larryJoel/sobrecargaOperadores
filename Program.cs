class Program{
    static void Main(string[] args){
        var fracccion1 = new Fraccion(1,2);
        var fracccion2 = new Fraccion(1,4);

        Console.WriteLine(-fracccion1);
        Console.WriteLine(fracccion1 + fracccion2);
        Console.WriteLine(fracccion1 - fracccion2);
    }
}
