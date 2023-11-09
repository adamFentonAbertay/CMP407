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
    //NavMesh Agent variable
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = transformToFollow.position;
    }
}
