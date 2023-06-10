# TGSAttribute
TGSAttributes is a Unity plugin that provides custom attributes to streamline game development, offering dynamic visibility and automated component fetching.

## Usage
### GetComponentAttribute
GetComponentAttribute is used to automatically fetch a component and assign it to the field it decorates.
```
public class Example : MonoBehaviour
{
    [GetComponent]
    private Rigidbody rigidbodyComponent;
}
```
In this example, the rigidbodyComponent field will be automatically assigned the Rigidbody component from the same game object, if one exists.

Similarly we can use:
```
[GetComponentInChilderen]
private Rigidbody rigidbodyComponent;

[GetComponentInParent]
private Rigidbody rigidbodyComponent;

[FindObjectOfType]
private Camera mainCamera;
```
### ShowIfAttribute
ShowIfAttribute is used to conditionally display a field in the Unity Inspector based on a boolean condition.
```
public class Example : MonoBehaviour
{
    [SerializeField]
    private bool showField = false;

    [ShowIf("showField")]
    public string conditionalField;
}
```
In this example, the conditionalField will be visible in the Unity Inspector only when showField is true.
