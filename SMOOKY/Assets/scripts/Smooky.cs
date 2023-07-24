using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Smooky : MonoBehaviour
{
    [SerializeField] private SpookyText _spookyText;
    private SpriteRenderer _renderer;
    private bool _hide;
    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.enabled = false;
        _spookyText.gameObject.SetActive(false);
        StartCoroutine(DelayedShow());

    }
    private IEnumerator DelayedShow()
    {
        while (true)
        {
            var randSecsToShow = Random.Range(7, 8);
            yield return new WaitForSeconds(randSecsToShow);
            //_hide = !_hide;
            _renderer.enabled = true;
            _spookyText.gameObject.SetActive(true);
            var randSecsToHide = Random.Range(4, 5);
            yield return new WaitForSeconds(randSecsToHide);
            _renderer.enabled = false;
            _spookyText.gameObject.SetActive(false);
            print("HIDE");
            //_spookyText.ShowRandomText();
            //ulearn.me - c#
            //brackeys, blackthornprod, gaemedev guide, unity
            //infallible code
        }
    }
}
