using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (false)
        {
            Debug.Log("Expression is true");

        }
        else if (3 == 2)
        {
            Debug.Log("two is equal to two");
        }
        else
        {
            Debug.Log("Two plus Two equal to Five");
        }
    }
    
    // Type anything you want in section "27" ("Here")
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World!");
    }
}
