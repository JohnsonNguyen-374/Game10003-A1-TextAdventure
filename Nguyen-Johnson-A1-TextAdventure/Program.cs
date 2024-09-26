// Text Adventure (5+ Scenarios, 75-300 Lines of Code, Conditional/Boolean Variables, Parsing, Console IO)
using System.ComponentModel.Design;
using System.Net.Sockets;
class Program
{
    static void Main()
    {
        //Introduce the User to this Text Adventure
        Console.WriteLine("Welcome to the Land of Xenadia!");

        //Request for Character Name and Store the Value
        Console.WriteLine("Please enter your name: ");
        string Name = Console.ReadLine();

        //Request the User to Choose a Class by typing the class name
        Console.WriteLine("Choose a class: ");
        Console.WriteLine("Warrior");
        Console.WriteLine("Mage");
        Console.WriteLine("Cleric");
        Console.WriteLine("Assassin");
        string Class = Console.ReadLine();

        //Checking for User Input
        if (Class == "warrior")
        {
            Console.WriteLine($"You have chosen the {Class} class");
        }
        else
        {
            Console.WriteLine("Input is Invalid");
            Console.WriteLine("You are classless");
        }

        //Checking for User Input
        if (Class == "mage")
        {
            Console.WriteLine($"You have chosen the {Class} class");
        }
        else
        {
            Console.WriteLine("Input is Invalid");
            Console.WriteLine("You are classless");
        }

        //Checking for User Input
        if (Class == "cleric")
        {
            Console.WriteLine($"You have chosen the {Class} class");
        }
        else
        {
            Console.WriteLine("Input is Invalid");
            Console.WriteLine("You are classless");
        }

        //Checking for User Input
        if (Class == "assassin")
        {
            Console.WriteLine($"You have chosen the {Class} class");
        }
        else
        {
            Console.WriteLine("Input is Invalid");
            Console.WriteLine("You are classless");
        }

        Console.WriteLine("You have just woken up in the Central City Belios and your adventure to slay the evil dragon has begun!");

        //Ask the Player if they would like to buy any suuplies before they leave the city and tell the User how much gold they have
        Console.WriteLine("Would you like to head to the store before leaving the city: ");
        Console.WriteLine("You currently have 40 Gold in your pockets");
        //Amount of Starting Currency
        int Gold = 40;
        string goShop = Console.ReadLine();

        //Checking for User Input
        if (goShop == "yes")
        {
            //Request if the User wants to buy an item
            Console.WriteLine("Would you like to buy something:");
            string buySomething = Console.ReadLine();

            //Checking for User Input
            if (buySomething == "yes")
            {
                //Request what the User wants to buy
                Console.WriteLine("What would you like to buy;");
                Console.WriteLine("Iron Sword: 20 Gold");
                Console.WriteLine("Scholar's Staff: 20 Gold");
                Console.WriteLine("Divine Tome: 20 Gold");
                Console.WriteLine("Poison Tipped Dagger: 20 Gold");
                string Weapon = Console.ReadLine();

                //Adjust the Users Amount of Currency accordingly
                Gold = Gold - 20;

                Console.WriteLine($"You have bought the {Weapon} and now you have {Gold} left in your pockets");
                Console.WriteLine("You have left the shop");

            }
            else if (buySomething == "no")
            {
                Console.WriteLine("You left the shop without buying anything, window shopper");
            }
            else
            {
                Console.WriteLine("Input is Invalid");
                Console.WriteLine("You have left the shop");
            }
        }
        else if (goShop == "no")
        {
            Console.WriteLine("You have left Belios to start your long journey to slay the evil dragon");
        }
        else
        {
            Console.WriteLine("Input is Invalid");
        }

        Console.WriteLine("Along your journey you encounter a Mutant Slime in the Groggy Swamp");

        //Request User if they want to engage the Mutant Slime in Combat
        Console.WriteLine("Do you wish to engage in combat: ");
        string engageSlime = Console.ReadLine();

        //Checking for User Input
        if (engageSlime == "yes")
        {
            Console.WriteLine("You attacked the Mutant Slime and won");
            //Request if the User wants to equip the Slime Ring
            Console.WriteLine("The Mutant Slime dropped a Slime Ring, do you want to equip it:");
            string equipRing = Console.ReadLine();

            //Checking for User Input
            if (equipRing == "yes")
            {
                Console.WriteLine("You have equipped the Slime Ring");
            }
            else if (equipRing == "no")
            {
                Console.WriteLine("You left the Slime Ring behind");
            }
            else
            {
                Console.WriteLine("Input is Invalid");
            }
        }
        else if (engageSlime == "no")
        {
            Console.WriteLine("You continue on your journey to slay the evil dragon");
        }
        else
        {
            Console.WriteLine("Input is Invalid");
        }

        Console.WriteLine("Your next stop is the Abandoned Hut in the Woods");
        Console.WriteLine("You meet a lady that requests you to donate gold to her for medication");
        //Request User if they want to donate Gold
        Console.WriteLine("Would you like to donate some gold: ");
        string donateGold = Console.ReadLine();

        //Checking for User Input
        if (donateGold == "yes")
        {
            //Request User for Amoun of Currency to Donate
            Console.WriteLine("How much gold would you like to donate to the lady: ");
            //Convert String into Integer
            int amountDonated = int.Parse(Console.ReadLine());

            //Checking for User Input
            if (amountDonated > 0)
            {
                //Checking for User Input
                if (amountDonated <= Gold)
                {
                    Gold = Gold - amountDonated;
                    Console.WriteLine($"You have donated {amountDonated} gold to the lady and now you have {Gold} gold leftover");
                }
                else if (amountDonated > Gold)
                {
                    Console.WriteLine($"You don't have {amountDonated} gold in your pockets");
                }
            }
            else if (amountDonated == 0)
            {
                Console.WriteLine("Nice try scame artist, the lady has casted a curse upon you, now you have the Curse of Demise");
            }
            else
            {
                Console.WriteLine("Input is Invalid");
            }
        }
        else if (donateGold == "no")
        {
            Console.WriteLine("The lady has casted a curse upon you, now you have the Curse of Demise");
        }
        else
        {
            Console.WriteLine("Input is Invalid");
        }

        Console.WriteLine("You finally made it to your final destination, the lair of the evil dragon Twitter");
        //Request if the User wants to enter the lair to fight the dragon
        Console.WriteLine("Do you want to enter the lair and fight the dragon Twitter: ");
        string engageDragon = Console.ReadLine();

        //Checking for User Input
        if (engageDragon == "yes")
        {
            Console.WriteLine("After a fierce battle that lasted 2 days and 2 nights, you came triumphed");
            Console.WriteLine("Before you dealt the final blow, the Dragon pleads you to spare it, will you spare the Dragon: ");
            string spareDragon = Console.ReadLine();

            //Checking for User Input
            if (spareDragon == "yes")
            {
                Console.WriteLine("You spared the Dragon and it became your familiar, you are now a Dragonrider");
                //Recalling User Input
                if (donateGold == "no")
                {
                    Console.WriteLine("Just kidding, remember when you didn't donate gold and got cursed, well now you're dead");
                }
            }
            else if (spareDragon == "no")
            {
                Console.WriteLine("The Dragon Twitter was slain and you saved all of humanity, thank god Twitter is gone");
                //Recalling User Input
                if (donateGold == "no")
                {
                    Console.WriteLine("Just kidding, remember when you didn't donate gold and got cursed, well now you're dead");
                }
            }
            else
            {
                Console.WriteLine("Input is Invalid");
            }
        }
        else if (engageDragon == "no")
        {
            Console.WriteLine("You went on your way to a local hotspring and completely forgot about the Dragon");
            Console.WriteLine("As a result, the world was being completely annihilated by the Dragon while you were lazily enjoying the hotsprings");
            //Recalling User Input
            if (donateGold == "no")
            {
                Console.WriteLine("Just kidding, remember when you didn't donate gold and got cursed, well now you're dead");
            }
            Console.WriteLine("Game Over, Bad End");
        }
        else
        {
            Console.WriteLine("Input is Invalid");
        }
    
    }
}