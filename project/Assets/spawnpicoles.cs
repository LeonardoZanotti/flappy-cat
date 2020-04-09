using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpicoles : MonoBehaviour
{
    public GameObject picole;   // gameobject picole
    public float height = 1.3f;        // altura dos canos
    public float maxtime = 5f;      // vai fazer os picoles spawnarem a cada 1 segundo
    public float maxtime2 = 10f;

    private float timer = 0f;       // usar o f depois do valor é para definir que é float mesmo, se n, podia interpretar como double ou decimal
    private float timer2 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newpicole = Instantiate(picole);     // cria cópias do gameobject picole
        newpicole.transform.position += new Vector3(0, Random.Range(-height, height), 0);     // as posições desse novo objeto newpicole (transform.position) vai ser a posição inicial do primeiro conjunto de picoles (transform.position daquele gameobject picoles lá da unity) mais uma variação no eixo y entre mais height ou menos height (Random.Range sorteia um valor entre +height e - height), sendo que nada muda no eixo x e z
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxtime) {       // se o timer for maior que o tempo máximo definido, outro picole vai spawnar
            GameObject newpicole = Instantiate(picole);     // cria cópias do gameobject picole
            newpicole.transform.position += new Vector3(0, Random.Range(-height, height), 0);     // as posições desse novo objeto newpicole (transform.position) vai ser a posição inicial do primeiro conjunto de picoles (transform.position daquele gameobject picoles lá da unity) mais uma variação no eixo y entre mais height ou menos height (Random.Range sorteia um valor entre +height e - height), sendo que nada muda no eixo x e z
            Destroy(newpicole, 20f);      // depois de 20 segundos o picolé é destruido pra n sobrecarregar o jogo
            timer = 0;  // reiniciar o timer
        }

        timer += Time.deltaTime;    // função que calcula o tempo que passou, então a cada novo loading o timer vai sendo atualizado em tempo real

        if(timer2 > maxtime2) {     // quando timer2 contar 5 segundos (maxtimer2)
            maxtime -= 0.1f;        // maxtime de spawn de picole diminui 0.1s
            maxtime2 += 2;          // maxtime2 pra contar isso aumenta 2 segundos
            height += 0.02f;         // altura vai aumentando, então os picoles vem com alturas mais variadas          
            timer2 = 0;             // reiniciar o timer2
        }

        timer2 += Time.deltaTime;   // timer2 é o tempo real 
    }
}
