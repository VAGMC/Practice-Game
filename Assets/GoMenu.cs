using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Menu()
    {
    
    SceneManager.LoadScene("Menu", LoadSceneMode.Single);  

    }
}
