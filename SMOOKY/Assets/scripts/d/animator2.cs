using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator2 : MonoBehaviour
{
    public Animator startAnim;

    public void OnTriggerEnter2D(Collider2D other)
    {
        startAnim.SetBool("m1open", true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        startAnim.SetBool("m1open", false);
    }
}
