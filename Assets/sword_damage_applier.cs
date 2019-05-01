using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_damage_applier : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "zombie")
        {
            HP_script enemy_hp = collision.gameObject.GetComponent<HP_script>();
            enemy_hp.get_damage(50);
            Debug.Log("hit " + collision.transform.name);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
