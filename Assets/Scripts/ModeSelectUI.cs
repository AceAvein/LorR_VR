using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelectUI : MonoBehaviour
{
    public void OnBackClicked()
    {
        SceneManager.LoadScene("02_MainMenu");
    }
}