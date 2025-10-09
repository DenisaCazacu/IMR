using UnityEngine;

public class ProximityAnimation : MonoBehaviour
{
    public Transform cat;
    public Transform tiger;

    public Animator catAnimator;
    public Animator tigerAnimator;

    private bool hasTriggered = false;

    void Update()
    {
        if (cat == null || tiger == null || catAnimator == null || tigerAnimator == null)
            return;

        float distance = Vector3.Distance(cat.position, tiger.position);

        if (distance < 0.25f && !hasTriggered)
        {
            hasTriggered = true;
            catAnimator.SetTrigger("TriggerWalk");
            tigerAnimator.SetTrigger("TriggerWalk");
        }
        else if (distance >= 0.25f && hasTriggered)
        {
            catAnimator.SetTrigger("TriggerIdle");
            tigerAnimator.SetTrigger("TriggerIdle");
            hasTriggered = false;
        }
    }

}
