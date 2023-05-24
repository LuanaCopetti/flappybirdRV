using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalMananger : MonoBehaviour
{
    private string nomedoLevelDeJogo;
    [SerializeField] private string nomeDoLevelDoJogo;
    [SerializeField] private GameObject painelMenuInicial;
   public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDoJogo);
    }
    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
