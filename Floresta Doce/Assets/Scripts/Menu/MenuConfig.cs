using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string SceneName;
    public TMP_Dropdown graphicsDropDown;
    public void QuitGame()
    {
        //Mudar para quando for ser uma build msm// 

        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void ChangeToGame()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void ChangeQuality()
    {
        QualitySettings.SetQualityLevel(graphicsDropDown.value);
    }
}
