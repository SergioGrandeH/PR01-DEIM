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


    // Start is called before the first frame update
    void Start()
    {
        print(mensaje);
        print(numerodecimal);
        print(numeroentero);
        print(vivo);

        print(numeroentero + numerodecimal);
        }

    // Update is called once per frame
    void Update()
    {
        print(numeroentero + numerodecimal);
    }
}
