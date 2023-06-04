using Robot.Entities;

namespace Robot.Robots
{

    public class KillerRobot : Robot
    {

        public ILivingEntity CurrentTarget { get; private set; }

        public List<LivingEntityType> TargetTypes { get; set; }

        public Planet TargetPlanet { get; set; }

        public KillerRobot() : base() { }

        public void AcquireNextTarget()
        {
            int current_position = CurrentTarget is null ? 0 : TargetPlanet.Lifeforms.IndexOf(CurrentTarget);

            if (current_position == -1)
            {
                current_position = 0;
            }

            for (int i = current_position; i < TargetTypes.Count; i++)
            {
                if (TargetTypes.Contains(TargetPlanet.Lifeforms[i].EntityType))
                {
                    CurrentTarget = TargetPlanet.Lifeforms[i];
                }
            }
        }

        public void DestroyCurrentTarget()
        {
            CurrentTarget.IsAlive = false;
        }
    }
}
