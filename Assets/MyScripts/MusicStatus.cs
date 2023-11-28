using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStatus : MonoBehaviour
{
    // Start is called before the first frame update

    public TriggerController.TriggerTypes currentType;
    void Start()
    {
        
    }

    public void typeChange(TriggerController.TriggerTypes typeToSet)
    {
        currentType = typeToSet;
 

        Debug.Log("new biome type set: " + currentType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
