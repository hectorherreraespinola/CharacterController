using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonigoteController : MonoBehaviour
{   
    
    private Animator animator;
    private const string MOVE_HANDS = "Move Hands";
    private bool isMovingHands = false;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool(MOVE_HANDS,isMovingHands);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isMovingHands = !isMovingHands;
            animator.SetBool(MOVE_HANDS, isMovingHands);

        }
    }
}
