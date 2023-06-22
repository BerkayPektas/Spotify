using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Friends
    {
        /// <summary>
        /// hardcoded lijst friends word opgehaald. 
        /// </summary>
        private List<string> friends = new List<string> { "Jack", "John", "Tom" };
        /// <summary>
        /// methode die input vraagt en vanuit hier kan de user navigeren naar Viewfriends waar vrienden hardcoded staan of ze kunnen kiezen om terug naar het menu te gaan. 
        /// </summary>
        public void Display()
        {
            int optie = 0;

            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Show Friends");
                Console.WriteLine("2. Add Friends");
                Console.WriteLine("3. Remove Friends");
                Console.WriteLine("4. Back to menu");
                Console.Write("Option: ");
                optie = int.Parse(Console.ReadLine());

                switch (optie)
                {
                    case 1:
                        Console.WriteLine("Show Friends...");
                        ViewFriends();
                        break;
                    case 2:
                        Console.WriteLine("Add Friends...");
                        AddFriends();
                        break;
                    case 3:
                        Console.WriteLine("Remove Friends...");
                        RemoveFriends();
                        break;
                    case 4:
                        Console.WriteLine("Back to menu...");
                        break;
                    default:
                        Console.WriteLine("Onjuiste Keuze.");
                        break;
                }
                Console.WriteLine();
            } while (optie != 4);
        }

        private void AddFriends()
        {
            Console.Write("Enter a friend's name to add: ");
            string friendToAdd = Console.ReadLine();

            if (!string.IsNullOrEmpty(friendToAdd))
            {
                if (friends.Contains(friendToAdd))
                {
                    Console.WriteLine("This friend is already in your list.");
                }
                else
                {
                    friends.Add(friendToAdd);
                    Console.WriteLine("Friend added successfully.");
                }
            }
            else
            {
                Console.WriteLine("Invalid friend name. Friend addition canceled.");
            }
        }
        private void RemoveFriends()
        {
            Console.Write("Enter the name of the friend you want to remove: ");
            string friendToRemove = Console.ReadLine();

            if (friends.Contains(friendToRemove))
            {
                friends.Remove(friendToRemove);
                Console.WriteLine("Friend removed successfully.");
            }
            else
            {
                Console.WriteLine("This friend is not in your list.");
            }
        }
        /// <summary>
        ///  view friends method die de lijst die boven de code is opgehaald met private list displayed. in een string worden friends onderelkaar geprint.
        /// </summary>
        private void ViewFriends()
        {
            Console.WriteLine("Friends List:");
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }
        }
    }
}
