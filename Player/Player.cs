using Godot;
using System;

public class Player : KinematicBody2D
{
    private int speed = 100;
    PackedScene bullet;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        SetProcess(true);
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

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
            
        if(Input.IsActionJustPressed("fire")){
            //spawn a bullet
            bullet = GD.Load<PackedScene>("res://Bullet/Bullet.tscn");
            var bulletInstance = (KinematicBody2D)bullet.Instance();
            //GD.Print(bulletInstance.Position);
            bulletInstance.Position = new Vector2(this.Position.x, this.Position.y - 30);
            GetTree().GetRoot().AddChild(bulletInstance);
        }
    }
}
