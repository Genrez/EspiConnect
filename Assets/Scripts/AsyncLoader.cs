using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AsyncLoader : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene("TutorialScene");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    public void LoadVideoScene()
    {
        SceneManager.LoadScene("VideoScene");
    }
}
