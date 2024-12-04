using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interpolation : MonoBehaviour
{
    [Header("Dot value")]
    public float DotValue;
    [Space(10)]

    public float number1;
    public float number2;

    public float interpolationValue;
    
    public float handle;

    public Transform position1;
    public Transform position2;

    public Slider slider;
    public Image healthBarImage;
    public SpriteRenderer playerSprite;
    // Start is called before the first frame update
    void Start()
    {
        //Start MoveCloser()
        //InvokeRepeating("MoveCloser", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //interpolationValue = Mathf.Lerp(number1, number2, handle);

        //Interpolation of colors for Health Bar
        
        //healthBarImage.color = Color.Lerp(Color.red, Color.green, slider.value / slider.maxValue);
        //test on github

        DotValue = Vector2.Dot(position1.up, position2.position);
        
    }

    //Method for moving an object every 2 seconds with lerp
    void MoveCloser()
    {
        //transform.position = Vector2.Lerp(transform.position, position2, 0.5f);
    }
}
