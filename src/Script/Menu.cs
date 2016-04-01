using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
    public GameObject niveis;
    public GameObject instr;
    public GameObject Credito;
    // Use this for initialization
    void Start () {
        niveis.SetActive(false);
        instr.SetActive(false);
        Credito.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void IniciaJogo()
    {
        niveis.SetActive(true);
    }
    public void Creditos()
    {
        Credito.SetActive(true);
    }
    public void Instruc()
    {
        instr.SetActive(true);
    }
    public void facil()
    {
        Application.LoadLevel(7);
    }
    public void medio()
    {
        Application.LoadLevel(8);

    }
    public void dificil()
    {
        Application.LoadLevel(6);
    }
    public void voltarMenuinstr()
    {
        instr.SetActive(false);
    }
    public void voltarParaMenu()
    {
        Application.LoadLevel(0);
    }
    public void voltarParaMenudeNiveis()
    {
        niveis.SetActive(false);
    }
    public void voltarParaMenudecreditos()
    {
        Credito.SetActive(false);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
