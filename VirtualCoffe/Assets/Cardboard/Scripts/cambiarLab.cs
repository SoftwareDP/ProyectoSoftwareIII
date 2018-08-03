using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class cambiarLab : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player"){
			SceneManager.LoadScene("Progreso2");
		}
	}	
}
