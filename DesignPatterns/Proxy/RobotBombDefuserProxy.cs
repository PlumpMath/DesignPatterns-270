namespace Proxy
{
    public class RobotBombDefuserProxy : RobotBombDefuser
    {
        private RobotBombDefuser _robotBombDefuser;
        private int _communicationWaveLength;
        private int _connectionAttempts = 30;

        public RobotBombDefuserProxy(int communicationWaveLength)
        {
            _robotBombDefuser = new RobotBombDefuser();
            _communicationWaveLength = communicationWaveLength;
        }

        public override void WalkStraightForward(int steps)
        {
            EnsureConnectedWithRobot();
            _robotBombDefuser.WalkStraightForward(steps);
        }

        public override void TurnRight()
        {
            EnsureConnectedWithRobot();
            _robotBombDefuser.TurnRight();
        }

        public override void TurnLeft()
        {
            EnsureConnectedWithRobot();
            _robotBombDefuser.TurnLeft();
        }

        public override void DefuseBomb()
        {
            EnsureConnectedWithRobot();
            _robotBombDefuser.DefuseBomb();
        }

        private void EnsureConnectedWithRobot()
        {
            if (_robotBombDefuser == null)
            {
                _robotBombDefuser = new RobotBombDefuser();
                _robotBombDefuser.ConnectWireless(_communicationWaveLength);
            }

            for (int i = 0; i < _connectionAttempts; i++)
            {
                if (_robotBombDefuser.IsConnected() != true)
                {
                    _robotBombDefuser.ConnectWireless(_communicationWaveLength);
                }
                else
                {
                    break;
                }
            }
            if (_robotBombDefuser.IsConnected() != true)
            {
                throw new BadConnectionException("No connection with remote bomb diffuser robot could be made after few attempts.");
            }
        }
    }
}