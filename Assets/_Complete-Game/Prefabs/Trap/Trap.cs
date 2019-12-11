using System.Collections;
using System.Collections.Generic;
using Completed;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private Animator animator;
    private string activateName = "Activate";
    public enum TriggerType
    {
        Trigger,
        Boolean
    }
    public TriggerType triggerType;
    public int damage;

    void Awake()
    {
        animator = this.GetComponent<Animator>();
    }

    public void ActivateTrap(Player player)
    {
        if (triggerType == TriggerType.Trigger)
        {
            animator.SetTrigger(activateName);
        }
        else
        {
            animator.SetBool(activateName, true);
        }
        //Call the LoseFood function of hitPlayer passing it playerDamage, the amount of foodpoints to be subtracted.
        player.LoseFood(damage);
    }
}
