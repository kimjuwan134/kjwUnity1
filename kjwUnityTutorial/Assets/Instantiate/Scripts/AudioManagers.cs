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
        // ���ÿ� ���� ��ġ���� ���带 ȣ���ϴ� �Լ�.
        sfxSource.PlayOneShot(audioClip);
    }
}
