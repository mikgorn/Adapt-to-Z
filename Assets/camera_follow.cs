using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {
    public Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 new_pos = player.position;
        new_pos.y = 15;
        new_pos.z -= 6;
        transform.position = new_pos;
	}
}
