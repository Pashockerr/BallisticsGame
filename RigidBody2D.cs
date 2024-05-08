using Godot;
using System;

public partial class RigidBody2D : Godot.RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//this.Freeze = true;
		//this.ApplyCentralForce(Vector2.Up * 5 + Vector2.Right * 5);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
