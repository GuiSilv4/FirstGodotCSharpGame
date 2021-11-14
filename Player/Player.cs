using Godot;
using System;

public class Player : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private int speed = 100;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        SetPhysicsProcess(true);
    }
    
    public override void _PhysicsProcess(float delta) {
            
        if(Input.IsActionPressed("ui_left")){
            Vector2 leftVec = new Vector2(-speed * delta, 0);
            MoveAndCollide(leftVec);
        } else if(Input.IsActionPressed("ui_right")) {
            Vector2 rightVec = new Vector2(speed * delta, 0);
            MoveAndCollide(rightVec);
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
