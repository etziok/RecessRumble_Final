using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonKeyPress : MonoBehaviour
{
    // Start is called before the first frame update
    private Button _button;

    void Awake()
    {
        _button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            _button.onClick.Invoke();
        }
    }
}
