using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class parkourBool : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }
        public void whenRestart()
        {

            PlayerCharacterController.parkour = false;
            Game.Objective.IsCompleted = false;
        }
        // Update is called once per frame
        void Update()
        {

        }
    }

}