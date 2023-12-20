using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;

public class UIDamageMusicSync : MonoBehaviour
{
    // Start is called before the first frame update

    public float transparency;
    private Color setTransparency;
    public GameObject player;

    public float fadeRate = 0.7f;
    public float damageUIHealthShow = 50;

    //called through inspector element on player armature > AkAmbient under the callback param on every beat of music
    public void OnMusicBeat()
    {
        //if health low enough set to fully visible
        if (player.GetComponent<ThirdPersonController>().healthPoints < damageUIHealthShow) { 
         setTransparency.a = 1;
            GetComponent<RawImage>().color = setTransparency;
        }
    }
    void Start()
    {
        
        setTransparency = GetComponent<RawImage>().color;
        setTransparency.a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //steadily reduce transparency
        GetComponent<RawImage>().color = setTransparency;

        if (setTransparency.a > 0)
        {
            setTransparency.a -= (fadeRate * Time.deltaTime);
        }
    }
}
