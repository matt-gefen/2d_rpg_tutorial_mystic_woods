using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator animator;
    public float Health {
        set {
            health = value;
            if(health <= 0) {
                Defeated();
            }
        }
        get {
            return health;
        }
    }
    public float health = 6;

    public void Defeated() {
        // run death animation and remove entity from game world
        animator.SetBool("isDead", true);
    }

    public void DestroyEnemy() {
        Destroy(gameObject);
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        
    }
}
