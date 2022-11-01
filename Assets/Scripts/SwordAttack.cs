using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    
    public Collider2D swordCollider;
    Vector2 rightAttackOffset;

    public float damage = 3;

    private void Start() {
        rightAttackOffset = swordCollider.offset;
    }
    public void AttackRight() {
        swordCollider.enabled = true;
        swordCollider.offset = rightAttackOffset;
        print(swordCollider.offset);
    }

    public void AttackLeft() {
        swordCollider.enabled = true;
        swordCollider.offset = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
        print(swordCollider.offset);
    }

    public void StopAttack() {
        swordCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemy") {
            // deal some fuckin damage, guy
            Enemy enemy = other.GetComponent<Enemy>();
            print(enemy.Health);
            Animator enemyAnimator = other.GetComponent<Animator>();
            if (enemy != null) {
                enemyAnimator.SetTrigger("DamageTrigger");
                enemy.Health -= damage;
            }
        }
    }
}
