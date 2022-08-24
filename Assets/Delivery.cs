using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color (0, 164, 255, 255);
    [SerializeField] Color32 noPackageColor = new Color (255, 0, 0, 255);

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("...Opps, hope my car is ok...");
/*        if (other.tag == "House")
        {
            Debug.Log("You dont think they notice the damage on the house... right?");
        }
        if (other.tag == "Rock")
        {
            Debug.Log("...Why is there a rock here!?");
        }
        if (other.tag == "Tree")
        {
            Debug.Log("I hit a tree... But there was no damage to the car!  Let's keep driving!");
        }

        cant use other.tag in here, doesnt recgonize
*/
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Picked up the Package!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package has been dropped off!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
