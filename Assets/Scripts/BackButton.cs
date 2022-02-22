using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject activePanel;
    public GameObject toGoPanel;

    public void GoBack()
    {
        activePanel.SetActive(false);
        toGoPanel.SetActive(true);
    }
}
