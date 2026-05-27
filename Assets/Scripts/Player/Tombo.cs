using PiroBros.Core;

namespace PiroBros.Player
{
    public class Tombo : Core.Player
    {
        public override string CharacterName => "Tombo";

        protected override void Initialize()
        {
            moveSpeed = 4.5f;
            jumpForce = 11f;
            currentWeapon = GetComponentInChildren<Weapon>();
        }
    }
}
