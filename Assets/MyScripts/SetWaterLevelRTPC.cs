using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWaterLevelRTPC : MonoBehaviour
{
    public AK.Wwise.RTPC waterLevelRTPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //causing lag? maybe needs fixed update instead?

        //track the players y pos as the Wwise param for water level
        waterLevelRTPC.SetGlobalValue(transform.position.y);
    }
}
