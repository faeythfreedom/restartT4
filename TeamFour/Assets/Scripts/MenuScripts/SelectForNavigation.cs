using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectForNavigation : MonoBehaviour
{
    public bool selectOnActivate = true;

    void OnEnable()
    {
        if (selectOnActivate) Invoke("Select", 0.1f);
    }

    public void Select()
    {
        GetComponent<Selectable>().Select();
    }
}