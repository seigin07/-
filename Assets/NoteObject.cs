using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);
                Debug.Log("hi");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Activator")
        {
            canBePressed = false;
            Destroy(gameObject);
        }
    }
}
