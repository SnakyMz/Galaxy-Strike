using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameSceneManager : MonoBehaviour
{
    public void ReloadLevel()
    {
        StartCoroutine(ReloadSceneRoutine());
    }

    IEnumerator ReloadSceneRoutine()
    {
        yield return new WaitForSeconds(1f);

        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex);
    }
}
