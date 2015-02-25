using UnityEngine;
using System.Collections;

public class Item_vida : MonoBehaviour {


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void OnMouseDown(){

		Destroy (gameObject);	
	}

	void OnDestroy() {
		gameControl.gamecontrol.vidas = gameControl.gamecontrol.vidas +1 ;
		
	}
}
