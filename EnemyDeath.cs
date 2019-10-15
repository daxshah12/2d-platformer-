using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
		Debug.Log("Collider with enemy");
		if (col.gameObject.tag == "Player")
		{
			//Destroy(col.gameObject);
			HUD.health -= 1;
		}
        
    }
}
