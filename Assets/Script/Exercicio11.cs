using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    //11. (Diálogos) Implemente um sistema de diálogos onde o jogador
    //pode interagir com um NPC (personagem não jogável), e o NPC
    //responde com diferentes frases dependendo do estado do jogo.
    //Use switch case para definir as respostas baseadas no estado do
    //jogador.

    [SerializeField] int estado;

    void Start()
    {
        switch (estado)
        {
            case 1:
                print("Vaii Corinthiaaaans");
                break;

            case 2:
                print("Sextooou!");
                break;

            case 3:
                print("Yuri? Cadê tu?");
                break;

            case 4:
                print("Obama?");
                break;

            case 5:
                print("Ucê jogo onde?");
                break;

            default:
                print("Bando de Secador");
                break;
        }
    }

    
    void Update()
    {
        
    }
}