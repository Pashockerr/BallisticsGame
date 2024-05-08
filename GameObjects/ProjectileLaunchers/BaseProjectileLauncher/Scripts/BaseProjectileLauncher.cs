using System.Diagnostics;
using System.Linq;
using GameObjects.Projectiles.Abstract;
using Godot;

namespace Scripts.ProjectileLaunchers{
	public partial class BaseProjectileLauncher : Node2D
	{
		[Export]
		private RigidBody2D _launchable;
		private Button _launchButton;

        public override void _Ready()
        {
			_launchButton = (from n in GetTree().GetNodesInGroup("ProjectileLauncherInterface")
						where n is Button && n.UniqueNameInOwner && n.Name == "LaunchButton"
						select n).First() as Button;
			_launchButton.Pressed += (_launchable as Launchable).Launch;
        }
    }
}
