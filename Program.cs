namespace Day5Assignment1
{ public enum enGenre {
           Fiction = 1,
           NonFiction = 2,
           Mystery = 3 ,
           ScienceFiction = 4,
           Biography = 5
        };
        struct stBooks 
        {
           public string title;
           public string author;
           public int publicationYear;
           public enGenre genre;

        };

   

    internal class Program
    {   
      

        static void Main(string[] args)
        {


            stBooks[] arBooks = new stBooks[3];

            Console.WriteLine("Assignment 1: Store and Display Book Information\n");


            //store data
            for (int x = 0; x < arBooks.Length; x++)
            {
                Console.WriteLine($"   Book no.{x+1}  ");
                arBooks[x] = new stBooks();
                Console.Write(" Enter book name : ");
                arBooks[x].title = Console.ReadLine();
                Console.WriteLine("--------------------");
                Console.Write(" Enter Author Name : ");
                arBooks[x].author = Console.ReadLine();
                Console.WriteLine("--------------------");
                Console.Write(" Publication year : ");
                arBooks[x].publicationYear = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------");
                int choice = 0;
                do
                {
                    Console.WriteLine(" choose genre : ");
                    int n = 0;
                    foreach (var item in Enum.GetValues(typeof(enGenre)))
                    {
                        n++;
                        Console.WriteLine($" {n} - {item}");
                    }
                    Console.Write(" choice : ");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------");
                } while (choice < 1 || choice > 5);

                arBooks[x].genre = (enGenre)choice;

            }


                Console.WriteLine("\n\n");
            //display data
                Console.WriteLine("----> Books Library <----");
                Console.WriteLine();
                int i = 0;
                foreach (var item in arBooks)
                {
                    Console.WriteLine($" Book no.{i + 1} ");
                Console.WriteLine($" - Book title : {arBooks[i].title} ");
                Console.WriteLine($" - Author : {arBooks[i].author}");
                Console.WriteLine($" - Publication Year : {arBooks[i].publicationYear}");
                Console.WriteLine($" - Genre : {arBooks[i].genre.ToString()}");
                Console.WriteLine("--------------------");
                i++;
                }



        }
    }
}
