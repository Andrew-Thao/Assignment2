using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static float speed = 0;
    
    
    public TextMeshProUGUI countText;
    public GameObject winTextObject; 

    private Rigidbody rb;
    private int count; 

    private float movementX;
    private float movementY;



    void Start()
    {
        rb = GetComponent<Rigidbody>(); //sets rb value
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue) 
    {
        Vector2 movementVector = movementValue.Get<Vector2>(); 
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
   

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            
            winTextObject.SetActive(true);
            
            SceneManager.LoadScene("End");

        }
    }
    

    private void FixedUpdate()
    {
        
        Vector3 movement = new Vector3(movementX, 0.0f ,movementY);
        
        rb.AddForce(movement * speed);

 
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        
    }
    
}
