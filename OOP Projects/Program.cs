using Robot.Robots;
using Robot.Entities;

namespace Robot {
	public static class Program {

		public static void Main(string[] args) {
			GiantKillerRobot robot = new GiantKillerRobot();
			robot.initialize();

			robot.EyeLaserIntensity = LaserIntensity.KILL;
			robot.TargetTypes = new List<LivingEntityType>() { LivingEntityType.ANIMAL, LivingEntityType.HUMAN, LivingEntityType.SUPERHERO };

			Planet earth = Planets.Earth;

			while(robot.Active && earth.ContainsLife) {
				if(robot.CurrentTarget.IsAlive) {
					robot.FireLaserAt();
				} else {
					robot.AcquireNextTarget();	
				}
			}
		}
	}
}
