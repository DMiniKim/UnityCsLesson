using Microsoft.Win32.SafeHandles;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] static AudioSource audioSource;

    private void Awake()
    {
        if (audioSource != null) return;
        audioSource = GetComponent<AudioSource>();
    }


    public static void Emit(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
    static void Create(AudioClip audioClip , Transform point)
    {
        
    }
}
