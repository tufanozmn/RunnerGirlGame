using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    Animator m_Animator;

    bool m_run;
    
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        m_run = false;
    }

        void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            m_run = true;
        }

        else
        {
            m_run = false;
        }

    }
}
