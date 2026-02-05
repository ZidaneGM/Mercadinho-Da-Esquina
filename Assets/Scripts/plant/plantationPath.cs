using UnityEngine;

public class plantationPath : MonoBehaviour
{
    [SerializeField] public GameObject selectSlot;
    [SerializeField] public int selectSeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void SetSlot(GameObject slot)
    {
        selectSlot = slot;
    }
    public void SetSeed(int seed)
    {
        selectSeed = seed;
    }


}
