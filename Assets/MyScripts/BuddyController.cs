using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BuddyController : MonoBehaviour
{
    // Start is called before the first frame update
    //https://www.sharpcoderblog.com/blog/npc-follow-player-in-unity-3d

    //Transform that NPC has to follow
    public Transform transformToFollow;

    public float velocityThreshtoPlay = 5;

    [Tooltip("For playing WWISE footstep on footstep func trigger")]
    public AK.Wwise.Event movingBuddySfx;
    public AK.Wwise.Event stoppingMovingBuddySfx;
    private Vector3 positionCurrent;
    private Vector3 positionLast;

    private bool isInitialPlay = true;
    //NavMesh Agent variable
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        positionCurrent = transform.position;
        positionLast = transform.position;
    }

 

    // Update is called once per frame
    void Update()
    {
        //navmesh stuff
        positionLast = positionCurrent;
        positionCurrent = transform.position;
        agent.destination = transformToFollow.position;


        //if is moving and is first update since stopped
        if (positionCurrent != positionLast && isInitialPlay == true)
        {
            //begin looping buddy moving sound
            isInitialPlay = false;
            Debug.Log("buddy move loop");
            AkSoundEngine.PostEvent(movingBuddySfx.Id, gameObject);
        }
        //if is not moving and is first update since was moving
        if (positionCurrent == positionLast && isInitialPlay == false) {
            //stop looping buddy moving sound
            Debug.Log("stop buddy movie loop");
            isInitialPlay = true;
            AkSoundEngine.PostEvent(stoppingMovingBuddySfx.Id, gameObject);
        }
        
        positionLast = positionCurrent;
    }
}
