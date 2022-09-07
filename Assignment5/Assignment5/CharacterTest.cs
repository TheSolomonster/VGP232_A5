using NUnit.Framework;

namespace Assignment5
{
    public class CharacterTest
    {
        private Character character;

        [SetUp]
        public void Setup()
        {
            character = new Character("Aidan", RaceCategory.Human, 30);
        }

        [Test]
        public void TakeDamage()
        {
            character.Health = 10;
            character.TakeDamage(20);
            Assert.IsTrue(character.Health <= 0 && character.IsAlive);
        }

        [Test]
        public void RestoreHealth()
        {
            character.Health = 20;
            character.RestoreHealth(10);
            Assert.AreEqual(character.Health, 30);


            character.TakeDamage(300);
            character.RestoreHealth(400);
            Assert.IsTrue(character.IsAlive);
        }
    }
}