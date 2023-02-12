using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class BallSize : MonoBehaviour
{
    public GameObject winTextObject;
    public Dropdown playerSize;
    private float size = 1.0f;


    public void ChangeSize()
    {
        switch (playerSize.value)
        {
            case 1:
                size = 1.0f;
                break;
            case 2:
                size = 3.0f;
                break;
            case 3:
                size = 5.0f;
                break;
            default:
                size = 1.0f;
                break;

        }


        winTextObject.transform.localScale = new Vector3(size, size, size);
        // adujust vertical position so ball does not fall out of plane
        winTextObject.transform.localPosition = new Vector3(winTextObject.transform.localPosition.x, 0.5f * size,
            winTextObject.transform.localPosition.z);

    }
}
