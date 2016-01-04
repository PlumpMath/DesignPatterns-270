using System;

namespace Proxy
{
    public class RobotBombDefuser
    {
        private Random _random = new Random();
        private int _robotConfiguredWavelength = 41;
        private bool _isConnected = false;

        public void ConnectWireless(int communicationWaveLength)
        {
            if (communicationWaveLength == _robotConfiguredWavelength)
            {
                _isConnected = IsConnectedImmitatingConnectivitiyIssues();
            }
        }
        public bool IsConnected()
        {
            _isConnected = IsConnectedImmitatingConnectivitiyIssues();
            return _isConnected;
        }
        private bool IsConnectedImmitatingConnectivitiyIssues()
        {
            return true; // immitates 40% good connection, aka. very bad
        }

        public virtual void WalkStraightForward(int steps)
        {
            Console.WriteLine("Did {0} steps forward...", steps);
        }

        public virtual void TurnRight()
        {
            Console.WriteLine("Turned right...");
        }

        public virtual void TurnLeft()
        {
            Console.WriteLine("Turned left...");
        }

        public virtual void DefuseBomb()
        {
            Console.WriteLine("Cut red or green or blue wire...");
        }
    }
}