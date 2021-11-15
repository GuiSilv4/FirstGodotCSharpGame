using Godot;
using System;

public class Bullet : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private int speed = 500;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        SetPhysicsProcess(true);
    }
    public override void _PhysicsProcess(float delta)
    {
        Vector2 movement = new Vector2(0, -speed * delta);
        var collidedObject = MoveAndCollide(movement);
        if(collidedObject != null){
            GD.Print("ACERTEI");
            collidedObject.IsQueuedForDeletion();
            QueueFree();
        }
    }
}
