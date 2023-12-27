using UnityEngine;

public abstract class ITrader: MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.parent.TryGetComponent(out Player player) == false)
        {
            return;
        }
        Trade(player);
    }

    protected abstract void Trade(Player player);
}