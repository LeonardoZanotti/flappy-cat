using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap : MonoBehaviour
{
    public GameObject click;        // gameobject do tap

    private float timer = 0f;    // timer

    // Update is called once per frame
    void Update()
    {
        if(timer > 2.5) {   // contador de tempo pra deixar só 2.5s o tap na tela
            click.SetActive(false);     // desativa o tap após os 2.5 segundos
            timer = 0;                  // reinicia o timer
        }

        timer += Time.deltaTime;        // timer é o tempo real mesmo
    }
}
