using UnityEngine;
using System.Collections;

public class Facil : MonoBehaviour {

    public int vela;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider Trigger)
    {
        if (Trigger.gameObject.tag == "vela")
        {
            vela = 1;
        }
        if (Trigger.gameObject.tag == "level1")
        {
            if (vela == 1)
            {
                Application.LoadLevel(1);
            }

        }

    }
}
