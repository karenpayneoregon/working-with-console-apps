namespace StringBasicsConsoleApp.Classes
{
    public class NotAnonymous
    {
        public string Month { get; set; }
        public int Index { get; set; }

        public override string ToString()
        {
            return $"{{ Month = {Month}, Index = {Index} }}";
        }
    }
}