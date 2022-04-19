using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public void ExitButton()
    {
        SceneManager.LoadScene("MenuScreen");
    }
}
