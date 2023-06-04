namespace Robot.Entities
{
    public class Planet
    {
        public bool ContainsLife
        {
            get
            {
                bool value = false;

                foreach (ILivingEntity entity in Lifeforms)
                {
                    if (entity.IsAlive)
                    {
                        value = true;
                        break;
                    }
                }

                return value;

            }
            set { ContainsLife = value; }
        }

        public List<ILivingEntity> Lifeforms { get; private set; }

        public Planet() { }
    }
}
