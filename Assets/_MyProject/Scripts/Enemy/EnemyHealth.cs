using UnityEngine;
using UnityEngine.UI;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 10/02/23
// Description	: management of enemy health
//---------------------------------------------------------------------------------
public class EnemyHealth : MonoBehaviour
{
    [Header("Health Properties")]
    [SerializeField] private int maxHealth = 100; //How much health this enemy has
    private int currentHealth; //Current health amount of enemy
    public int Destroy;
    //This method is called whenever the enemy is damaged by an attack
    public void TakeDamage(int amount)
    {
        if (currentHealth <= 0)
        {
        //If the enemy is already defeated leave using return else can destroy
        Destroy(this.gameObject);
        Destroy += 1;
        }
        //Reduce the current health by the amount of damage
        currentHealth -= amount;
    }

    void OnEnable ()
    {
        currentHealth = maxHealth;
    }
}