using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class presentPickUp : MonoBehaviour
{
    public TMP_Text message;
    private XRGrabInteractable interactable;
    
    public void Awake(){
    	interactable = GetComponent<XRGrabInteractable>();
    }
    
    private void OnEnable(){
    	interactable.selectEntered.AddListener(OnGrabbed);
    	interactable.selectExited.AddListener(OnReleased);
    }
    
    private void OnDisable(){
    	interactable.selectEntered.RemoveListener(OnGrabbed);
    	interactable.selectExited.RemoveListener(OnReleased);
    }
    
    private void OnGrabbed(SelectEnterEventArgs args){
    	message.text = "Present grabbed";
    }
    
    private void OnReleased(SelectExitEventArgs args){
    	message.text = "Present released";
    }
}
