using UnityEngine;
using UnityEngine.Events;

public class UnityEventOnTrigger2D : MonoBehaviour
{
    public string tagToActivate = "Player";
    public UnityEvent onTriggerEnter, onTriggerExit;

    private void Awake()
    {
        if (GetComponent<Collider2D>() == null)
            Debug.LogWarning($"{gameObject} saknar Collider2D!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(tagToActivate))
        {
            onTriggerEnter.Invoke();
            Debug.Log("Trigger (enter) aktiverad på " + gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(tagToActivate))
        {
            onTriggerExit.Invoke();
            Debug.Log("Trigger (exit) aktiverad på " + gameObject);
        }
    }
}

