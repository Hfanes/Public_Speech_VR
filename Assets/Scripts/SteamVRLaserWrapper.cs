using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR.Extras;

public class SteamVRLaserWrapper : MonoBehaviour
{
    [SerializeField] private SteamVR_LaserPointer steamVrLaserPointer;

    //public static GameObject CanvasTema;

    //SelectButtons selectButtons;


    //public void Initialize()
    //{
    //    selectButtons = GetComponentInChildren<SelectButtons>();
    //}

    public void Start()
    {
        //steamVrLaserPointer = gameObject.GetComponent<SteamVR_LaserPointer>();
        //steamVrLaserPointer.PointerIn += OnPointerIn;
        //steamVrLaserPointer.PointerOut += OnPointerOut;
        steamVrLaserPointer.PointerClick += OnPointerClick;
    }


    public void OnPointerClick(object sender, PointerEventArgs e)
    {
        IPointerClickHandler clickHandler = e.target.GetComponent<IPointerClickHandler>();
        if (clickHandler == null)
        {
            return;
        }

        //if(e.target.gameObject.name =="Jogos")
        //{
        //    selectButtons.VideoJogos();
        //}




        clickHandler.OnPointerClick(new PointerEventData(EventSystem.current));
    }


















    private void OnPointerOut(object sender, PointerEventArgs e)
    {
        IPointerExitHandler pointerExitHandler = e.target.GetComponent<IPointerExitHandler>();
        if (pointerExitHandler == null)
        {
            return;
        }

        pointerExitHandler.OnPointerExit(new PointerEventData(EventSystem.current));
    }

    private void OnPointerIn(object sender, PointerEventArgs e)
    {
        IPointerEnterHandler pointerEnterHandler = e.target.GetComponent<IPointerEnterHandler>();
        if (pointerEnterHandler == null)
        {
            return;
        }

        pointerEnterHandler.OnPointerEnter(new PointerEventData(EventSystem.current));
    }
}