using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // 버튼을 눌렀을때 이미지를 pressedImage로 변환
            theSR.sprite = pressedImage;
            Debug.Log("press");
        }

        if(Input.GetMouseButtonUp(0))
        {
            // 버튼을 눌렀다 뗏을때 원래 이미지로 변환
            theSR.sprite = defaultImage;
            Debug.Log("up");
        }
    }
}
