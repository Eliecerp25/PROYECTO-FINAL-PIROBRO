using PiroBros.Core;

namespace PiroBros.Player
{
    public class Shakira : Core.Player
    {
        public override string CharacterName => "Shakira";

        protected override void Initialize()
        {
            moveSpeed = 10f;
            jumpForce = 16f;
            currentWeapon = GetComponentInChildren<Weapon>();
        }
    }
}
