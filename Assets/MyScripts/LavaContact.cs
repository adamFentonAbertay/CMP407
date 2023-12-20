using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;


public class LavaContact : MonoBehaviour
{
    private float passedFromLastDamage = 0;
  
    public int damagePerSec = 5;
    public float DamageTickTime = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        passedFromLastDamage += Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {

        
 
    }


    private void OnTriggerStay(Collider other)
    {
        // if enough time passed since last sent damage
        if (passedFromLastDamage > DamageTickTime)
        {
            //if other collider is the player
        
            if (other.GetComponent<ThirdPersonController>())
            {
               //reduce players health by damagePerSec
                other.GetComponent<ThirdPersonController>().reducePlayerHealth(damagePerSec);
                passedFromLastDamage = 0;
                
            }
        }
    }
}