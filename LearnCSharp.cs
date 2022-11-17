using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCSharp : MonoBehaviour
{

[SerializeField] int _int;

enum Enumerator {Raz, Dwa, Trzy}
[SerializeField] Enumerator _enumerator;

void Awake(){
    _int = (_int == 0) ? 1 : _int;
    

    switch (_enumerator)
    {
        case Enumerator.Raz:
            //Raz
            
        case Enumerator.Dwa:
            //Dwa

        case Enumerator.Trzy:
            //Trzy
        break;

    }

foreach (Transform child in transform){}
}

void OnEnable(){

    
}
void Update(){

}

}
