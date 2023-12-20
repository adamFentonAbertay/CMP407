using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStatus : MonoBehaviour
{
    // Start is called before the first frame update

    //enum for biome type - normal, sand, snow
    public TriggerController.TriggerTypes currentType;
  

    public float dangerLevel;
    void Start()
    {
        dangerLevel = 0;
        AkSoundEngine.SetState("PlayerBiome", "Normal");
       
        
        
    }

    //triggered upon contact with trigger with param typetoset
    public void typeChange(TriggerController.TriggerTypes typeToSet)
    {
        currentType = typeToSet;
     
        //set Wwise param PlayerBiome to correct new biome
        Debug.Log("new biome type set: " + currentType);

        if (typeToSet == TriggerController.TriggerTypes.normal)
        {
            AkSoundEngine.SetState("PlayerBiome", "Normal");
        }
        else if(typeToSet == TriggerController.TriggerTypes.sand)
        {
            AkSoundEngine.SetState("PlayerBiome", "Sand");
        }
        else if (typeToSet == TriggerController.TriggerTypes.snow)
        {
            AkSoundEngine.SetState("PlayerBiome", "Snow");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
