using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscolherTema : MonoBehaviour
{

    public GameObject CanvasTemas;

    // Start is called before the first frame update
    void Start()
    {
        CanvasTemas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VideoJogos()
    {
        CanvasTemas.SetActive(false);
    }

    public void InteligenciaArtificial()
    {
        CanvasTemas.SetActive(false);
    }

    public void BurnoutFaculdade()
    {
        CanvasTemas.SetActive(false);
    }
}
