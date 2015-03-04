using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

	public   GameObject[]  spawnItems;
	public float spawnTime = 3 ;
	float timer = 0;
	public int randomPosx = 0;
	public int randomPosy = 0;
	// Use this for initialization
	
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time > timer ) {
		var spawn_pos = transform.position;
			spawn_pos.x = spawn_pos.x + Mathf.Round(Random.Range(-randomPosx,randomPosx)) ;
			spawn_pos.y = spawn_pos.y + Mathf.Round(Random.Range(-randomPosy,randomPosy)) ;
			//Debug.Log ("SpanPos: "+spawn_pos);
			var item_index = Random.Range(0,spawnItems.Length);
			var stube = (GameObject)Instantiate(spawnItems[item_index], spawn_pos, transform.rotation);
			//Destroy(stube,6);
			timer = Time.time + spawnTime;
		}
	}
}
