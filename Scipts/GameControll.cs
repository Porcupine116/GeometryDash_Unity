using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControll : MonoBehaviour
{

    public float JumpForse;
    private bool _isGround = false;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isGround == true)
        {
            rb.AddForce(Vector2.up * JumpForse, ForceMode2D.Impulse);
            _isGround = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            _isGround = true;
        }
        if (other.gameObject.tag == "shipi")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "stena")
        {
            Destroy(gameObject);
        }
    }
}