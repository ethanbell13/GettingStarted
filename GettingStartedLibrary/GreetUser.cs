using System;

namespace GettingStartedLibrary
{
    public class UserInput : IUserInput
    {
        public string GetName()

        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }
    }
    public class GreetUser
    {
        private IUserInput _userInput;
        public GreetUser(IUserInput userInput = null)
        {
            _userInput = userInput ?? new UserInput();
        }
        public void GreetUserSolution()
        {
            string name = _userInput.GetName();
            if (name == "")
            {
                Console.WriteLine("That's not much of a name.");
            }
            else
            {
                Console.WriteLine("Nice to meet you {0}!", name);
            }
        }
    }
}
