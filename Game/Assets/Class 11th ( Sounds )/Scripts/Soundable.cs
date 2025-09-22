using UnityEngine;
using UnityEngine.Audio;

public class Soundable : MonoBehaviour
{
    [SerializeField] AudioClip audioclip;

    private void Start()
    {
        AudioManager.Emit(audioclip);
    }

}
