using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class picclose : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _pic;

    public Animator startAnim;
    public void OnPointerClick(PointerEventData eventData)
    {
        print("CLICK ON PIC");
        _pic.SetActive(false);
        startAnim.SetBool("m2open", true);

    }
    
}
