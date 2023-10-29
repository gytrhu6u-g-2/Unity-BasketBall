using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 左クリックでボールを上に跳ねさせる
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(new Vector2(0, 8), ForceMode2D.Impulse);
        }
    }
}
