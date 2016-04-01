using UnityEngine;
using System.Collections;

public class exemploMusica2 : MonoBehaviour {
    public GameObject[] luz;
    public AudioSource[] audioS;
    public GameObject[] audiogameobject;
    // Use this for initialization
    void Start()
    {
        luz[0].SetActive(false);
        luz[1].SetActive(false);
        luz[2].SetActive(false);
        luz[3].SetActive(false);
        luz[4].SetActive(false);
        luz[5].SetActive(false);
        luz[6].SetActive(false);
        audiogameobject[0].SetActive(true);
        audiogameobject[1].SetActive(false);
        audiogameobject[2].SetActive(false);
        audiogameobject[3].SetActive(false);
        audiogameobject[4].SetActive(false);
        audiogameobject[5].SetActive(false);
        audiogameobject[6].SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (audioS[0].isPlaying)
        {
            luz[0].SetActive(true);

        }
        else
        {
            luz[0].SetActive(false);
            audiogameobject[1].SetActive(true);
            if (audioS[1].isPlaying)
            {
                luz[1].SetActive(true);

            }
            else
            {
                luz[1].SetActive(false);
                audiogameobject[2].SetActive(true);
                if (audioS[2].isPlaying)
                {
                    luz[2].SetActive(true);

                }
                else
                {
                    luz[2].SetActive(false);
                    audiogameobject[3].SetActive(true);
                    if (audioS[3].isPlaying)
                    {
                        luz[3].SetActive(true);

                    }
                    else
                    {
                        luz[3].SetActive(false);
                        audiogameobject[4].SetActive(true);
                        if (audioS[4].isPlaying)
                        {
                            luz[4].SetActive(true);

                        }
                        else
                        {
                            luz[4].SetActive(false);
                            audiogameobject[5].SetActive(true);
                            if (audioS[5].isPlaying)
                            {
                                luz[5].SetActive(true);

                            }
                            else
                            {
                                luz[5].SetActive(false);
                                audiogameobject[6].SetActive(true);
                                if (audioS[6].isPlaying)
                                {
                                    luz[6].SetActive(true);

                                }
                                else
                                {
                                    luz[6].SetActive(false);                                    
                                    audiogameobject[7].SetActive(true);
                                    if (audioS[7].isPlaying)
                                    {
                                        luz[7].SetActive(true);

                                    }
                                    else
                                    {
                                        luz[7].SetActive(false);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        StartCoroutine(Example());

    }
    IEnumerator Example()
    {

        yield return new WaitForSeconds(24);
        Application.LoadLevel(2);
    }

}
