using GameObjects.Projectiles.Abstract;
using Godot;
using System;
using System.Diagnostics;
using System.Linq;

namespace Scripts.Projectiles
{
	public partial class BaseProjectile : Launchable
	{
		private LineEdit _angleEdit;
		private LineEdit _velocityEdit;
		[Export]
		private int _launchCounter = 1;
		public override void _Ready()
		{
			_angleEdit = (from n in GetTree().GetNodesInGroup("ProjectileLauncherInterface")
						where n is LineEdit && n.UniqueNameInOwner && n.Name == "AngleLineEdit"
						select n).First() as LineEdit;
			_velocityEdit = (from n in GetTree().GetNodesInGroup("ProjectileLauncherInterface")
						where n is LineEdit && n.UniqueNameInOwner && n.Name == "VelocityLineEdit"
						select n).First() as LineEdit;

			Freeze = true;
		}

		public override void _Process(double delta)
		{
		}

		public override void Launch()
		{
			if(_launchCounter <= 0) return;
			var angleRad = float.Parse(_angleEdit.Text) / 360 * Math.PI * 2;
			var velocity = float.Parse(_velocityEdit.Text);
			Freeze = false;
			LinearVelocity = new Vector2
			{
				X = (float)Math.Cos(angleRad) * velocity * 100,
				Y = -(float)Math.Sin(angleRad) * velocity * 100
			};
			_launchCounter--;
		}
	}
}
