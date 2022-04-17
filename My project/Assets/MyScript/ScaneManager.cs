using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScaneManager : MonoBehaviour
{
    public Button button;
    void onButtonClick()
    {
        Debug.Log("button has been clicked.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(onButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
