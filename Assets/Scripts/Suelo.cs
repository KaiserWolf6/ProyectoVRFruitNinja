using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Suelo : MonoBehaviour
{

    public int vidas = 3;
    public Image[] life;
    
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.gameObject.CompareTag("Fruit"))
        {
            Destroy(collision.collider.gameObject);
            vidas--;
        }
    }

}
