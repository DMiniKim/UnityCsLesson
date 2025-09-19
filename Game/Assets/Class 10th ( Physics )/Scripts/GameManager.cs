using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int allScore;

    private void Awake()
    {
        allScore = 0;
    }
    public void AddScore()
    {
        allScore++;
    }
    public void ShowScore()
    {
        Debug.Log("Score: " + allScore);
    }

}
