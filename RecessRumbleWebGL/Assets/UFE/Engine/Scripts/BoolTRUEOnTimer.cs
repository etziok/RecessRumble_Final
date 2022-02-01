using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolTRUEOnTimer : MonoBehaviour
{
    public GameObject objectToActivate;
    public int TimeBeforeActivate;
    public int TimeBeforeDisable;

    
    public void Iniciar()
    {
      
            StartCoroutine(ActivationRoutine());
      
    }

    public IEnumerator ActivationRoutine()
    {
        //Wait for 14 secs.
        yield return new WaitForSeconds(8);

        //Turn My game object that is set to false(off) to True(on).
        objectToActivate.SetActive(true);

        //Turn the Game Oject back off after 1 sec.
        yield return new WaitForSeconds(15);

        //Game object will turn off
        objectToActivate.SetActive(false);
    }

}