using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    Rigidbody2D rb;
    BoxCollider2D bodyCollider;
    public float forceScale = 4;
    Vector2 prevDir = Vector2.zero;

    // Start is called before the first frame update
    void Start() {
        Physics2D.gravity = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();
        bodyCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(x, y).normalized;
        
        if (x == 0 ^ y == 0  /*((x != 0 && y == 0) || (x == 0 && y != 0))*/)
        {
            Debug.Log(direction);
            if (prevDir != direction)
            {
                prevDir = direction;
                rb.velocity = Vector2.zero;
            }
            //rb.AddForce(direction * forceScale, ForceMode2D.Impulse);
            rb.velocity += direction * forceScale;
        }




        
    }

    //// Update is called once per frame
    //void Update() {
    //    if (Input.GetKeyDown(KeyCode.D)) {
    //        if (rb.velocity.normalized != Vector2.right)
    //        {
    //            rb.velocity = Vector2.zero;
    //        }
    //        rb.AddForce(Vector2.right * forceScale, ForceMode2D.Impulse);
    //    }

    //    if (Input.GetKeyDown(KeyCode.A)) {
    //        if (rb.velocity.normalized != Vector2.left)
    //        {
    //            rb.velocity = Vector2.zero;
    //        }
    //        rb.AddForce(Vector2.left * forceScale, ForceMode2D.Impulse);
    //    }

    //    if (Input.GetKeyDown(KeyCode.W)) {
    //        if (rb.velocity.normalized != Vector2.up)
    //        {
    //            rb.velocity = Vector2.zero;
    //        }
    //        rb.AddForce(Vector2.up * forceScale, ForceMode2D.Impulse);
    //    }

    //    if (Input.GetKeyDown(KeyCode.S)) {
    //        if (rb.velocity.normalized != Vector2.down)
    //        {
    //            rb.velocity = Vector2.zero;
    //        }
    //        rb.AddForce(Vector2.down * forceScale, ForceMode2D.Impulse);
    //    }

    //    if (Input.GetKeyDown(KeyCode.Space)) {
    //        rb.velocity = Vector2.zero;
    //    }

    //    HazardsCollision();
    //    Debug.Log(rb.velocity);
    //}

    private void OnCollisionEnter2D(Collision2D collision) {



        if (collision.gameObject.GetComponent<expander>() || collision.gameObject.layer.Equals(LayerMask.NameToLayer("Hazards"))) {
            Debug.Log("DEAD");
            Destroy(gameObject);
        }


    }

    //private void HazardsCollision()
    //{
    //    if (bodyCollider.IsTouchingLayers(LayerMask.GetMask("Hazards")))
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
