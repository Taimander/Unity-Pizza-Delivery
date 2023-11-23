using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBtnListener : MonoBehaviour
{
    public void PlayButtonClick() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void ExitButtonClick() {
        Application.Quit();
    }

}
