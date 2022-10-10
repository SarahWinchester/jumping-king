using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;

    private rigidbody2D;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
         animator = getComponent<Animator>();
         rigidbody2D = getComponent<rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.getKeyDown(keyCode.Space)){
            animator.setBool("isJumping", true);
            rigidbody2D.AddForce(new Vetor2(0, jumpForce));
        }
    }
}
