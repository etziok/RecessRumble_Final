using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPLibrary;
using UFE3D;
using UnityEngine.Analytics;

public class ActivarCartel : MonoBehaviour
{

    public GameObject CartelFinalExtra;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UFE.gameMode == GameMode.StoryMode)
        {
            CartelFinalExtra.SetActive(true);
        }
    }
}
