using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
private void OnCollisionEnter2D(Collision2D collision)
//mb postavit tag
 {
   if (collision.gameObject.name == "Hero") {
    collision.gameObject.transform.SetParent(transform);
   }
}

private void OnCollisionExit2D(Collision2D collision)
//mb postavit tag
 {
   if (collision.gameObject.name == "Hero") {
    collision.gameObject.transform.SetParent(null);
   }
}

}
