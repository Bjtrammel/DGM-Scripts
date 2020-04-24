using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehavior : MonoBehaviour
{
    
    private Text textObj;
    public UnityEvent awakeEvent;

    void Start()
    {
        textObj = GetComponent<Text>();
        awakeEvent.Invoke();
    }

/*    void Update()
    {
        textObj.text = stringListDataObj.ReturnCurrentLine();
    }*/
    
    public void UpdateText(StringListData stringListDataObj)
    {
        textObj.text = stringListDataObj.ReturnCurrentLine();
    }
    
    public void UpdateText(IntData intDataObj)
    {
        textObj.text = intDataObj.value.ToString();
    }
}
