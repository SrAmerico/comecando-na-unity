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
        bool powerUpColetado = true; // Aqui o personagem coleta o power-up (Supondo).

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

//2. (Detec��o de power - up) Ao coletar um power-up, o
//personagem aumenta sua velocidade. Se o jogador encontrar um
//power-up, exiba "Power-up Coletado". Caso contr�rio, exiba
//"Nenhum power-up encontrado".