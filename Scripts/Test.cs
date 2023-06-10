using TGSAttributes;
using UnityEngine;

public class Test : MonoBehaviour
{
    GameObject go;

    [GetComponent]
    public Transform tran;

    [FindObjectOfType]
    [ShowIf("showCam")]
    public Camera tran1;

    public bool showCam;

    [Button("Test")]
    public void TestMethod()
    {
        Debug.Log("Tested");
    }
}