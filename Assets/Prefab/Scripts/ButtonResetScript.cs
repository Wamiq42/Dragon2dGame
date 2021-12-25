using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonResetScript : MonoBehaviour
{
    public GameObject buttonReset;
    
 
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        if(GameObject.FindWithTag("Player")==null)
        {
            buttonReset.SetActive(true);
            
            
        }
    }


}