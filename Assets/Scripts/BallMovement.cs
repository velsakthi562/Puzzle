using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{

    private Rigidbody2D rigidbody2d;
    public float speed;

    Vector3 _Last_Velocity;
    

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

    }

    

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2d.AddForce(new Vector2(20 * Time.deltaTime * speed, 20 * Time.deltaTime * speed));
        }

        _Last_Velocity = rigidbody2d.velocity;


        if (Input.GetKeyUp(KeyCode.S) )
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var fast = _Last_Velocity.magnitude;
        var direction = Vector3.Reflect(_Last_Velocity.normalized, collision.contacts[0].normal);
        rigidbody2d.velocity = direction * Mathf.Max(fast, 0f);
    }



}
