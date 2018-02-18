using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontosScript : MonoBehaviour {

    public static int ponto;
    public Text txtPontos;


    // Use this for initialization
    void Start () {
        ponto = 0;
        txtPontos.text = "Pontos:" + ponto.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        txtPontos.text = "Pontos:" + ponto.ToString();
    }
}
