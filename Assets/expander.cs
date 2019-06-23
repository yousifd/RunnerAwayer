using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expander : MonoBehaviour
{

    CircleCollider2D collider;
    public Vector3 exapdnVector;
    public float expandFactor = 1.1f;
    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<CircleCollider2D>();
        exapdnVector = new Vector3(0.1f, 0.1f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale += exapdnVector;
        time += Time.deltaTime;
        if (time >= 0.5f) {
            transform.localScale *= expandFactor;
            time = 0;
        }
    }
}
