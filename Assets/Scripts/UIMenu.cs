using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        EditorApplication.Exit(0);
    }
}
