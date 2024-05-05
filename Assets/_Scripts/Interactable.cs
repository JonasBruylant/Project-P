using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isPlayerInRange = false;
    public KeyCode keyToInteract;
    public UnityEvent interactAction;


    private void Update()
    {
        if (!isPlayerInRange || !Input.GetKeyDown(keyToInteract)) return;

        interactAction.Invoke();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player") return;
        isPlayerInRange = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag != "Player") return;
        isPlayerInRange = false;
    }




}
