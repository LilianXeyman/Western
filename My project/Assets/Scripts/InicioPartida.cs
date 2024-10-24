using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InicioPartida : MonoBehaviour
{
    [SerializeField]
    GameObject inicioPartida;

    [SerializeField]
    GameObject finalPartida;

    [SerializeField]
    TextMeshProUGUI textTiempo;

    [SerializeField]
    TextMeshProUGUI RewardAchieved;

    [SerializeField]
    TextMeshProUGUI textcuentaReward;

    [SerializeField]
    GameObject Machango;

    [SerializeField]
    public GameObject[] Targets;

    [SerializeField]
    public GameObject[] Destinos;

    [SerializeField]
    GameObject Objetivo;

    float tiempoPartida = 60.0f;
    float segundos = 60.0f;
    int cuentaPuntos;
    float tiempoEnemigos = 0;

    bool estaJugando;
    bool tiempoEnemigo;
    //bool encontrado = false;
    void Start()
    {
        inicioPartida.SetActive(true);
        estaJugando = false;
        finalPartida.SetActive(false);
        tiempoEnemigo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (estaJugando == true)
        {
            tiempoPartida = tiempoPartida - Time.deltaTime;
            segundos = Mathf.Floor(tiempoPartida%60);
            textTiempo.text = tiempoPartida.ToString("00")+ "s";
            if (tiempoPartida < 0.0f)
            {
                estaJugando = false;
            }
            if (estaJugando == false)
            {
                finalPartida.SetActive(true);
                RewardAchieved.text = cuentaPuntos.ToString("0000") + "$";
            }
            if (tiempoPartida < 59)
            {
               
                for (int i = 0; i < Targets.Length; i++)
                {
                    Objetivo = Targets[i];
                    Debug.Log(Objetivo);
                    Objetivo.SetActive(true);
                    //Objetivo.transform.position = Destinos[Random.Range(0,Destinos.Length)].position;
                    //Objetivo = Random.Range(0, Targets.Length);
                }
                /*Objetivo.SetActive(true);
                Objetivo.transform.position = Destinos[0,Destinos.Length].position;
                tiempoEnemigo = true;
                Targets[0, Targets.Length];*/
            }
            
        }
        /*if (tiempoEnemigo == true)
        {
            tiempoEnemigos = tiempoEnemigos + Time.deltaTime;
            if (tiempoEnemigos > 5.0f)
            {
                Targets[0].SetActive(false);
            }
            if (tiempoEnemigos > 3.0f)
            {
                Targets[1].SetActive(false);
            }
            if (tiempoEnemigos > 4.0f)
            {
                Targets[2].SetActive(false);
            }
            if (tiempoEnemigos > 8.0f)
            {
                Targets[3].SetActive(false);
            }
            if (tiempoEnemigos > 10.0f)
            {
                Targets[4].SetActive(false);
            }
        }*/
        
    }
    public void ComenzarPartida()
    {
        inicioPartida.SetActive(false);
        estaJugando = true;
    }
    public void Reintentar()
    {
        finalPartida.SetActive(false);
        inicioPartida.SetActive(true);
        estaJugando = false;
        tiempoPartida = 60.0f;
    }
    //No entiendo porque no me hace la cuentaPuntos ni me lo manda al textcuentaReward o al RewardAchieved
    public void Enemigos()
    {
        if (Targets[0]==false)
        {
            cuentaPuntos = cuentaPuntos + 500;
            textcuentaReward.text = cuentaPuntos.ToString() + "$";
        }
        if (Targets[1] == false)
        {
            cuentaPuntos = cuentaPuntos + 750;
            textcuentaReward.text = cuentaPuntos.ToString() + "$";
        }
        if (Targets[2] == false)
        {
            cuentaPuntos = cuentaPuntos - 50;
            textcuentaReward.text = cuentaPuntos.ToString() + "$";
        }
        if (Targets[3] == false)
        {
            cuentaPuntos = cuentaPuntos -80;
            textcuentaReward.text = cuentaPuntos.ToString() + "$";
        }
        if (Targets[4] == false)
        {
            cuentaPuntos = cuentaPuntos -100;
            textcuentaReward.text = cuentaPuntos.ToString() + "$";
        }
    }
    public void BadGuy()
    {
        Targets[0].SetActive(false);
    }
    public void BadGuy2()
    {
        Targets[1].SetActive(false);
    }
    public void GoodGuy()
    {
        Targets[2].SetActive(false);
    }
    public void Lady()
    {
        Targets[3].SetActive(false);
    }
    public void Sheriff()
    {
        Targets[4].SetActive(false);
    }

}
