namespace Robot.Entities
{
    public interface ILivingEntity
    {

        public LivingEntityType EntityType { get; }

        public bool IsAlive { get; set; }
    }
}
