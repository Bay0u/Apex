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
        public void StartMainScene()
        {
            SceneManager.LoadScene("MainScene");
            Time.timeScale = 1f;
        }
    }
}
