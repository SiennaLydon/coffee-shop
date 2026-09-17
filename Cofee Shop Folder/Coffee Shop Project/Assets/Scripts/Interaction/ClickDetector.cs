using UnityEngine;

public class ClickDetector : MonoBehaviour
{
   //Ever frame 
   private void Update()
   {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //This is tagged "Main Camera" on the defualt camera - only one camera should be the "MainCamera"
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                IClickable clickable = hit.collider.GetComponent<IClickable>();

                clickable?.OnClick();
                //calls the interface "Iclickable"
            }
        }
    }
}