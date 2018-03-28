using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class Navigation : MonoBehaviour, INavigationHandler
{
    InputManager inputManager;

    public void OnNavigationCanceled(NavigationEventData eventData)
    {
        print("OnNavigationCanceled");
        eventData.Use();
    }

    public void OnNavigationCompleted(NavigationEventData eventData)
    {
        print("OnNavigationCompleted: " + eventData.NormalizedOffset);
        // eventData.NormalizedOffset.x = -1.0 left, 1.0 right
        // eventData.NormalizedOffset.y = -1.0 down, 1.0 up 
        eventData.Use();
    }

    public void OnNavigationStarted(NavigationEventData eventData)
    {
        print("OnNavigationStarted: " + eventData.NormalizedOffset);
        eventData.Use();
    }

    public void OnNavigationUpdated(NavigationEventData eventData)
    {
        eventData.Use();
    }

    // Use this for initialization
    void Start () {
        print("Navigation Start");

        inputManager = InputManager.Instance;
        inputManager.AddGlobalListener(this.gameObject);
    }

    void OnDestroy()
    {
        inputManager.RemoveGlobalListener(this.gameObject);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
