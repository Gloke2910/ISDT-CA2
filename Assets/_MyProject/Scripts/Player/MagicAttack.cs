using UnityEngine;
//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 15/2/23
// Description	: Magic projectile attack 
//---------------------------------------------------------------------------------

public class MagicAttack : MonoBehaviour
{
    [Header ("Fireball Properties")]
    public GameObject pf_FireBall;
    [SerializeField] private GameObject fireBallPt;
    [SerializeField] private float fireBallSpeed = 200f;
    [SerializeField] private float fireBallLife = 2f;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
        // Instantiate a pf_FireBall at fireBallPt position and no rotation
        // Call it with a grab interactable activate event 
        GameObject tmpFireBall;
        tmpFireBall = Instantiate(pf_FireBall, fireBallPt.transform.position, Quaternion.identity);
        tmpFireBall.GetComponent<Rigidbody>().AddForce(fireBallPt.transform.forward * fireBallSpeed);

        Destroy(tmpFireBall.transform.gameObject, fireBallLife); // Destroys the fireball
        }
    }
}
