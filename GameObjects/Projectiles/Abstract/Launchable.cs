using Godot;

namespace GameObjects.Projectiles.Abstract
{
    public abstract partial class Launchable : RigidBody2D
    {
        public abstract void Launch();
    }
}