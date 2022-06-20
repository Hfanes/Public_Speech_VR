using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundrandomizer : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine(RandomNoise());
    }

    IEnumerator RandomNoise()
    {
        while (true)
        {
            int index = Random.Range(0, 5);
            source.PlayOneShot(sounds[index]);
            yield return new WaitUntil(() => !source.isPlaying);
            yield return new WaitForSeconds(Random.Range(0f,5f));
        }
    }
}
