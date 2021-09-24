using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Tipos de variables//

    public string mensaje = "Buenas tardes";
    public float numerodecimal = 1.2f ;
    public int numeroentero = 12;
    public bool vivo = true;
    int x = 0;
    int y = 0;
    int z = 0;
    int Multiplicar; 
    int multiplicar (int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
    public Text timer;

    IEnumerator contador()
    {
        while (true)
        {
            print("La hora es " + z + ":" + y + ":" + x);

            timer.text = "La hora es" + z + ":" + y + ":" + x;
            x++;
            yield return new WaitForSeconds(1f);
            if (x == 60)
            {
                x = 0;
                y++;
            }
            if (y == 60)
            {
                y = 0;
                z++;
            }
            if (y == 1)

            {
                StopCoroutine("contador");
            }

        }

    }
    









    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine("contador");
       
    }
    
    // Update is called once per frame
    void Update()
    {
   
    }
}
