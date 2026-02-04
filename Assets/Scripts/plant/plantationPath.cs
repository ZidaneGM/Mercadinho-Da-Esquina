using UnityEngine;

public class plantationPath : MonoBehaviour
{
    [SerializeField] public GameObject selectSlot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SetSlot(GameObject slot)
    {
        selectSlot = slot;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
