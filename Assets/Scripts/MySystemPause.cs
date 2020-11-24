using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySystemPause : MonoBehaviour
{
    public static bool gameIsPaused;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            gameIsPaused = !gameIsPaused;
            Pause();
        }

        void Pause()
        {
            if (gameIsPaused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}

