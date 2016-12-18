using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    // Robot Message Parameter
    class RobotMessageEventArgs : EventArgs
    {
        public string strMessage;

        public RobotMessageEventArgs(string strMessage)
        {
            this.strMessage = strMessage;
        }
    }

    class Robot
    {
        public delegate void requestRepairEventHandler(object source, RobotMessageEventArgs e);

        public event requestRepairEventHandler OnRequestRepairEventHandler;

        public Robot() { }
        
        /**
         * if robot is damaged
         */
        public void onDamaged()
        {
            Console.WriteLine("Robot: robot is demaged.");

            RobotMessageEventArgs e = new RobotMessageEventArgs("Dr. kim, Please repair me.");
            OnRequestRepairEventHandler(this, e);

            Console.WriteLine("Robot: I asked Dr. Kim for repair");
        }

        public void checkNRepair()
        {
            Console.WriteLine("Robot: The repair is completed.");
        }
    }

    class Dr_Kim
    {
        public static void RemoteRepair(object obj, RobotMessageEventArgs e)
        {
            if(e.strMessage == "Dr. kim, Please repair me.")
            {
                Console.WriteLine("Dr. Kim: I get repair request from robot.");

                // get robot instance
                Robot robot = (Robot)obj;

                Console.WriteLine("Dr. Kim: I'm repairing the robot.");
                robot.checkNRepair();
            }
        }
    }

    class Event
    {
        public static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.OnRequestRepairEventHandler += new Robot.requestRepairEventHandler(Dr_Kim.RemoteRepair);
            robot.onDamaged();
        }
    }
}



