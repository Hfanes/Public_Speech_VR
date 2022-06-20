using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microfone : MonoBehaviour
{
    private AudioClip microphoneClip;
    public bool _UseMicrophone;
    public GameObject speaker;


    private void Start()
    {
        AudioSource microAudioSource = speaker.GetComponent<AudioSource>();
        //Microfone();
        foreach (var device in Microphone.devices)
        {
            Debug.Log(device);
        }

        if(_UseMicrophone)
        {
            if(Microphone.devices.Length >0)
            {
                string microfoneName = Microphone.devices[0];
                microphoneClip = Microphone.Start(microfoneName, true, 20, AudioSettings.outputSampleRate);
                microAudioSource.clip = microphoneClip;
                microAudioSource.loop = true;
                microAudioSource.Play();
            }
            else
            {
                _UseMicrophone = false;
            }
        }
    }
}


