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

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level4");
    }
}
