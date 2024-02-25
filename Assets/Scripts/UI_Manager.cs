using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;




public class UI_Manager : MonoBehaviour
{

    [SerializeField] private GameObject PausaPanel;
    [SerializeField] private Button Continuar;
    [SerializeField] private Button Reiniciar;

    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private Button Nivel1;
    [SerializeField] private Button Nivel2;

    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private TextMeshProUGUI animales_gordos;
    [SerializeField] private TextMeshProUGUI animales_engordados;
    [SerializeField] private Button Reiniciar2;

    private GameManager gamemanager;

    void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
        Continuar.onClick.AddListener(() => { gamemanager.Continuar(); });
        Reiniciar.onClick.AddListener(() => { gamemanager.Reiniciar(); });
        Nivel1.onClick.AddListener(() => { gamemanager.StartGame(1); });
        Nivel2.onClick.AddListener(() => { gamemanager.StartGame(2); });
        Reiniciar2.onClick.AddListener(() => { gamemanager.Reiniciar(); });
    }
    

    public void ShowPausaPanel()
    {
       PausaPanel.SetActive(true);
     
    }

    public void HidePausaPanel()
    {
        PausaPanel.SetActive(false);
    }

     public void ShowMenuPanel()
    {
       MenuPanel.SetActive(true);
    }

    public void HideMenuPanel()
    {
       MenuPanel.SetActive(false);
    }

    public void ShowAnimalesGordos()
    {
        animales_gordos.text = "";
    }

    public void AnimalesGordos(int engordando)
    {
        animales_gordos.text = $"Has engordado a: {engordando}";
    }

    public void ShowGameOverPanel(int engordados)
    {
       GameOverPanel.SetActive(true);
       animales_engordados.text = $"Animales engordados: {engordados}";
       animales_gordos.text = "";
    }

    public void HideGameOverPanel()
    {
       GameOverPanel.SetActive(false);
    }
}
