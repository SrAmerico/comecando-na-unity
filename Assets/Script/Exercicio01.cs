using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    int pontosDeVida = 10;
    string resultado;

    void Start()
    {
        pontosDeVida -= 8;

        if (pontosDeVida > 0)
        {
            resultado = "Personagem Vivo";
            print(resultado);
        }
        else
        {
            resultado = ("Game over");
            print(resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//1. (Verifica��o de pontos de vida) Um personagem perde pontos
//de vida ap�s uma batalha. Verifique se ele ainda est� vivo. Caso
//tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
//contr�rio, "Game Over".
