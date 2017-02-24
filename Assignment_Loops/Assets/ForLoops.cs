using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ForLoops : MonoBehaviour {

    //For loops have an iterator

    public List<string> cars;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < cars.Count; i++)   //The middle part if for List.Count  (For lists we use .Count).
        {
            print(cars[i]);
        }   
	
	}
	

}
