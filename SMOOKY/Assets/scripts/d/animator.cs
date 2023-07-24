using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    public Animator startAnim;

    public void OnTriggerEnter2D(Collider2D other)
    {
        startAnim.SetBool("m0open", true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        startAnim.SetBool("m0open", false);
    }
}
