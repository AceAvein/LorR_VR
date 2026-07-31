using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreenController : MonoBehaviour
{
    public float displayDuration = 2f;
    public string nextSceneName = "01_ProfileSelection";

    void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(displayDuration);
        SceneManager.LoadScene(nextSceneName);
    }
}