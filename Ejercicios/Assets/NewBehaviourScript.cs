using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Tipos de variables//

    public string mensaje = "Buenas tardes";
    public float numerodecimal = 1.2f ;
    public int numeroentero = 12;
    public bool vivo = true;
    int n = 0;
    int l = 10;
    int m = 20;

    // Start is called before the first frame update
    void Start()
    {

        while (n < 20)
        {
            n++;
            print(n);   
        if (n == 20)
            {
                print(mensaje);
            }
        }
        for (m = 20; m <= 30; m++)
        { 
            print(m); 
            if(m == 30)
            {
                print(mensaje);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
