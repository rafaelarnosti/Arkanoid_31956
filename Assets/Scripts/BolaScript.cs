using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BolaScript : MonoBehaviour
{

    public float velocidade;
    private Rigidbody2D bola;
    public Transform plataforma;
    public float limiteBaixo;
    public int vida;
    public Text txtVidas;
    // Use this for initialization
    void Start()
    {
        bola = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AtiraBola();
        }

        txtVidas.text = "Vidas:" + vida.ToString();

        if (transform.position.y < limiteBaixo)
        {
            transform.position = new Vector2(0.0f, -4.2f);
            plataforma.position = new Vector2(0.0f, -4.57f);
            bola.velocity = Vector2.zero;
            bola.angularVelocity = 0.0f;
            vida--;
            if(vida <= 0)
                SceneManager.LoadScene("TitleScene");
        }
    }

    void AtiraBola()
    {
        bola.AddForce(new Vector2(velocidade, velocidade));
    }

    void OnCollisionEnter2D(Collision2D target)
    {

        if (target.gameObject.tag == "bloco")
        {
            PontosScript.ponto++;
            Destroy(target.gameObject);
            if(PontosScript.ponto >= 18)
                SceneManager.LoadScene("TitleScene");

        }

    }
}
