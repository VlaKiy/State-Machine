using UnityEngine;

public abstract class State
{
    public abstract void Enter();

    public abstract void Exit();

    public virtual void Update() { }

    public virtual void FixedUpdate() { }

    public virtual void OnCollisionEnter(Collision collision) { }

    public virtual void OnTriggerEnter(Collider collider) { }
}