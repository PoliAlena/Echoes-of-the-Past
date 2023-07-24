using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class pic : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _pic;
    public Animator startAnim;

   

    public void OnPointerClick(PointerEventData eventData)
    {
        print("CLICK ON PIC");
        _pic.SetActive(true);
        startAnim.SetBool("m1open", false);
    }
}
