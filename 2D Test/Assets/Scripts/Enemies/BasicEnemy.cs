using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public Animator enemyAnimator; // Reference to the Animator component.

    private bool isDead = false;
    public int currentHP = 3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isDead && collision.gameObject.CompareTag("Bullet"))
        {

            currentHP--;

            if(currentHP <= 0){
                // Trigger the "IsDead" animation.
            enemyAnimator.SetTrigger("IsDead");

            // Set the "isDead" flag to true to prevent further collisions.
            isDead = true;

            // Optionally, you can disable the collider to prevent additional collisions.
            GetComponent<Collider2D>().enabled = false;

            // Calculate the length of the "IsDead" animation and destroy the object after that duration.
            float animationLength = enemyAnimator.GetCurrentAnimatorClipInfo(0)[0].clip.length;
            Destroy(gameObject, animationLength);
            }
        }
    }
}
