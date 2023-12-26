using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public AudioClip[] audioclips;
}

public class AudioManagers : MonoBehaviour
{
    [SerializeField] AudioSource bgmSource;
    [SerializeField] AudioSource sfxSource;

    public static AudioManagers instance = null;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Sound(AudioClip audioClip)
    {
        // 동시에 여러 위치에서 사운드를 호출하는 함수.
        sfxSource.PlayOneShot(audioClip);
    }
}
