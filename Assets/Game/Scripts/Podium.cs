using System.Collections;
using UnityEngine.UI;

using UnityEngine;

public class Podium : MonoBehaviour
{
  
    private string[] nomes = new string[] { "Romain Grosjean", "Kevin Magnussen ", "Fernando Alonso ","Ayrton Senna" , "Michael Schumacher",
    "Juan Manuel Fangio", "Alain Prost", "Jim Clark", "Jackie Stewart", "Niki Lauda",
    "Stirling Moss" ,"Gilles Villeneuve" ,"Nigel Mansell" ,"Emerson Fittipaldi" ,"Nelson Piquet" ,"Jochen Rindt" ,"Mika Hakkinen" ," Alberto Ascari",
    "Lewis Hamilton" ,"Jack Brabham" ,"Ronnie Peterson" ,"Mario Andretti" ," Graham Hill" ,"Kimi Raikkonen" ,"John Surtees" ,"James Hunt" ,"Keke Rosberg" ,"Sebastian Vettel" ,
    "Jose Froilan Gonzalez" ,"François Cevert"};
    private float[] melhorT = new float[31];
    private float[] tempoT = new float[31];
    private int[] posicao = new int[31];
    private string[] melhorTT = new string[31];
    private string[] tempoTT = new string[31];
    private float a;
    public GameObject vitoria;



Text text;

void Start()
    {
        if (Player.posic == 0)
        {
            Instantiate(vitoria);
        }


        for (int i = 1; i < 30; i++)
        {
            a = Random.Range(70, 100);
            melhorT[i] = a/60;
            tempoT[i] =melhorT[i] * 47 ;
            melhorTT[i] = string.Format("{0:#.#,##}", melhorT[i]);
            tempoTT[i] = string.Format("{0:#.#,##}", tempoT[i]);

        }


        text = GetComponent<Text>();
        nomes[Player.posic] = "Rubens Barrichelo";
        melhorT[Player.posic] = Player.melhor_volta;
        tempoT[Player.posic] = Player.tempo_total;
        

        for (int k = 0; k < 30; k++)
        {

            posicao[k] = Random.Range(1,30);
            
            
            for (int j = 0; j < k; j++)
            {
                if (posicao[j] == posicao[k] || Player.posic == posicao[j])
                {
                    posicao[k] = Random.Range(1,30);
                    j = 0;
                }
                
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        text.text = "Posição |    Nome do piloto        | Melhor volta | Tempo total\n" +

                    "   1°              |   " + nomes[posicao[1]] + "|     " + melhorTT[posicao[1]] + "     |     " + tempoTT[posicao[1]] + "\n" +
                    "   2°              |   " + nomes[posicao[2]] + " |     " + melhorTT[posicao[2]] + "     |     " + tempoTT[posicao[2]] + "\n" +
                    "   3°              |   " + nomes[posicao[3]] + " |     " + melhorTT[posicao[3]] + "     |     " + tempoTT[posicao[3]] + "\n" +
                    "   4°              |   " + nomes[posicao[4]] + " |     " + melhorTT[posicao[4]] + "     |     " + tempoTT[posicao[4]] + "\n" +
                    "   5°              |   " + nomes[posicao[5]] + " |     " + melhorTT[posicao[5]] + "     |     " + tempoTT[posicao[5]] + "\n" +
                    "   6°              |   " + nomes[posicao[6]] + " |     " + melhorTT[posicao[6]] + "     |     " + tempoTT[posicao[6]] + "\n" +
                    "   7°              |   " + nomes[posicao[7]] + " |     " + melhorTT[posicao[7]] + "     |     " + tempoTT[posicao[7]] + "\n" +
                    "   8°              |   " + nomes[posicao[8]] + " |     " + melhorTT[posicao[8]] + "     |     " + tempoTT[posicao[8]] + "\n" +
                    "   9°              |   " + nomes[posicao[9]] + " |     " + melhorTT[posicao[9]] + "     |     " + tempoTT[posicao[9]] + "\n" +
                    "   10°              |   " + nomes[posicao[10]] + " |     " + melhorTT[posicao[10]] + "     |     " + tempoTT[posicao[10]] + "\n" +
                    "   11°              |   " + nomes[posicao[11]] + " |     " + melhorTT[posicao[11]] + "     |     " + tempoTT[posicao[11]] + "\n" +
                    "   12°              |   " + nomes[posicao[12]] + " |     " + melhorTT[posicao[12]] + "     |     " + tempoTT[posicao[12]] + "\n" +
                    "   13°              |   " + nomes[posicao[13]] + " |     " + melhorTT[posicao[13]] + "     |     " + tempoTT[posicao[13]] + "\n" +
                    "   14°              |   " + nomes[posicao[14]] + " |     " + melhorTT[posicao[14]] + "     |     " + tempoTT[posicao[14]] + "\n" +
                    "   15°              |   " + nomes[posicao[15]] + " |     " + melhorTT[posicao[15]] + "     |     " + tempoTT[posicao[15]] + "\n";
                    /*"   16°              |   " + nomes[posicao[16]] + " |     " + melhorTT[posicao[16]] + "     |     " + tempoTT[posicao[16]] + "\n" +
                    "   17°              |   " + nomes[posicao[17]] + " |     " + melhorTT[posicao[17]] + "     |     " + tempoTT[posicao[17]] + "\n" +
                    "   18°              |   " + nomes[posicao[18]] + " |     " + melhorTT[posicao[18]] + "     |     " + tempoTT[posicao[18]] + "\n" +
                    "   19°              |   " + nomes[posicao[19]] + " |     " + melhorTT[posicao[19]] + "     |     " + tempoTT[posicao[19]] + "\n" +
                    "   20°              |   " + nomes[posicao[20]] + " |     " + melhorTT[posicao[20]] + "     |     " + tempoTT[posicao[20]] + "\n" +
                    "   21°              |   " + nomes[posicao[21]] + " |     " + melhorTT[posicao[21]] + "     |     " + tempoTT[posicao[21]] + "\n" +
                    "   22°              |   " + nomes[posicao[22]] + " |     " + melhorTT[posicao[22]] + "     |     " + tempoTT[posicao[22]] + "\n" +
                    "   23°              |   " + nomes[posicao[23]] + " |     " + melhorTT[posicao[23]] + "     |     " + tempoTT[posicao[23]] + "\n" +
                    "   24°              |   " + nomes[posicao[24]] + " |     " + melhorTT[posicao[24]] + "     |     " + tempoTT[posicao[24]] + "\n" +
                    "   25°              |   " + nomes[posicao[25]] + " |     " + melhorTT[posicao[25]] + "     |     " + tempoTT[posicao[25]] + "\n" +
                    "   26°              |   " + nomes[posicao[26]] + " |     " + melhorTT[posicao[26]] + "     |     " + tempoTT[posicao[26]] + "\n" +
                    "   27°              |   " + nomes[posicao[27]] + " |     " + melhorTT[posicao[27]] + "     |     " + tempoTT[posicao[27]] + "\n" +
                    "   28°              |   " + nomes[posicao[28]] + " |     " + melhorTT[posicao[28]] + "     |     " + tempoTT[posicao[28]] + "\n" +
                    "   29°              |   " + nomes[posicao[29]] + " |     " + melhorTT[posicao[29]] + "     |     " + tempoTT[posicao[29]] + "\n" +
                     "   30°              |   " + nomes[posicao[30]] + " |     " + melhorTT[posicao[30]] + "     |     " + tempoTT[posicao[30]] + "\n" ;

    */
        


    }
}

