
using libx;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActDemo
{
    public class MyPlayer : PlayerBase
    {
        public static Vector3 MainPlayerBornVector = Vector3.zero;
        public const string PrefabPath = "Assets/Res/Character.prefab";
        private CharacterNetMoveController charMoveController;
        public CharacterNetMoveController CharMoveController { get { return CharMoveController; } }

        private Character character;
        public Character Character { get { return character; } }
        public MyPlayer(Character character, CharacterNetMoveController controller, int uid, GameObject obj, AssetRequest request) : base(uid, obj, request)
        {
            this.charMoveController = controller;
            this.character = character;
        }
    }
}
