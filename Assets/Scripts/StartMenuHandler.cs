using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuHandler : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        StartCoroutine(LoadGameScene());
    }

    public IEnumerator LoadGameScene()
    {
        AsyncOperation sceneLoading = SceneManager.LoadSceneAsync(SceneName);

        // Wait while we load the game scene
        while (!sceneLoading.isDone)
        {
            // This is where you could put a loading screen UI!
            yield return null;
        }
    }
}
