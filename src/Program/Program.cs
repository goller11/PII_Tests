using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Library juan = new Library("Juan Peréz", "50968735");
            Library alicia = new Library("Alicia García", "8.765.432-1");
            juan.IntroduceYourself();
            alicia.IntroduceYourself();
            
            if (Library.ValidateID(juan.CI) == true)
                Console.WriteLine("La cédula es válida.");
            else
                Console.WriteLine("La cédula no es válida.");                
        }
    }
}
