using PiroBros.Core;

namespace PiroBros.Player
{
    public class Diomedes : Core.Player
    {
        public override string CharacterName => "Diomedes";

        protected override void Initialize()
        {
            moveSpeed = 6f;
            jumpForce = 8f;
            currentWeapon = GetComponentInChildren<Weapon>();
        }
    }
}
