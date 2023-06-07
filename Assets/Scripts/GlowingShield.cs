using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlowingShield : MonoBehaviour
{

   // [SerializeField] private Color newColor;
    [SerializeField] private SpriteRenderer sprend;



    private void Start()
    {
        sprend = GetComponent<SpriteRenderer>();
        sprend.color = new Color(sprend.color.r, sprend.color.b, sprend.color.g, 0.1f);
      
    }


   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("object"))
        {
            sprend.color = new Color(sprend.color.r, sprend.color.b, sprend.color.g, sprend.color.a +.1f);
            Debug.Log("Color");
        }
    }
}
