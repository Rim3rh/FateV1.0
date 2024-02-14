using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEnemyHealth : MonoBehaviour, IDamageable
{

    [SerializeField] GameObject game;
    [SerializeField] int health;
    private bool isDead;
    public void TakeDamage(int damge)
    {
        health -= damge;
        if (health < 0 && !isDead)
        {
            GetComponent<Animator>().SetTrigger("Die");
            GetComponent<DissolvingControllerTut>().Disolve();
        }
    }



    private void TurnOff()
    {
        game.SetActive(false);
    }
}
