using UnityEngine;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 10/02/23
// Description	: sword damage script
//---------------------------------------------------------------------------------
public class SwordAttack : MonoBehaviour
{
    [SerializeField] private int DealDamageAmount = 10;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Test");
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            enemyHealth.TakeDamage(DealDamageAmount);
            //Destroy(other.gameObject);
        }
    }
}