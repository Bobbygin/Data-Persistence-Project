using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[DefaultExecutionOrder(1000)]
public class MenuUI : MonoBehaviour
{
    public new InputField name;

    
    public void StartNew()
    {
        
        SceneManager.LoadScene(1);
        
    }
}
