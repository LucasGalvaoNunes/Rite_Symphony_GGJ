using UnityEngine;
using System.Collections;

public class Vela : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider Trigger)
    {
        if(Trigger.gameObject.tag == "Player")
        {
            Destroy(gameObject);
           

        }
    }
}
