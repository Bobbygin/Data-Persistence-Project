using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public InputField name;
    public void StartNew()
    {
        MainManager.instance.name = name.text;
        SceneManager.LoadScene(1);
    }

}
