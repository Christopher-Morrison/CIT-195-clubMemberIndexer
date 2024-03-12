using System;
namespace ClubMemberIndexer
{
    class Program
    {
        public const int MaxSize = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[MaxSize];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < MaxSize; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }
            // indexer get and set methods
            public string this[int index]
            {
                get
                {
                    string temp;
                    //fake stuff below this
                    if (index >= 0 && index <= MaxSize - 1)
                    {
                        temp = Members[index];
                    }
                    else
                    {
                        temp = "";
                    }
                    return temp;
                }
                set
                {
                    if(index >= 0 && index <= MaxSize -1)
                    {
                        Members[index] = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // creates the object
            ClubMembers firstClub  = new ClubMembers();
            bool addMembers = true;
            Console.WriteLine($"Maximum Club size: {MaxSize}");
            while ( addMembers )
            {
                for (int i = 0; i < MaxSize;  i++)
                {
                    Console.WriteLine("Enter a club member: \nType quit to stop.");
                    string userInput = Console.ReadLine();
                    if (userInput == "quit")
                    {
                        addMembers = false;
                        break;
                    }

                    else
                        firstClub[i] = userInput;
                }
            }

            Console.WriteLine("What club type is this?");
            firstClub.ClubType = Console.ReadLine();
            Console.WriteLine("Where is this club?");
            firstClub.ClubLocation = Console.ReadLine();
            Console.WriteLine("What days does this club meet?");
            firstClub.MeetingDate = Console.ReadLine();

            Console.WriteLine("Club member: ");
            for (int i = 0;i < MaxSize;i++)
            {
                if (firstClub[i] != string.Empty)
                    Console.WriteLine(firstClub[i]); 
            }
            Console.WriteLine($"Club type: {firstClub.ClubType}\n" +
                $"Club Location: {firstClub.ClubType}\n" +
                $"Meeting Days: {firstClub.MeetingDate}");
        }
    }
}