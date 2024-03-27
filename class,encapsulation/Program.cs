namespace class_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Bedii","Test",56,35,200);
            
            Console.WriteLine(book.Name);
        }
    }
}
