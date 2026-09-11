using UnityEngine;

public interface IKitchenObjectParent
{
    public Transform GetKitchenObjectFollowTransform();

    public void SetKitchehnObject (KitchenObject kitchenObject);

    public KitchenObject GetKitchenObject ();
    public void ClearKitchenObject();
    public bool HasKitchenObject();
    
}
