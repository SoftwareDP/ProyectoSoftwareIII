using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class cambiarBodega : MonoBehaviour {
    private GameObject ob1;
    private GameObject ob2;
    private GameObject ob3;
    private GameObject ob4;
 	private bool bandera=false;

 
	void OnTriggerEnter(Collider other) {
		ob1=GameObject.Find("obstaculo1");
		ob2=GameObject.Find("obstaculo2");
		ob3=GameObject.Find("obstaculo1");
		ob4=GameObject.Find("obstaculo2");

		if(other.tag == "Player" && ob1==null && 
			ob2==null && ob3==null && ob4==null){
			SceneManager.LoadScene("Progreso1");
		}
	}
}
