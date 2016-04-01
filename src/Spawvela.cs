using UnityEngine;
using System.Collections;

public class Spawvela : MonoBehaviour {

    public GameObject velaSpaw;
    public Transform[] posi;

    // Use this for initialization
    void Start () {
        Instantiate(velaSpaw, posi[Random.Range(0, posi.Length)].position, posi[1].rotation);
    }
	
	// Update is called once per frame
	void Update () {

        
        
            

                
              
           
        
      
            

	}
}
