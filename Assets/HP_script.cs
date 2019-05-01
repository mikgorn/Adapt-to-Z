using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_script : MonoBehaviour {
    public int max_hp;
    public int hp;

    public GameObject hp_bar_prefab;
	// Use this for initialization
	void Start () {
        hp = max_hp;


	}
    
    public void get_damage(int damage)
    {
        hp -= damage;
    }
	// Update is called once per frame
	void Update () {
		if (hp <= 0)
        {
            Destroy(gameObject);
        }
	}
}
