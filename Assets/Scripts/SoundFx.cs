using UnityEngine;

public class SoundFx : MonoBehaviour
{
    public static SoundFx Instance;
    [SerializeField] private AudioSource SoundFxObject;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void spawnsoundfx(AudioClip audioClip,Transform transform, float volume)
    {
        //instantiate
        AudioSource audioSource = Instantiate(SoundFxObject, transform.position, Quaternion.identity);

        audioSource.clip = audioClip;
        audioSource.volume = volume;
        audioSource.Play();

        float clipLength = audioSource.clip.length;

        Destroy(audioSource.gameObject, clipLength);
        
    }
}
