using NUnit.Framework;

namespace Survivor.Tests
{
    public class SurvivorShould
    {
        private Survivor _survivor;

        [SetUp]
        public void Setup()
        {
            _survivor = new Survivor("Courier");
        }
        
        [Test]
        public void StartWithAName()
        {
            Assert.AreEqual("Courier", _survivor.GetName());
        }

        [Test]
        public void StartWithNoWounds()
        {
            Assert.AreEqual(0, _survivor.GetWounds());
        }

        [Test]
        public void StartAlive()
        {
            Assert.IsTrue(_survivor.IsAlive());
        }

        [Test]
        public void DieWithTwoWounds()
        {
            _survivor.ReceiveWound();
            _survivor.ReceiveWound();
            
            Assert.IsFalse(_survivor.IsAlive());
        }

        [Test]
        public void NotReceiveAdditionalWoundsIfDead()
        {
            _survivor.ReceiveWound();
            _survivor.ReceiveWound();
            _survivor.ReceiveWound();
            
            Assert.AreEqual(2, _survivor.GetWounds());
        }

        [Test]
        public void StartWithANumberOfActionsPerTurn()
        {
            Assert.AreEqual(3, _survivor.GetActionPoints());
        }
    }
}
