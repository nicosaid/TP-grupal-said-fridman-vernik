using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComidasScript : MonoBehaviour
{
    public GameObject[] productos;
    int productoRandom;
    GameObject producto;
    Dictionary<GameObject, int> precios = new Dictionary<GameObject, int>();
    public Text txtPrecio1;
    public Text txtPrecio2;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < productos.Length; i++)
        {
            precios.Add(productos[i], Random.Range(1, 25));
        }
        Activate(154.7f, 138.6f, -313.9f);
        txtPrecio1.text = precios[producto].ToString();
        Activate(269f, 138.6f, -313.9f);
        txtPrecio2.text = precios[producto].ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Activate(float x, float y, float z)
    {
        productoRandom = Random.Range(0, productos.Length);
        Vector3 posicion = new Vector3(x, y, z);
        producto = productos[productoRandom];
        Instantiate(producto, posicion, Quaternion.identity);
    }
}
