using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        // Bike controlled by player
        public Bike m_PlayerBike;

        // Bike controlled by an android (AI)
        public Bike m_AndroidBike;

        // Bike controlled by an vampire (AI)
        public Bike m_VampireBike;

        // Bike controlled by a monster (AI)
        public Bike m_MonsterBike;

        void Awake()
        {
            // Set up a bike with a human driver and jet engine
            IEngine jetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();

            m_PlayerBike.SetEngine(jetEngine);
            m_PlayerBike.SetDriver(humanDriver);
            m_PlayerBike.StartEngine();

            // Set up a bike with an AI driver and a nitro engine
            IEngine nitroEngine = new NitroEngine();
            IDriver androidDriver = new AndroidDriver();

            m_AndroidBike.SetEngine(nitroEngine);
            m_AndroidBike.SetDriver(androidDriver);
            m_AndroidBike.StartEngine();

            // Set up a bike with an AI vampire and a gear engine
            IEngine gearEngine = new GearEngine();
            IDriver vampireDriver = new VampireDriver();

            m_VampireBike.SetEngine(gearEngine);
            m_VampireBike.SetDriver(vampireDriver);
            m_VampireBike.StartEngine();

            // Set up a bike with an AI monster and a monster engine
            IEngine monsterEngine = new MonsterEngine();
            IDriver monsterDriver = new MonsterDriver();

            m_MonsterBike.SetEngine(monsterEngine);
            m_MonsterBike.SetDriver(monsterDriver);
            m_MonsterBike.StartEngine();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_PlayerBike.TurnLeft();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                m_PlayerBike.TurnRight();
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
            GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console");
        }
    }
}


