using UnityEngine;
using System.Collections;

public class fuerzaItemScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		salud = salud - 300;
		animation.SetInteger ("vida",salud);
}
}
