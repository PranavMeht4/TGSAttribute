# TGSAttribute
TGSAttributes is a Unity plugin that provides custom attributes to streamline game development, offering dynamic visibility and automated component fetching.

## Usage
### GetComponentAttribute
`GetComponentAttribute` is used to automatically fetch a component and assign it to the field it decorates.
```csharp
public class Example : MonoBehaviour
{
    [GetComponent]
    private Rigidbody rigidbodyComponent;
}
```
In this example, the rigidbodyComponent field will be automatically assigned the Rigidbody component from the same game object, if one exists.

Similarly we can use:
```csharp
[GetComponentInChilderen]
private Rigidbody rigidbodyComponent;

[GetComponentInParent]
private Rigidbody rigidbodyComponent;

[FindObjectOfType]
private Camera mainCamera;
```
### ShowIfAttribute
`ShowIfAttribute` is used to conditionally display a field in the Unity Inspector based on a boolean condition.
```csharp
public class Example : MonoBehaviour
{
    [SerializeField]
    private bool showField = false;

    [ShowIf("showField")]
    public string conditionalField;
}
```
In this example, the conditionalField will be visible in the Unity Inspector only when showField is true.

### ButtonAttribute
`ButtonAttribute` can be used to add a clickable button to the Unity Inspector for a method in your script.

```csharp
public class Example : MonoBehaviour
{
    [Button("Custom Button Name")]
    public void ButtonClicked()
    {
        Debug.Log("Button clicked!");
    }
}
```
In this example, a button with the label "Custom Button Name" will appear in the Unity Inspector. When clicked, it will call the ButtonClicked method and print "Button clicked!" to the console.

Currently, ButtonAttribute only supports parameterless methods. This means the method it decorates should not take any arguments.

## TODO

1. Provide parameter support in `ButtonAttribute`. This would allow the attribute to be used with methods that take arguments, further increasing its flexibility and usefulness.
2. Add `GetComponentsInChildrenAttribute` to fetch multiple fields from children of the current GameObject. This can be useful when working with GameObjects that have multiple instances of a component attached to their children.
3. Add `GetComponentsInParentAttribute` to fetch multiple fields from parents of the current GameObject. This can be useful when you want to reference multiple instances of a component that exist on parent GameObjects in the hierarchy.
4. Optimize TGSEditor performance: Improve the performance of TGSEditor by reducing the frequency of reflection calls, possibly by caching field and method information or implementing a smarter update policy.
