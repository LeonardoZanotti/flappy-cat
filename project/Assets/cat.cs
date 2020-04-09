using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;

    public float RotateUpSpeed = 1, RotateDownSpeed = 1;

    public GameObject gameover;
    public GameObject start;

    // Start is called before the first frame update
    void Start()
    {
        start.SetActive(true);
        Time.timeScale = 0;
        rig = GetComponent<Rigidbody2D>();  // pegar o rigidbody2d do gato
    }

    FlappyYAxisTravelState flappyYAxisTravelState;

        enum FlappyYAxisTravelState
         {
             GoingUp, GoingDown
         }

        Vector3 birdRotation = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {     // se o botão esquerdo (0) for clicado
            rig.velocity = Vector2.up * speed;  // a classe velocity do rigidbody vai sofrer aumento na velocidade na direção do Vector2.up que é pra cima
        }

        if (GetComponent<Rigidbody2D>().velocity.y > 0) flappyYAxisTravelState = FlappyYAxisTravelState.GoingUp;
        else flappyYAxisTravelState = FlappyYAxisTravelState.GoingDown;

        float degreesToAdd = 0;

        switch (flappyYAxisTravelState)
        {
            case FlappyYAxisTravelState.GoingUp:
                degreesToAdd = 6 * RotateUpSpeed;
                break;
            case FlappyYAxisTravelState.GoingDown:
                degreesToAdd = -3 * RotateDownSpeed;
                break;
            default:
                break;
        }
        //solution with negative eulerAngles found here: http://answers.unity3d.com/questions/445191/negative-eular-angles.html

        //clamp the values so that -90<rotation<45 *always*
        birdRotation = new Vector3(0, 0, Mathf.Clamp(birdRotation.z + degreesToAdd, -30, 30));
        transform.eulerAngles = birdRotation;
    }

    void OnTriggerEnter2D(Collider2D colisor) {     // quando o gato bater no colisor em cima ou atrás dele
        Time.timeScale = 0;     // o tempo para de passar
        gameover.SetActive(true);       // mostra a tela de game over
    }
}
