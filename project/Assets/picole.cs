using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picole : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;    // posição dos picoles é a deles mesmo mais um vetor para a esquerda com a velocidade speed e uma variação no tempo pra suavizar o movimento
    }
}
