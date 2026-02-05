using UnityEngine;

public class ShowLog : MonoBehaviour
{
// Start is called before the first frame update
void Start()
{
Debug.Log("Hello World!");
}
void Update()
{
    Debug.Log("Update called! " + Time.frameCount);
}
}