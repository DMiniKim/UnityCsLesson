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
        DontDestroyOnLoad(gameObject);
    }

    public void LoadCoroutine()
    {
        StartCoroutine(TransitionScene(1));
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
            progress.value += asyncOperation.progress * Time.deltaTime;

            // <AsyncOperation>
            // progress
            // 작업의 진행 상태를 나타내는 변수. (Read Only)

            if (asyncOperation.progress >= 0.9f)
            {
                displayProgress = Mathf.Lerp(progress.value, 1f, Time.deltaTime);

                if (progress.value >= 0.99f)
                {
                    asyncOperation.allowSceneActivation = true;
                    screen.SetActive(false);
                    yield break;
                }
            }

            yield return null;
        }
    }
}
