using Polygon;

namespace Tests
{
    [TestFixture]
    public class CharacterTests
    {
        [TestCase(50)]
        [TestCase(0)]
        [TestCase(1)]
        public void IncreaseExperience_ValidAmount_ExperienceIncreased(int amount)
        {
            Character character = new Character();
            int initialExperience = character.Experience;
            character.IncreaseExperience(amount);
            Assert.That(character.Experience, Is.EqualTo(initialExperience + amount));
        }

        [TestCase(50)]
        [TestCase(0)]
        [TestCase(1)]
        public void DecreaseExperience_ValidAmount_ExperienceDecreased(int amount)
        {
            Character character = new Character();
            int initialExperience = character.Experience;
            character.DecreaseExperience(amount);
            Assert.That(character.Experience, Is.EqualTo(initialExperience - amount));
        }

        [Test]
        public void IncreaseExperience_LevelUpThresholdReached_LevelIncreased()
        {
            Character character = new Character();
            int initialLevel = character.Level;
            int amount = character.LevelUpThreshold;
            character.IncreaseExperience(amount);
            Assert.That(character.Level, Is.EqualTo(initialLevel + 1));
        }

        [TestCase(400)]
        [TestCase(800)]
        [TestCase(32000)]
        public void IncreaseExperience_LevelUp_TooManyExperienceGeted(int amount)
        {
            Character character = new Character();
            int initialLevel = character.Level;
            character.IncreaseExperience(amount);
            Assert.That(character.Level, Is.EqualTo( (int)Math.Log2(amount/100)));
        }

        [Test]
        public void IncreaseExperience_LevelUpThresholdReached_ExperienceReset()
        {
            Character character = new Character();
            int amount = character.LevelUpThreshold;
            character.IncreaseExperience(amount);
            Assert.That(character.Experience, Is.EqualTo(0));
        }

        [TestCase(-50)]
        public void IncreaseExperience_InvalidAmount_ThrowsArgumentException(int amount)
        {
            Character character = new Character();
            Assert.That(() => character.IncreaseExperience(amount), Throws.ArgumentException);
        }

        [TestCase(-50)]
        public void DecreaseExperience_InvalidAmount_ThrowsArgumentException(int amount)
        {
            Character character = new Character();
            Assert.That(() => character.DecreaseExperience(amount), Throws.ArgumentException);
        }
    }

}