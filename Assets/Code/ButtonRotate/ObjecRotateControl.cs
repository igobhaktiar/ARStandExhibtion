using UnityEngine;
using UnityEngine.UI;

public class ObjecRotateControl : MonoBehaviour
{
    public GameObject[] objects;
    public Button[] buttons;

    private GameObject selectedObject;
    private Button selectedButton;

    void Start()
    {
        selectedObject = null;
        selectedButton = null;

        // Deactivate all buttons initially
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    for (int i = 0; i < objects.Length; i++)
                    {
                        if (objects[i] == hit.transform.gameObject)
                        {
                            // Deselect previous object and button
                            if (selectedObject != null)
                            {
                                selectedObject = null;
                                selectedButton.gameObject.SetActive(false);
                                selectedButton = null;
                            }

                            // Select new object and button
                            selectedObject = objects[i];
                            selectedButton = buttons[i];
                            selectedButton.gameObject.SetActive(true);

                            break; // Exit loop once we find a match
                        }
                    }
                }
            }
        }
    }
}
