namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new Myself(new DefaultWearingStrategy());
            me.GoOutside();

            me.ChangeStrategy(new RainWearingStrategy());
            me.GoOutside();

            me.ChangeStrategy(new SunshineWearingStrategy());
            me.GoOutside();
        }
    }
}
