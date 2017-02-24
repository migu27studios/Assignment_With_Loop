using UnityEngine;
using System.Collections;
using System.Collections.Generic; //For Lists!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! USE IT!!!!!!!!!!!!!
public class ListWithLoops : MonoBehaviour {


    public List<string> animals;






	// Use this for initialization
	void Start () {

        foreach (string item in animals)
        {
            if (item == "Cat")
            {
                print(item);
            }
        }
	}

}
