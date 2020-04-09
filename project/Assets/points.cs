using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    public float timer = 0f;        // timer como float
    public gamecontroller controller;   // gamecontroller definido na variável controller

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;    // timer é a passagem de tempo mesmo
        controller.score.text = timer.ToString("F");        // o text definido no gamecontroller recebe o time como string, formatado como float ("F")
    }
}
