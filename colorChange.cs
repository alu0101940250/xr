using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class colorChange : MonoBehaviour
{
    public Color colSelected = Color.purple;
    private Renderer renderer;
    private Color colOriginal;
    private XRBaseInteractable interactable;
    
    private void Awake(){
    	renderer = GetComponent<Renderer>();
    	interactable = GetComponent<XRBaseInteractable>();
    	colOriginal = renderer.material.color;
    }
    
    private void OnEnable(){
    	interactable.selectEntered.AddListener(OnSelected);
    	interactable.selectExited.AddListener(OnDeselected);
    }
    
    private void OnDisable(){
    	interactable.selectEntered.RemoveListener(OnSelected);
    	interactable.selectExited.RemoveListener(OnDeselected);
    }
    
    private void OnSelected(SelectEnterEventArgs args){
    	renderer.material.color = colSelected;
    }
    
    private void OnDeselected(SelectExitEventArgs args){
    	renderer.material.color = colOriginal;
    }

}
