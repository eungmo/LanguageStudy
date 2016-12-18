using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    enum General_Weapon { Stone, Rock, Bullet }
    enum Special_Weapon { Cannon, GuidedMissile, Rasor }
    enum WeaponMode { General, Special, Both }

    class Robot
    {
        private General_Weapon m_generalW;
        private Special_Weapon m_specialW;
        private WeaponMode m_WeaponMode;

        public delegate int shootDelegate(int n);

        public shootDelegate shoot;

        public General_Weapon GW
        {
            get { return m_generalW; }
            set { m_generalW = value; }
        }

        public Special_Weapon SW
        {
            get { return m_specialW; }
            set { m_specialW = value; }
        }

        public WeaponMode Weapon_Mode
        {
            get { return m_WeaponMode; }
            set
            {
                m_WeaponMode = value;

                if (m_WeaponMode == WeaponMode.General)
                    shoot = new shootDelegate(Shoot_DDGW);
                else if (m_WeaponMode == WeaponMode.Special)
                    shoot = new shootDelegate(Shoot_DDSW);
                else if (m_WeaponMode == WeaponMode.Both)
                    shoot = new shootDelegate(Shoot_DDGW) + new shootDelegate(Shoot_DDSW);
            }
        }

        public Robot()
        {
            Weapon_Mode = WeaponMode.General;
        }

        public void Shoot_GW() { Console.WriteLine(m_generalW.ToString() + " shoot!"); }
        public void Shoot_SW() { Console.WriteLine(m_specialW.ToString() + " shoot!"); }
        public int Shoot_DDGW(int n)
        {
            int i;
            for (i=0; i<n; i++)
            {
                Shoot_GW();
            }
            return i;
        }
        public int Shoot_DDSW(int n)
        {
            int i;
            for (i=0; i<n; i++)
            {
                Shoot_SW();
            }
            return i;
        }
    }

    class DelegateComposition
    {
        public static void Main(string[] args)
        {
            Robot robot = new Robot();
            Console.WriteLine("Current Weapon Mode is {0}", robot.Weapon_Mode);
            robot.shoot(3);
            robot.Weapon_Mode = WeaponMode.Special;
            Console.WriteLine("Current Weapon Mode is {0}", robot.Weapon_Mode);
            robot.shoot(5);
            robot.Weapon_Mode = WeaponMode.Both;
            Console.WriteLine("Current Weapon Mode is {0}", robot.Weapon_Mode);
            robot.shoot(2);
        }
    }
}



