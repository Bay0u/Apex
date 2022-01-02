using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class PlayerAnimation : MonoBehaviour
    {
        Animator animator;
        bool isDead;
        bool won;
        // Start is called before the first frame update
        void Start()
        {
            animator = GetComponent<Animator>();
            isDead = false;
            won = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                animator.SetTrigger("Pick");
               // animator.SetBool("Pick", false);
            }
            if (PlayerCharacterController.IsDead && !isDead)
            {
                animator.SetTrigger("Die");
                isDead = true;
            }
            if (Game.Objective.IsCompleted && !won)
            {
                animator.SetTrigger("Won");
                won = true;
            }

        }
    }
}
