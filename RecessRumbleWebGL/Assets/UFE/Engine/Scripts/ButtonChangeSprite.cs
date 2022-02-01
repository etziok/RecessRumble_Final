using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonChangeSprite : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject bulb;
    private SpriteRenderer bulbColor;
    private int bulbState;

    [SerializeField]
    private Sprite[] switchSprites;
    private Image switchImage;

    void Start()
    {
        bulbColor = bulb.GetComponent<SpriteRenderer>();
        bulbState = 0; //bulb is off at the beginning

        switchImage = GetComponent<Button>().image;
        switchImage.sprite = switchSprites[bulbState];

        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);

    }

    private void TurnOnAndOff()
    {
        bulbColor.color = new Color(1f, 1f, bulbState, 1f);
        bulbState = 1 - bulbState; //swtich between 0 and 1
        switchImage.sprite = switchSprites[bulbState];
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
