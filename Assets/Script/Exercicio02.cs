using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string resultado;
        bool powerUpColetado = true; // Suponha que o personagem coleta o power-up.

        if (powerUpColetado)
        {
            resultado = "Power-up Coletado";
            print(resultado);
        }
        else
        {
            resultado = "Nenhum power-up encontrado";
            print(resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//2. (Detecção de power - up) Ao coletar um power-up, o
//personagem aumenta sua velocidade. Se o jogador encontrar um
//power-up, exiba "Power-up Coletado". Caso contrário, exiba
//"Nenhum power-up encontrado".