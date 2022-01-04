using Unity.FPS.Gameplay;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.FPS.Game
{
    public class startmainmenu : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void StartParkour()
        {
            PlayerCharacterController.parkour = true;
            Game.Objective.IsCompleted = true;
            SceneManager.LoadScene("parkour");
            Time.timeScale = 1f;
        }
        public void StartMainScene()
        {
            SceneManager.LoadScene("Demo");
            Time.timeScale = 1f;
            if (GetComponent<PlayerCharacterController>() != null && GetComponent<PlayerCharacterController>().PlayerCamera != null)
            {
                GetComponent<PlayerCharacterController>().PlayerCamera.enabled = true;
            }
            PlayerCharacterController.parkour = false;
            PlayerCharacterController.IsDead = false;
            Game.Objective.IsCompleted = false;
        }

    }
}
