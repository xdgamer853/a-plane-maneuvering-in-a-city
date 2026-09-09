using UnityEngine;
using UnityEngine.Audio;

public class MixrManager : MonoBehaviour
{
    [SerializeField] public AudioMixer Master;

    public void SetSoundFXVolume (float level)
    {
        Master.SetFloat("SoundFx", Mathf.Log10(level) * 20f);
    }
}
