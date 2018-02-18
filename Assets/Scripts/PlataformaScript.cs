using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaScript : MonoBehaviour {

    public float velocidade;
    public GameObject bola;
    public float limiteEsquerdo, limiteDireito;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float move_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;

        transform.Translate(move_x, 0.0f, 0.0f);

        if (transform.position.x < limiteEsquerdo || transform.position.x > limiteDireito)
        {
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
        }

    }
}
