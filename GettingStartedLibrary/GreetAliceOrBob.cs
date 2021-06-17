namespace GettingStartedLibrary
{
    public static class GreetAliceOrBob
    {        
        public static string GreetAliceOrBobSolution(string userInput)
        {
            var nameLowCase = userInput.ToLower();
            if (nameLowCase == "alice" || nameLowCase == "bob")
                return $"Nice to meet you {userInput}!";
            else
                return "Only Alice or Bob may use this program.";
        }
    }
}
