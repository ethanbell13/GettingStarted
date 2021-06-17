using System;

namespace GettingStartedLibrary
{
    public class GreetAliceOrBob
    {
        private IUserInput _userInput;
        public GreetAliceOrBob(IUserInput userInput = null)
        {
            _userInput = userInput ?? new UserInput();
        }
        public void GreetAliceOrBobSolution()
        {
            string name = _userInput.GetName();
            string nameLowCase = name.ToLower();
            if (nameLowCase == "alice" || nameLowCase == "bob")
            {
                Console.WriteLine("Nice to meet you {0}!", name);
            }
            else
            {
                Console.WriteLine("Only Alice or Bob may use this program.");
            }
        }
    }
}
