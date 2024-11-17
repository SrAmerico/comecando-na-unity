using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geral : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] int vidaJogador = 10;

    //float velocidadeCarro = 125.5f;

    //char apelido = 'A';

    //string nomeJogador = "Amerilindo";

    //bool vivo = true;

    //public int vida_jogador;

    /*
     
     == (igual)
    != (diferente)
    > (Maior que)
    < (Menor que)
    <= (Maior igual)
    >= (Maior igual)

       Operador
     
     */

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string resultado;

    void Start()
    {

        print(vidaVilao = vidaHeroi); //false
        print(vidaHeroi <= vidaVilao); //true
        print(vidaVilao != vidaHeroi); //true

        //Operador ternário
        // Condição ? Valor a ser atribuido caso verdadeiro : caso falso

        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Meior";

        //print(resultado);

        if (vidaHeroi < vidaVilao)
        {
            resultado = "Vida Heroi Menor";
            print(resultado);
        } 
        else if (vidaHeroi == vidaVilao)
        {
            resultado = "Vida Heroi igual a vida Vilao";
            print(resultado);
        } 
        else
        {
            resultado = "Vida Heroi Maior";
            print(resultado);
        }

        //Debug.Log(vidaJogador);

        //print(velocidadeCarro);

        //print(vivo);

        //print(variavelPublica);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
