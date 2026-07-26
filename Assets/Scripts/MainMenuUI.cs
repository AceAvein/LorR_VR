using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void OnExitClicked()
    {
        SceneManager.LoadScene("01_ProfileSelection");
    }

    public void OnStartClicked()
    {
        // dagdag mo dito kung saan dapat pumunta ang "Start!" button
    }

    public void OnProgressClicked()
    {
        // dagdag mo dito kung saan dapat pumunta ang "Progress" button
    }

    public void OnSettingsClicked()
    {
        // dagdag mo dito kung saan dapat pumunta ang "Settings" button
    }

    public void OnTutorialClicked()
    {
        // dagdag mo dito kung saan dapat pumunta ang "Tutorial" button
    }
}