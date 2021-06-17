using System;
namespace GettingStartedLibrary
{
    public interface IUserChoice
    {
        string GetUserChoice();
    }
    public class UserChoice : IUserChoice
    {
        public string GetUserChoice()
        {
            Console.WriteLine("Enter p to receive the product or s to receive the sum:");
            string choice = Console.ReadLine().ToLower();
            while(choice != "p" || choice != "s")
            {
                Console.WriteLine("Enter p to receive the product or s to receive the sum:");
                choice = Console.ReadLine().ToLower();
            }
            return choice;
        }
    } 
    public class SumOrProduct
    {
        private IUserChoice _userChoice;
        public SumOrProduct(IUserChoice userChoice = null)
        { 
            _userChoice = userChoice ?? new UserChoice(); 
        }
        public int SumOrProductSolution(int n)
        {
            int x = 0;
            if (_userChoice.GetUserChoice() == "s" && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    x += i;
                }
                return x;
            }
            else if (_userChoice.GetUserChoice() == "s" && n <= 0)
            {
                for (int i = 1; i >= n; i--)
                {
                    x += i;
                }
                return x;
            }
            else if (_userChoice.GetUserChoice() == "p" && n > 0)
                {
                    x = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        x *= i;
                    }
                    return x;
                }
            else
            {
                return 0;
            }
        }
    }
}
