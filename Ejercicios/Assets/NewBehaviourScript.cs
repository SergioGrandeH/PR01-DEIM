﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Tipos de variables//

    public string mensaje = "Buenas tardes";
    public float numerodecimal = 1.2f ;
    public int numeroentero = 12;
    public bool vivo = true;
    int num1 = 5;
    int num2 = 10;
    int m = 20;
    int Multiplicar; 
    int multiplicar (int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        void Saludo ( string Hola)
    {
        print("hola" + Hola);
    }
    // Start is called before the first frame update
    void Start()
    {
        Saludo("Juan");
    }
    
    // Update is called once per frame
    void Update()
    {
   
    }
}
