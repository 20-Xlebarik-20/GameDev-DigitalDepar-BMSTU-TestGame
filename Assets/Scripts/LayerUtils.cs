using UnityEngine;

namespace LearnGame
{
    public class LayerUtils
    {
        public const string BulletLayerName = "Bullet";
        public const string PickUpLayerName = "PickUp";
        public const string PlayerLayerName = "Player";
        public const string EnemyLayerName = "Enemy";

        public static readonly int BulletLayer = LayerMask.NameToLayer(BulletLayerName);
        public static readonly int PickUpLayer = LayerMask.NameToLayer(PickUpLayerName);

        public static readonly int CharactersMask = LayerMask.GetMask(EnemyLayerName, PlayerLayerName);
        public static readonly int PickUpsMask = LayerMask.GetMask(PickUpLayerName);

        public static bool IsBullet(GameObject other) => other.layer == BulletLayer;
        public static bool IsPickUp(GameObject other) => other.layer == PickUpLayer;

    }
}
