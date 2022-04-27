using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoRobot : MonoBehaviour
{
    public TextMeshProUGUI texto;

    [TextArea (3,30)]
    public string[] parrafos;
    int index = 0;
    int cont = 0;
    public float velParrafo;

    public GameObject botonContinuar;
    public GameObject botonSalir;

    public GameObject panelDialogo;
    public GameObject botonLeer;


    // Start is called before the first frame update
    void Start()
    {
        botonSalir.SetActive(false);
        botonLeer.SetActive(false);
        panelDialogo.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator textoDialogo()
    {
        foreach(char letra in parrafos[index].ToCharArray())
        {
            texto.text += letra;
            yield return new WaitForSeconds(velParrafo);
            
        }
    }

    public void mostrarTexto()
    {
        texto.text += parrafos[index];
    }

    public void siguienteParrafo()
    {
        if(index < parrafos.Length - 1)
        {
            index++;
            texto.text = "";
            mostrarTexto();
        }
        else
        {
            texto.text = "Now your adventure in the world of percussion begins!!!";
            botonContinuar.SetActive(false);
            botonSalir.SetActive(true);
        }
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            botonLeer.SetActive(true);
            print("Colision");
        }
        else
        {
            botonLeer.SetActive(false);
        }
    }*/

    public void empezarDialogo()
    {
        botonLeer.SetActive(true);
    }

    public void activarBotonLeer()
    {
        panelDialogo.SetActive(true);
        botonContinuar.SetActive(true);
        botonLeer.SetActive(false);
        mostrarTexto();
    }

    public void botonCerrar()
    {
        panelDialogo.SetActive(false);
        botonSalir.SetActive(false);
        index = 0;
    }
}
