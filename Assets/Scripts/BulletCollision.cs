using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    [SerializeField] GameObject brokenBottle;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bottle")
        {
            Debug.Log(collision.gameObject.tag);

            //////////////////////////////////////////// MY CODE START ////////////////////////////////////////
            Destroy(collision.gameObject);
            //////////////////////////////////////////// MY CODE END //////////////////////////////////////////
            
            Instantiate(brokenBottle, transform.position, transform.rotation);
        }

        //////////////////////////////////////////// MY CODE START ////////////////////////////////////////
        if (collision.gameObject.tag == "Target")
        {
            Debug.Log(collision.gameObject.tag);
            collision.gameObject.GetComponent<Animator>().SetBool("isHit", true);
            Destroy(collision.gameObject, 1);
        }
        //////////////////////////////////////////// MY CODE END //////////////////////////////////////////
    }
}
