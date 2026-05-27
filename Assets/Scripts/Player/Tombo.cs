using PiroBros.Core;

namespace PiroBros.Player
{
    public class Tombo : Core.Player
    {
        public override string CharacterName => "Tombo";

        protected override void Initialize()
        {
            moveSpeed = 4.5f;
            jumpForce = 8f;
            currentWeapon = GetComponentInChildren<Weapon>();
        }
    }
}
