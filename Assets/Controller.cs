using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    Rigidbody2D rb;
    float forceScale = 4;

    // Start is called before the first frame update
    void Start() {
        Physics2D.gravity = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.D)) {
            //if (rb.velocity.normalized != Vector2.right) {
            //    rb.velocity = Vector2.zero;
            //}
            rb.AddForce(Vector2.right * forceScale, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            //if (rb.velocity.normalized != Vector2.left) {
            //    rb.velocity = Vector2.zero;
            //}
            rb.AddForce(Vector2.left * forceScale, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            //if (rb.velocity.normalized != Vector2.up) {
            //    rb.velocity = Vector2.zero;
            //}
            rb.AddForce(Vector2.up * forceScale, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            //if (rb.velocity.normalized != Vector2.down) {
            //    rb.velocity = Vector2.zero;
            //}
            rb.AddForce(Vector2.down * forceScale, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = Vector2.zero;
        }

        Debug.Log(rb.velocity);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<expander>()) {
            Debug.Log("DEAD");
            Destroy(gameObject);
        }
    }
}
