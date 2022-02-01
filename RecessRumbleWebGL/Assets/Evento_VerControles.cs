using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Analytics;

public class Evento_VerControles : MonoBehaviour
{
    public Text namePlayer1;
    public Text namePlayer2;

    // Start is called before the first frame update
    void Start()
    {
        Analytics.CustomEvent("ver_controles", new Dictionary<string, object>{     
        {"protagonista",  UFE.config.player1Character.characterName}

        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
