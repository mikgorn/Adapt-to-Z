using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_move : MonoBehaviour {

    [SerializeField]
    Vector3 _destination;

    NavMeshAgent _navMeshAgent;

    public Transform player;
	void Start () {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        if (_navMeshAgent == null)
        {
            Debug.Log("Nav Mesh component is not attached");
        }
        
	}

    private void SetDestination()
    {
        
        
            _navMeshAgent.SetDestination(_destination);
        
    }

    // Update is called once per frame
    void Update () {
        Vector3 player_coords = transform.position - player.transform.position;
        if (player_coords.magnitude <= 5)
        {
            
            _destination = player.transform.position;
            SetDestination();
        }
       
    }
}
