using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour
{
    public GameObject start;        // gameobject start
    public GameObject gameover;     // gameobject gameover
    public GameObject pause;        // botão de pause
    public GameObject play;         // botão de play
    public Text score;              // text score pra marcar os pontos

    public void RestartGame() {     // botão de reiniciar o game
        SceneManager.LoadScene(0);      // carrega a cena 0 -> só há uma cena no game que fica na posição 0
        Time.timeScale = 0;     // para o tempo
    }

    public void StartGame() {       // se clicar pra startar
        start.SetActive(false);     // desativa o menu de start
        Time.timeScale = 1;         // tempo volta a passar
    }

    public void pauseGame() {       // se apertar pra pausar
        if(!start.activeSelf && !gameover.activeSelf) {     // se o gameobject start e o gameobject gameover não estiverem ativos
            play.SetActive(true);       // mostra o botão play
            pause.SetActive(false);     // oculta o de pausar
            Time.timeScale = 0;         // para o tempo
        }
    }

    public void playGame() {        // se apertar o do play
        if(!start.activeSelf && !gameover.activeSelf) {     // se o gameobject start e o gameobject gameover não estiverem ativos
            play.SetActive(false);      // oculta o botão de play
            pause.SetActive(true);      // mostra o de pauser
            Time.timeScale = 1;         // tempo volta a passar normalmente
        }
    }
}
