using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class SelectButtons : MonoBehaviour
{
    public GameObject canvasMenuEscolha;

    public GameObject DiapositivosJogos;
    public GameObject DiapositivosIA;
    public GameObject DiapositivosBurnout;

    public GameObject DiapositivosJogosFrente;
    public GameObject DiapositivosIAFrente;
    public GameObject DiapositivosBurnoutFrente;

    public GameObject _playerleftHand;



    // Start is called before the first frame update
    void Start()
    {
        canvasMenuEscolha.SetActive(true);
        DiapositivosJogos.SetActive(false);
        DiapositivosIA.SetActive(false);
        DiapositivosBurnout.SetActive(false);
        DiapositivosJogosFrente.SetActive(false);
        DiapositivosIAFrente.SetActive(false);
        DiapositivosBurnoutFrente.SetActive(false);

    }
    public void VideoJogos()
    {
        canvasMenuEscolha.SetActive(false);
        DiapositivosJogos.SetActive(true);
        DiapositivosJogosFrente.SetActive(true);
        _playerleftHand.GetComponent<SteamVR_LaserPointer>().enabled = false;


    }

    public void IA()
    {
        canvasMenuEscolha.SetActive(false);
        DiapositivosIA.SetActive(true);
        DiapositivosIAFrente.SetActive(true);
        _playerleftHand.GetComponent<SteamVR_LaserPointer>().enabled = false;


    }

    public void Burnout()
    {
        canvasMenuEscolha.SetActive(false);
        DiapositivosBurnout.SetActive(true);
        DiapositivosBurnoutFrente.SetActive(true);
        _playerleftHand.GetComponent<SteamVR_LaserPointer>().enabled = false;

    }
}
