using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButtons : MonoBehaviour
{
    public GameObject canvasMenuEscolha;

    public GameObject DiapositivosJogos;
    public GameObject DiapositivosIA;
    public GameObject DiapositivosBurnout;




    // Start is called before the first frame update
    void Start()
    {
        canvasMenuEscolha.SetActive(true);
        DiapositivosJogos.SetActive(false);
        DiapositivosIA.SetActive(false);
        DiapositivosBurnout.SetActive(false);
    }
    public void VideoJogos()
    {
        canvasMenuEscolha.SetActive(false);
        DiapositivosJogos.SetActive(true);

    }

    public void IA()
    {
        canvasMenuEscolha.SetActive(false);
        DiapositivosIA.SetActive(true);

    }

    public void Burnout()
    {
        canvasMenuEscolha.SetActive(false);
        DiapositivosBurnout.SetActive(true);

    }
}
