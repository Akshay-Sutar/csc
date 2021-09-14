namespace Interfaces
{
    interface Vehicle
    {
        public float TopSpeed { get; set; }
        public float CurrentSpeed { get; set; }
        public void accelerate();
        public void brake();
    }
}
