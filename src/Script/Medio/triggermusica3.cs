using UnityEngine;
using System.Collections;

public class triggermusica3 : MonoBehaviour {
    public GameObject luz;
    public GameObject[] triggers;
    public GameObject[] triggersNAO;

    public int posi;



    void Start()
    {

        triggers[0].SetActive(true);

        triggers[1].SetActive(false);
        triggers[2].SetActive(false);
        triggers[3].SetActive(false);
        triggers[4].SetActive(false);
        triggers[5].SetActive(false);
        triggers[6].SetActive(false);
        triggers[7].SetActive(false);
        triggers[8].SetActive(false);

        triggersNAO[0].SetActive(false);

        luz.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(posi);

    }

    void OnTriggerEnter(Collider triger)
    {
        if (triger.gameObject.tag == "NAO")
        {
            Application.LoadLevel(4);
        }
        else
        {
            if (triger.gameObject.tag == "1")
            {

                StartCoroutine(Example());
                triggers[1].SetActive(true);
                triggersNAO[1].SetActive(false);
            }
            if (triger.gameObject.tag == "9")
            {
                StartCoroutine(Example());
                triggers[2].SetActive(true);
                triggersNAO[2].SetActive(false);

            }
            if (triger.gameObject.tag == "4")
            {

                StartCoroutine(Example());
                triggers[3].SetActive(true);
                triggersNAO[3].SetActive(false);

            }
            if (triger.gameObject.tag == "5")
            {

                StartCoroutine(Example());
                triggers[4].SetActive(true);
                triggersNAO[4].SetActive(false);

            }
            if (triger.gameObject.tag == "7")
            {

                StartCoroutine(Example());
                triggers[5].SetActive(true);
                triggersNAO[5].SetActive(false);

            }
            if (triger.gameObject.tag == "3")
            {

                StartCoroutine(Example());
                triggers[6].SetActive(true);
                triggersNAO[6].SetActive(false);


            }
            if (triger.gameObject.tag == "8")
            {

                StartCoroutine(Example());
                triggers[7].SetActive(true);
                triggersNAO[7].SetActive(false);


            }
            if (triger.gameObject.tag == "2")
            {

                StartCoroutine(Example());
                triggers[8].SetActive(true);
                triggersNAO[8].SetActive(false);


            }
            if (triger.gameObject.tag == "6")
            {


                StartCoroutine(Example());
                Application.LoadLevel(9);
                triggers[8].SetActive(true);
                triggersNAO[8].SetActive(false);


            }

        }

    }
    IEnumerator Example()
    {
        luz.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        luz.SetActive(false);
    }


}
