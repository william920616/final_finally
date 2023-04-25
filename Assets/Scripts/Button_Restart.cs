using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public void Click()
    {
        SceneManager.LoadScene(1);
    }

}



