using PiroBros.Core;

namespace PiroBros.Player
{
    public class OctavioMesa : Core.Player
    {
        public override string CharacterName => "Octavio Mesa";

        protected override void Initialize()
        {
            moveSpeed = 7f;
            jumpForce = 8f;
            currentWeapon = GetComponentInChildren<Weapon>();
        }
    }
}
