using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Switch : MonoBehaviour
{
    public GameObject[] background;




    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.N) 
            || SteamVR_Actions.default_SnapTurnLeft.GetStateDown(SteamVR_Input_Sources.Any) 
            //|| SteamVR_Actions._default.SnapTurnLeft.GetStateDown(SteamVR_Input_Sources.Any)
            )
            index +=1;


        if (Input.GetKeyDown(KeyCode.M) 
            || SteamVR_Actions.default_SnapTurnRight.GetStateDown(SteamVR_Input_Sources.Any)
            //|| SteamVR_Actions._default.SnapTurnRight.GetStateDown(SteamVR_Input_Sources.Any)
            )
            index-=1;

        if (index > background.Length)
        {
            index = background.Length-1;
        }


        if (index < 0)
        {
            index = 0;
        }
        

        for(int i = 0; i< background.Length; i ++)
        {
            background[i].SetActive(false);
        }
        background[index].SetActive(true);
    }
}
