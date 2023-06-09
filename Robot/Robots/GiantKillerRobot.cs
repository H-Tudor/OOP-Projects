﻿namespace Robot.Robots
{
    public class GiantKillerRobot : KillerRobot
    {

        public LaserIntensity EyeLaserIntensity { get; set; }

        public GiantKillerRobot() : base() { }

        public void FireLaserAtCurrentTarget()
        {
            if (EyeLaserIntensity >= LaserIntensity.KILL)
            {
                DestroyCurrentTarget();
            }
        }

    }
}
