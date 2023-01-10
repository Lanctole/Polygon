using Polygon;

namespace Tests
{
    [TestFixture]
    public class WorldTests
    {
        [Test]
        public void OnCharacterLeveledUp_WorldLevelsUp()
        {
            Character character = new Character();
            int initialWorldLevel = World.Level;
            character.IncreaseExperience(character.LevelUpThreshold);
            Assert.That(World.Level, Is.EqualTo(initialWorldLevel + 1));
        }

        [Test]
        public void OnCharacterLeveledUp_CharacterNotLevelsUp_WorldNotLevelsUp()
        {
            Character character = new Character();
            int initialWorldLevel = World.Level;
            character.IncreaseExperience(character.LevelUpThreshold - 1);
            Assert.That(World.Level, Is.EqualTo(initialWorldLevel));
        }

    }
}
