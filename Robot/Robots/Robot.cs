namespace Robot.Robots
{

    public class Robot
    {

        public bool Active { get; private set; }

        public Robot() { }

        public void Initialize()
        {
            Active = true;
        }
    }
}