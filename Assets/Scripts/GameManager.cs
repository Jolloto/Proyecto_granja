using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private UI_Manager uiManager;
    private bool isPausa;
    public int animalesgordosnum;
    

    void Start()
    {
        uiManager.ShowPausaPanel();
        uiManager.ShowMenuPanel();
        uiManager.HideGameOverPanel();
        Time.timeScale = 0f;
    }

    private void Awake()
    {
        uiManager = FindObjectOfType<UI_Manager>();
        uiManager.HidePausaPanel();
        uiManager.HideMenuPanel();
        uiManager.HideGameOverPanel();

    }

    public void StartGame (int dificultat)
    {
        uiManager.ShowMenuPanel();
        uiManager.HidePausaPanel();   
        uiManager.HideGameOverPanel();
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            uiManager.ShowPausaPanel();
           if(isPausa)
           {
                Time.timeScale = 0f;
           }
           else
           {
               SceneManager.LoadScene(0);
             Time.timeScale = 1f;
           }
        }
    }

    public void AnimalesGordos()
    {
        uiManager.animalesGordos();
    }
    
    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Continuar()
    {
        uiManager.HidePausaPanel();
        Time.timeScale = 1f;
    }
}
