using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string Nome;
    [SerializeField] private string PainelMenuIniciar;
    public void Jogar()
    {
        SceneManager.LoadScene("Jogo");
    }
}
