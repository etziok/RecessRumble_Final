using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    InputField m_InputField;
    void Start()
    {
        //Fetch the Input Field component from the GameObject
        m_InputField = GetComponent<InputField>();
    }

    void Update()
    {
        //Check if the Input Field is in focus and able to alter
        if (m_InputField.isFocused)
        {
            //Change the Color of the Input Field's Image to green
            m_InputField.GetComponent<Image>().color = Color.green;
        }
    }
}