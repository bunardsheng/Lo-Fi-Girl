using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance { get; private set; }

    private AudioSource source;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
        
    }

    public void PlaySound(AudioClip sound)
    {
        source.PlayOneShot(sound);
    }
}
