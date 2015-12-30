namespace Builder
{
    public abstract class LaptopBuilder
    {
        protected Laptop Laptop { get; private set; }
        public void CreateNewLaptop()
        {
            Laptop = new Laptop();
        }
        public Laptop GetMyLaptop()
        {
            return Laptop;
        }
        //mentioned steps to build laptop
        public abstract void SetMonitorResolution();
        public abstract void SetProcessor();
        public abstract void SetMemory();
        public abstract void SetHDD();
        public abstract void SetBattery();
    }
}