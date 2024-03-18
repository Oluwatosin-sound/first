using System.Collections;
class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedscore = ScoreEntry();
            Console.WriteLine();
            foreach(var record in sortedscore.Keys)
            {
                Console.WriteLine($"key: {record} , value: {sortedscore[record]}");
            }


            Firststudent(sortedscore);
            Get60AndAbove(sortedscore);


        }

        static SortedList ScoreEntry()
        {
            Console.WriteLine("Enter the number of student");
            int number = int.Parse(Console.ReadLine());


           SortedList sortedscore = new SortedList();
            for(int i = 0; i < number; i++ )
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());
            sortedscore.Add(name, score);

        }

        return sortedscore;
        }


        static void Firststudent(SortedList sortedscore)
        {
            Console.WriteLine($"name: {sortedscore.GetKey(0)}  score: {sortedscore.GetByIndex(0)}");
            
        }

        static void Get60AndAbove(SortedList sortedscore)
        {
            SortedList sort = new SortedList();
            foreach(DictionaryEntry  element in sortedscore)
            {
                int score = (int) element.Value;
                if(score < 60)
                {
                    Console.WriteLine($"Name: {element.Key}");
                    Console.WriteLine();
                }
            }
        }

        

        
    }

