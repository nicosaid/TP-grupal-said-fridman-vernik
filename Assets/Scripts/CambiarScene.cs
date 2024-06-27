using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarScene : MonoBehaviour
{
    public void ChangeScene(string comida)
    {
        SceneManager.LoadScene(comida);
    }
   
}
