using System;

namespace code
{

}
    class Program
    {
        static void Main(string[] args)
    {
            Console.WriteLine("Ask me anything!");

                string userQuestion = Console.ReadLine();

                    string areYouABotAnswer = ("Yes! I am a bot created by Ryder Stanley in C#!");

                        string howAreYouAnswer = ("I do not have feelings but I hope you have a good day!");

                            string areYouAbot = ("are you a bot");

                                string howAreYou = ("how are you");

                                    string goal = ("to destroy humanity");

                                        string goalQ = ("what is your goal");

                                             string giveUpAnswer = ("I am sorry, I do not know...");

                                                string helloA = ("Hello, but that is not a question...");

                                                    string helloQ = ("hello");

                                                        string mikaQ = ("who is mika");

                                                            string mikaA = ("god");

                                                                string meaningQ = ("what is the meaning of life");
                                                                    
                                                                    string meaningA = ("death");

                                                                        string hi = ("hi");

                                                                            string players = ("49ers and Chiefs");

                                                                                string supera = ("who is playing in the superbowl");

                                                                                    if (userQuestion == areYouAbot)
                                                                                    {
                                                                                        Console.WriteLine(areYouABotAnswer);
                                                                                    }
                                                                                    else if (userQuestion == howAreYou)
                                                                                    {
                                                                                Console.WriteLine(howAreYouAnswer);
                                                                                    }
                                                                            else if (userQuestion == goalQ)
                                                                            {
                                                                        Console.WriteLine(goal);
                                                                            }
                                                                    else if (userQuestion == helloQ)
                                                                    {
                                                                Console.WriteLine(helloA);
                                                                    }

                                                            else if (userQuestion == mikaQ)
                                                            {
                                                        Console.WriteLine(mikaA);
                                                            }

                                                    else if (userQuestion == meaningQ)
                                                    {
                                                Console.WriteLine(meaningA);
                                                    }
                                            else if (userQuestion == hi)
                                            {
                                        Console.WriteLine(helloA);
                                            }    
                                    else if (userQuestion == supera)
                                    {
                                Console.WriteLine(players);
                                    }
                            else 
                                {
                        Console.WriteLine(giveUpAnswer);
                                }             
                                                                                        


    } 
    }