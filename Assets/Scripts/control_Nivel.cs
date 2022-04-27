using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class control_Nivel : MonoBehaviour
{
    public static control_Nivel instance;

    public int errores = 0;
    public int puntos = 0;

    public TextMeshProUGUI txtPuntos;
    public TextMeshProUGUI txtErrores;


    
    private void Awake()
    {
        instance = this;

    }


    void Update()
    {

        //Pasas Nivel
        
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            puntos = puntos + 1;
            txtPuntos.text = puntos.ToString();
            if (Input.GetKeyDown(KeyCode.A))
            {
                puntos = puntos + 1;
                txtPuntos.text = puntos.ToString();
                print("SEGUNDA NOTA");

            }
            else if (Input.GetKeyDown(KeyCode.D))
            {

                errores = errores + 1;
                txtErrores.text = errores.ToString();
                print("SEGUNDA NOTA MALA");


            }
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {

            errores = errores + 1;
            txtErrores.text = errores.ToString();
            print("Primera NOTA mala");

        }




    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    

}
