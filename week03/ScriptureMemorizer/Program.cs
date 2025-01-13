using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");

        // Create a list of Scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            // Old Testament
            new Scripture(new Reference("Genesis", 1, 1), "In the beginning God created the heaven and the earth."),
            new Scripture(new Reference("Exodus", 20, 3), "Thou shalt have no other gods before me."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
            new Scripture(new Reference("Isaiah", 40, 31), "But they that wait upon the LORD shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint."),
            new Scripture(new Reference("Jeremiah", 29, 11), "For I know the thoughts that I think toward you, saith the LORD, thoughts of peace, and not of evil, to give you an expected end."),
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the LORD with all thine heart; and lean not unto thine own understanding."),
            new Scripture(new Reference("Ecclesiastes", 3, 1), "To every thing there is a season, and a time to every purpose under the heaven:"),
            new Scripture(new Reference("Genesis", 1, 27), "So God created man in his own image, in the image of God created he him; male and female created he them."),
            new Scripture(new Reference("Joshua", 1, 9), "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the LORD thy God is with thee whithersoever thou goest."),
            new Scripture(new Reference("Isaiah", 41, 10), "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."),

            // New Testament
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."),
            new Scripture(new Reference("Matthew", 5, 16), "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."),
            new Scripture(new Reference("Matthew", 11, 28), "Come unto me, all ye that labour and are heavy laden, and I will give you rest."),
            new Scripture(new Reference("1 Corinthians", 13, 4), "Charity suffereth long, and is kind; charity envieth not; charity vaunteth not itself, is not puffed up,"),
            new Scripture(new Reference("Romans", 12, 2), "And be not conformed to this world: but be ye transformed by the renewing of your mind, that ye may prove what is that good, and acceptable, and perfect, will of God."),
            new Scripture(new Reference("Matthew", 22, 37), "Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind."),
            new Scripture(new Reference("John", 14, 27), "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid."),
            new Scripture(new Reference("Hebrews", 11, 1), "Now faith is the substance of things hoped for, the evidence of things not seen."),

            // Book of Mormon
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness."),
            new Scripture(new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass; and small means in many instances doth confound the wise."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Moroni", 10, 4), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."),
            new Scripture(new Reference("2 Nephi", 31, 20), "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men."),
            new Scripture(new Reference("Alma", 7, 11), "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people."),
            new Scripture(new Reference("Helaman", 5, 12), "And now, my sons, remember, remember, that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation."),
            new Scripture(new Reference("Mosiah", 18, 9), "Yea, and are willing to mourn with those that mourn; yea, and comfort those that stand in need of comfort, and to stand as witnesses of God at all times and in all things."),
            new Scripture(new Reference("3 Nephi", 27, 27), "What manner of men ought ye to be? Verily I say unto you, even as I am."),

            // Doctrine and Covenants
            new Scripture(new Reference("D&C", 4, 2), "Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind, and strength."),
            new Scripture(new Reference("D&C", 6, 36), "Look unto me in every thought; doubt not, fear not."),
            new Scripture(new Reference("D&C", 18, 10), "Remember the worth of souls is great in the sight of God."),
            new Scripture(new Reference("D&C", 58, 42), "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more."),
            new Scripture(new Reference("D&C", 64, 9), "Wherefore, I say unto you, that ye ought to forgive one another; for he that forgiveth not his brother his trespasses standeth condemned before the Lord."),
            new Scripture(new Reference("D&C", 121, 7), "My son, peace be unto thy soul; thine adversity and thine afflictions shall be but a small moment;"),
            new Scripture(new Reference("D&C", 130, 18), "Whatever principle of intelligence we attain unto in this life, it will rise with us in the resurrection."),
            new Scripture(new Reference("D&C", 82, 10), "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise."),
            new Scripture(new Reference("D&C", 89, 18), "And all saints who remember to keep and do these sayings, walking in obedience to the commandments, shall receive health in their navel and marrow to their bones;"),
            new Scripture(new Reference("D&C", 88, 118), "Seek ye out of the best books words of wisdom; seek learning, even by study and also by faith."),

            // Pearl of Great Price
            new Scripture(new Reference("Moses", 1, 39), "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man."),
            new Scripture(new Reference("Abraham", 3, 22), "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was."),
            new Scripture(new Reference("Moses", 7, 18), "And the Lord called his people Zion, because they were of one heart and one mind."),
            new Scripture(new Reference("Articles of Faith", 1, 13), "We believe in being honest, true, chaste, benevolent, virtuous, and in doing good to all men."),
            new Scripture(new Reference("Abraham", 2, 9), "And I will make of thee a great nation, and I will bless thee above measure, and make thy name great among all nations."),
        };

        // Randomize which scripture pops up for the user 
        Random random = new Random();
        int memorizedCount = 0; // Counter for memorized scriptures

        string mainMenuChoice = "";
        while (mainMenuChoice.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Memorize a random scripture");
            Console.WriteLine("2. Exit");
            Console.Write("\nEnter your choice (1 to memorize, or 'quit' to exit): ");
            mainMenuChoice = Console.ReadLine();

            if (mainMenuChoice.ToLower() == "quit" || mainMenuChoice == "2")
            {
                break; // Exit the program
            }
            else if (mainMenuChoice == "1")
            {
                // Select a random scripture
                Scripture scripture = scriptures[random.Next(scriptures.Count)];

                string userInput = "";
                while (!scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine("Memorizing Scripture:");
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nPress Enter to hide more words or type 'quit' to return to the menu.");
                    userInput = Console.ReadLine();

                    if (userInput.ToLower() == "quit")
                    {
                        break; // Exit the scripture loop and return to the main menu
                    }

                    scripture.HideRandomWords(3); // Hide 3 words at a time
                }

                if (scripture.IsCompletelyHidden())
                {
                    memorizedCount++;
                    Console.WriteLine("\nCongratulations! You've memorized this scripture.");
                }

                Console.WriteLine("\nPress Enter to return to the main menu.");
                Console.ReadLine(); // Wait for user input before returning to the menu
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 'quit'.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
            }
        }

        Console.Clear();
        Console.WriteLine($"You have memorized {memorizedCount} scriptures during this session.");
        Console.WriteLine("\nThank you for using the Scripture Memorizer Program. Goodbye!");
    }
}