using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class cubo : MonoBehaviour {
  public GameObject original;
  private bool bandera=false;

  public void banderaTrue() {
    bandera=true;
  }

  public void banderafalse(){
  	bandera=false;
  }

  public void Update(){
  	float valor=Input.GetAxis("boton");
      if( bandera && valor != 0){
        Destroy(original);
      }
  }
}
    