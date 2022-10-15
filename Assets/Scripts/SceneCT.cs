using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCT : MonoBehaviour
{

    public void close()
    {
        Application.Quit();
    }

    public static void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

}
