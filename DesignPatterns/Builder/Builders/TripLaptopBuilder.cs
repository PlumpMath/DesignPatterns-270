namespace Builder
{
    public class TripLaptopBuilder : LaptopBuilder
    {
        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1200X800";
        }
        public override void SetProcessor()
        {
            Laptop.Processor = "Celeron 2 GHz";
        }
        public override void SetMemory()
        {
            Laptop.Memory = "2048 Mb";
        }
        public override void SetHDD()
        {
            Laptop.HDD = "250 Gb";
        }
        public override void SetBattery()
        {
            Laptop.Battery = "12 lbs";
        }
    }
}