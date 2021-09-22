using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int timeToWait = 15;

    int currentSceneIndex;
    string currentSceneName;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName.Equals("LoadingScreen"))
        {
            StartCoroutine(WaitForTime());
            
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("StartScreen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
