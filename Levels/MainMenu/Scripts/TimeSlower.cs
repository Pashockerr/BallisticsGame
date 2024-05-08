using Godot;
using System;

namespace Scripts.MainMenu
{
	public partial class TimeSlower : RigidBody2D
	{
		public override void _Ready()
		{
			ContactMonitor = true;
			MaxContactsReported = 10;
			BodyEntered += (Node b) =>
			{
				Engine.TimeScale = 0.1;
			};
		}

		public override void _Process(double delta)
		{
		}
	}
}

