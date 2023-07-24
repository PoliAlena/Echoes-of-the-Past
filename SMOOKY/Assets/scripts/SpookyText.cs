using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpookyText : MonoBehaviour
{
    [SerializeField] private string[] _messages;
    private TextMeshProUGUI _text;
    private void OnEnable()
    {
        if(_text == null)
            _text = GetComponent<TextMeshProUGUI>();
        ShowRandomText();
    }
    public void ShowRandomText()
    {
        var textIndex = Random.Range(0, _messages.Length);
        _text.text = _messages[textIndex];
    }
}
