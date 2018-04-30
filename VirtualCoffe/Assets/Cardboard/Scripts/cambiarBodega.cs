using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class cambiarBodega : MonoBehaviour {


	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player"){
			SceneManager.LoadScene("Bodega");
		}
	}
}
