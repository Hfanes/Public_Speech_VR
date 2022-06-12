using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class somIntroducao : MonoBehaviour
{
    private AudioSource source;
    private bool finnished = false; 

    void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine(WaitBeforePlayingSound());
        Invoke("audioFinished", source.clip.length);
    }


    void audioFinished()
    {
        Debug.Log("acabou");
        finnished = true;
        Debug.Log(finnished);


        SceneManager.LoadScene("Apresentacao");


    }

    IEnumerator WaitBeforePlayingSound()
    {
        yield return new WaitForSeconds(2);
        source.Play();
    }



}
