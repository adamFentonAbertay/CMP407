using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TriggerController : MonoBehaviour
{

    public enum TriggerTypes { normal, sand, snow, normalCombat };

    public TriggerTypes triggerOrignal;
    public TriggerTypes triggerNew;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
       
        if (other.GetComponent<MusicStatus>())
        {
            if (other.GetComponent<MusicStatus>().currentType == triggerOrignal)
            {
                //entered triggerNew biome
                other.GetComponent<MusicStatus>().typeChange(triggerNew);
            }
            else if (other.GetComponent<MusicStatus>().currentType == triggerNew)
            {
                other.GetComponent<MusicStatus>().typeChange(triggerOrignal);
            }

            else
            {
                Debug.Log("type change error");
            }

        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
