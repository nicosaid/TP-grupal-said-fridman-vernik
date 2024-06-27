using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarScene : MonoBehaviour
{
    public void ChangeScene(string comida)
    {
        SceneManager.LoadScene(comida);
    }
   
}
