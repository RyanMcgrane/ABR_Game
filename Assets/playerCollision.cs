using UnityEngine;

public class playerCollision : MonoBehaviour {

    public playerMov movement;

    void OnCollisionEnter( Collision collisionInfo)
    {
        if ( collisionInfo.collider.tag == "Obstacle" )
        {

            movement.enabled = false;
        }
    }
}
