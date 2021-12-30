using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class PlayerAnimation : MonoBehaviour
    {
        Animator animator;
        // Start is called before the first frame update
        void Start()
        {
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                animator.SetTrigger("Pick");
               // animator.SetBool("Pick", false);
            }
            if (PlayerCharacterController.IsDead)
            {
                animator.SetTrigger("Die");
            }
            if (Game.Objective.IsCompleted)
            {
                animator.SetTrigger("Won");
            }

        }
    }
}
