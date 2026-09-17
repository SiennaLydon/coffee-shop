//THIS IS SCRIPT B
using UnityEngine;
using UnityEngine.Events;

public class ClickableObjects : MonoBehaviour, IClickable 
{
    [SerializeField] private UnityEvent onClickAction;

    public void OnClick()
    {
        onClickAction?.Invoke();
        Debug.Log("Found a clickable object");
    }
}