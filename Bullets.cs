using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {

	private float timer;

	void Update()
    { 
	timer += 1.0f * Time.deltaTime;

		if (timer >= 2.0f)
		{
			GameObject.Destroy(gameObject);
		}
	}
	private void OnCollisionEnter2D(Collision2D col)
	{
		
		if (col.gameObject.tag == "Enemy")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
		}

	}
}
