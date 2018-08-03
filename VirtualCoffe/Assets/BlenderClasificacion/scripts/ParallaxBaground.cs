using UnityEngine;
using System.Collections;

public class ParallaxBaground : MonoBehaviour {

	public Renderer[] capas;
	public float[] speed;
	public bool scrollActivado = true;
	public float offset=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (scrollActivado)
        {
            for (int i = 0; i < capas.Length; i++)
            {
                if (speed[i] != 0)//el > 0 es en nuestro sentido, el < 0 es en sentido contrario
                {
                    offset = Time.time;//metemos time.time porque es un valor que va a ir cambiando constantemente y como la textura es ciclica, nos vale perfectamente
                    float elementOffset = offset * speed[i];
                    capas[i].material.mainTextureOffset = new Vector2(elementOffset, 0);
                }
            }
        }
	}
}
