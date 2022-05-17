namespace Survivor
{
    public class Survivor
    {
        private readonly string _name;
        private int _wounds = 0;
        private bool _isAlive = true;
        private const int ActionPoints = 3;

        public Survivor(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetWounds()
        {
            return _wounds;
        }

        public bool IsAlive()
        {
            return _isAlive;
        }

        public void ReceiveWound()
        {
            if (!IsAlive()) {return;}
            IncreaseWounds();
            CheckIfDead();
        }

        private void IncreaseWounds()
        {
            _wounds++;
        }

        private void CheckIfDead()
        {
            if (HasReceivedEnoughWoundsToDie())
            {
                Die();
            }
        }

        private bool HasReceivedEnoughWoundsToDie()
        {
            return _wounds >= 2;
        }

        private void Die()
        {
            _isAlive = false;
        }

        public int GetActionPoints()
        {
            return ActionPoints;
        }
    }
}
