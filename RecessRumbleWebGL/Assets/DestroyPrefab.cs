using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour
{
    public GameObject CartelExtra;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(CartelExtra, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
