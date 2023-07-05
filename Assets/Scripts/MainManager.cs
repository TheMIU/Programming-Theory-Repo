using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public void StartOnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void BackOnClick()
    {
        SceneManager.LoadScene(0);
    }
}
