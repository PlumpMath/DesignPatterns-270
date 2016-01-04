using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyDemo
    {
        public static void Main()
        {
            int opNum = 0;
            try
            {
                var proxy = new RobotBombDefuserProxy(41);
                proxy.WalkStraightForward(100);
                opNum++;
                proxy.TurnRight();
                opNum++;
                proxy.WalkStraightForward(5);
                opNum++;
                proxy.DefuseBomb();
                opNum++;

                Console.WriteLine();
            }
            catch (BadConnectionException e)
            {
                Console.WriteLine("Exception has been caught with message: ({0}). Decided to have human operate robot there.", e.Message);

                PlanB(opNum);
            }
        }

        private static void PlanB(int nextOperationNum)
        {
            RobotBombDefuser humanOperatingRobotDirectly = new RobotBombDefuser();

            if (nextOperationNum == 0)
            {
                humanOperatingRobotDirectly.WalkStraightForward(100);
                nextOperationNum++;
            }
            if (nextOperationNum == 1)
            {
                humanOperatingRobotDirectly.TurnRight();
                nextOperationNum++;
            }
            if (nextOperationNum == 2)
            {
                humanOperatingRobotDirectly.WalkStraightForward(5);
                nextOperationNum++;
            }
            if (nextOperationNum == 3)
            {
                humanOperatingRobotDirectly.DefuseBomb();
            }
        }
    }
}
