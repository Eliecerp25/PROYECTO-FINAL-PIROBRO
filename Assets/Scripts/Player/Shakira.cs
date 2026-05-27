using PiroBros.Core;

namespace PiroBros.Player
{
    public class Shakira : Core.Player
    {
        public override string CharacterName => "Shakira";

        protected override void Initialize()
        {
            moveSpeed = 10f;
            jumpForce = 8f;
            currentWeapon = GetComponentInChildren<Weapon>();
        }
    }
}
