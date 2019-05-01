using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Player_movement : MonoBehaviour {
    NavMeshAgent player_navmesh;
    public int speed;

    Vector3 direction;

    Plane ground;

    private Animator animator;
	// Use this for initialization
	void Start () {
        player_navmesh = gameObject.GetComponent<NavMeshAgent>();

        ground = new Plane(Vector3.up,new Vector3(0, 0.5f, 0) );

        animator = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) ;
        movement *= (speed*Time.deltaTime);
        player_navmesh.Move(movement);

        


       
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance = 0f;
            if (ground.Raycast(ray, out distance))
            {
                 direction = ray.GetPoint(distance);
            }
        

        direction -= transform.position;
        float angle;
        angle = Mathf.Atan2(direction.x,direction.z);
        angle *= (180 / Mathf.PI);
        //angle -= 90;
       
        //Debug.Log(angle);
        transform.rotation = Quaternion.Euler(0,angle,0);

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("isAttacking",true);

        }
        else
        {
            animator.SetBool("isAttacking",false);
        }
    }
}
