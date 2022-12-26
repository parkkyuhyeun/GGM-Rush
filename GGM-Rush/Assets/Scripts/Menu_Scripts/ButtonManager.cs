using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject guidePanel;
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void GuideButton()
    {
        guidePanel.SetActive(!guidePanel.gameObject.activeSelf);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
