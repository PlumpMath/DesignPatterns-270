namespace Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var boxFight = new BoxFight();

            boxFight.AttachObserver(new RiskyPlayer());
            boxFight.AttachObserver(new ConservativePlayer());

            boxFight.NextRound();
            boxFight.NextRound();
            boxFight.NextRound();
            boxFight.NextRound();
        }
    }
}