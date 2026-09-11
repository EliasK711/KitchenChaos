using System;
using Unity.VisualScripting;
using UnityEngine;

public class ContainerCounter : BaseCounter
{

    public event EventHandler OnPlayerGrabbedObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player) {
        if (!player.HasKitchenObject())
        {
            // Player is not carrying anything
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);

            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
    }

}
