using System;
using System.Collections;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneryManager : MonoBehaviour
{
    [SerializeField] GameObject screen;
    [SerializeField] Slider progress;
    [SerializeField] float displayProgress;
    private void Awake()
    {
        var objects = FindObjectsByType<SceneryManager>(FindObjectsSortMode.None);
        if (objects.Length > 1)
        {
            Destroy(gameObject);
            return;
        }        
        DontDestroyOnLoad(gameObject);
    }

    
    public IEnumerator TransitionScene(int index)
    {
        progress.value = 0;
        displayProgress = 0f;

        screen.SetActive(true);
        // <AsyncOperation>
        // allowSceneActivation
        // 장면이 준비된 즉시 장면이 활성화되는 것을 허용하는 변수.

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);

        asyncOperation.allowSceneActivation = false;

        // <AsyncOperation>
        // isDone
        // 해당 종작이 완료되었는지 나타내는 변수. (Read Only)

        while (asyncOperation.isDone == false)
        {
            displayProgress = Mathf.Lerp(displayProgress, asyncOperation.progress, Time.deltaTime);

            // <AsyncOperation>
            // progress
            // 작업의 진행 상태를 나타내는 변수. (Read Only)

            if (asyncOperation.progress >= 0.9f)
            {
                displayProgress = Mathf.MoveTowards(displayProgress, 1.0f, Time.deltaTime);

                if (progress.value >= 0.99f)
                {
                    asyncOperation.allowSceneActivation = true;
                }
            }
            progress.value = displayProgress;

            yield return null;

        }
        screen.SetActive(false);
    }
    
    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }
    public void StartButton()
    {
        StartCoroutine(TransitionScene(1));
    }
}
