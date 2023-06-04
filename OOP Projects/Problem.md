
# Task at hand

Acme Robotics want to develop a giant robot that can eliminate all living entities of given types on a given celestial body.

What is known about the robot is that it has a laser enclosed in its eye that has multiple intensity levels, and has a target acquisition & locking system.

There are 4 types of living entities that are known: plant, animal, human and superhero

There is only one planet currently known by the robot which is earth.

Each planet can contain 'living' entities, which can be dead or alive


ENUMS:

LivingEntityType
 - plant
 - animal
 - human
 - superhero

LaserIntensity (Enum)
 - off
 - visible
 - kill

INTERFACES

ILivingEntity
 - EntityType
 - IsAlive

CLASSES

Robot:
 - Initialize()
 - Active

KillerRobot(Robot):
 - TargetTypes: list of LivingEntityType
 - TargetPlanet: Planet
 - CurrentTarget: ILivingEntity
 - AcquireNextTarget()
 - DestroyTarget()

GiantKillerRobot(KillerRobot):
 - EyeLaserIntensity: of type LaserIntensity
 - FireLaserAt()

 Planet:
 - Lifeforms: list of ILivingEntity
 - ContainsLife: Any entity.IsAlive in Lifeform

 Planets(Enum of Planet):
  - Earth: Planet
