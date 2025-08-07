using Unity.Netcode;
using UnityEngine;

public class PlayerInteractionController : NetworkBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (!IsOwner)
        {
            return;
        }
        if (other.gameObject.TryGetComponent(out ICollectible collectable))
            {
                collectable.Collect();
            }
    }
}

