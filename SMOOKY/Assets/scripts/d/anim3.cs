using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim3 : MonoBehaviour
{
    public Animator startAnim;

    

    public void OnTriggerExit2D(Collider2D other)
    {
        startAnim.SetBool("m2open", false);
    }
}
