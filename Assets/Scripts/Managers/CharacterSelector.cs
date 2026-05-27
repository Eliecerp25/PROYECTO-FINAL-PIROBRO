// CharacterSelector.cs
// Controla qué personaje está activo en escena.
// Usa las teclas 1-2-3-4 para cambiar de personaje.
// Esto nos permite probar cada uno sin cambiar la escena.

using UnityEngine;
using PiroBros.Core;

namespace PiroBros.Managers
{
    public class CharacterSelector : MonoBehaviour
    {
        [Header("Personajes")]
        [SerializeField] private Core.Player[] characters;  // arrastrar los 4 aquí
        [SerializeField] private Camera mainCamera;

        private Core.Player activeCharacter;
        private CameraFollow cameraFollow;

        private void Awake()
        {
            cameraFollow = mainCamera.GetComponent<CameraFollow>();

            // Activar solo el primero al inicio
            SelectCharacter(0);
        }

        private void Update()
        {
            // Teclas 1-4 para cambiar personaje
            if (Input.GetKeyDown(KeyCode.Alpha1)) SelectCharacter(0);
            if (Input.GetKeyDown(KeyCode.Alpha2)) SelectCharacter(1);
            if (Input.GetKeyDown(KeyCode.Alpha3)) SelectCharacter(2);
            if (Input.GetKeyDown(KeyCode.Alpha4)) SelectCharacter(3);
        }

        private void SelectCharacter(int index)
        {
            if (index >= characters.Length) return;

            // Desactivar todos
            foreach (Core.Player character in characters)
            {
                if (character != null)
                    character.gameObject.SetActive(false);
            }

            // Activar el seleccionado
            activeCharacter = characters[index];
            activeCharacter.gameObject.SetActive(true);

            // Mover la cámara al personaje activo
            if (cameraFollow != null)
                cameraFollow.SetTarget(activeCharacter.transform);
        }
    }
}
