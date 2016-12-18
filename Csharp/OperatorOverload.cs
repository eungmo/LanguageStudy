using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    struct POINT { public int x, y; }

    enum General_Weapon { Stone, Rock, Bullet }
    enum Special_Weapon { Cannon, GuidedMissile, Rasor}

    class Robot
    {
        private string m_strName;
        private string m_Color;
        private int m_nEnergy;
        private General_Weapon m_generalW;
        private Special_Weapon m_specialW;
        private POINT m_point;  // current position
        private int m_nPowerUP; // powerup

        private static int nRobotCount = 0; // the number of made robots

        // nRobotCount property
        public static int RobotCount
        {
            get { return nRobotCount; }
        }

        // m_nPowerUP propery
        public int PowerUP
        {
            get { return m_nPowerUP; }
            set
            {
                m_nPowerUP = value;

                // enhance by the weapon
                switch (m_nPowerUP)
                {
                    case 1:
                        m_generalW = General_Weapon.Stone;
                        m_specialW = Special_Weapon.Cannon;
                        break;
                    case 2:
                        m_generalW = General_Weapon.Rock;
                        m_specialW = Special_Weapon.GuidedMissile;
                        break;
                    case 3:
                        m_generalW = General_Weapon.Bullet;
                        m_specialW = Special_Weapon.Rasor;
                        break;
                    default:
                        m_nPowerUP = 1;
                        m_generalW = General_Weapon.Stone;
                        m_specialW = Special_Weapon.Cannon;
                        break;
                }
            }
        }

        public General_Weapon GW
        {
            get { return m_generalW; }
            set
            {
                m_generalW = value;
                m_nEnergy--; // when you change General Weapon, your energe is diminish 1 point.
            }
        }

        public Special_Weapon SW
        {
            get { return m_specialW; }
            set
            {
                m_specialW = value;
                m_nEnergy-=2; // when you change Special Weapon, your energe is diminish 2 point.
            }
        }

        public Robot()
        {
            m_strName = "";
            m_Color = "";
            m_nEnergy = 50;
            m_generalW = General_Weapon.Stone;
            m_specialW = Special_Weapon.Cannon;
            m_point.x = 0;
            m_point.y = 0;
            m_nPowerUP = 1;

            nRobotCount++;  // add the number of made robots.
        }

        public void Go_Ahead() { m_point.x++; }
        public void Go_Back() { m_point.x--; }
        public void Go_Up() { m_point.y++; }
        public void Go_Down() { m_point.y--; }
        public void Shoot_GW() { Console.WriteLine(m_generalW.ToString() + " shoot!"); }
        public void Shoot_SW() { Console.WriteLine(m_specialW.ToString() + " shoot!"); }
        public void Recharge() { m_nEnergy = 100; }
        public int Shoot_DDGW(int n)
        {
            int i;
            for (i=0; i<n; i++)
            {
                Shoot_GW();
            }
            return i;
        }
        public static int printRobotCount()
        {
            Console.WriteLine("Current the number of made robots is " + nRobotCount);
            return nRobotCount;
        }
        /**
         * combine robots
         */
        public static Robot operator +(Robot robot1, Robot robot2)
        {
            int nPowerUp = robot1.PowerUP + robot2.PowerUP;
            // create new robot
            Robot combinedRobot = new Robot();
            combinedRobot.PowerUP = nPowerUp;

            return combinedRobot;
        }
    }

    class OperatorOverload
    {
        public static void Main(string[] args)
        {
            const int NUMOFR = 3;
            Robot[] robots = new Robot[NUMOFR];
            for (int i=0; i<NUMOFR; i++)
            {
                robots[i] = new Robot();
                Console.WriteLine("Robot {0}'s status!! =====================", i);
                Console.WriteLine("Robot {0}'s powerup level : {1}", i, robots[i].PowerUP);
                robots[i].Shoot_GW();
                robots[i].Shoot_SW();
            }

            // combine 2 robots
            Robot combinedRobot1 = robots[0] + robots[1];
            Console.WriteLine("Two robots are combined!!");
            Console.WriteLine("The robot's powerup level : {0}", combinedRobot1.PowerUP);
            combinedRobot1.Shoot_GW();
            combinedRobot1.Shoot_SW();

            // combine 3 robots
            Robot combinedRobot2 = combinedRobot1 + robots[2];
            Console.WriteLine("Three robots are combined!!");
            Console.WriteLine("The robot's powerup level : {0}", combinedRobot2.PowerUP);
            combinedRobot2.Shoot_GW();
            combinedRobot2.Shoot_SW();
        }
    }
}
