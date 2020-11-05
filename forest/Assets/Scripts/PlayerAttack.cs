using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public float attackSpeed = 1f;
    private float attackCDR = 0.6f;
    const float shotCDR = 5f;
    private float attackDelay = 0.3f;
    private float lastAction;

    private bool isFighting = false;
    public event System.Action onShotFired;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCDR -= Time.deltaTime;
        if (Time.time - lastAction > shotCDR)
        {
            isFighting = false;
        }
             
    }

    public bool enableFight()
    {
        return isFighting;
    }

    public void Fire()
    {
        if(shotCDR <= 0)
        {
            //check if null. If yes call the animator
            onShotFired?.Invoke();
        }
        attackCDR = 1f / attackDelay;
        isFighting = true;
        //check if ready to go again
        lastAction = Time.time;
    }

    public void Attack_AnimationEvent()
    {
        //get out of attack animation when combat ends.
    }
}
