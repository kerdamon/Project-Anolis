﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logistics
{
    public class UpgradeBuildingMenu : Menu
    {
        private Builder _builder;

        public override void Show()
        {
            Debug.Log("Showing Upgrade Menu");
        }

        protected override void Awake()
        {
            _builder = GetComponentInChildren<Builder>();
            base.Awake();
        }

        public override void ManageClick()
        {
            _builder.Destroy(UnoptimalTileSelector.ExtractTileFromPlanet(Raycast.HitData));
            Hide();
        }

        public override bool CheckIfValidForSelection()
        {
            var tile = UnoptimalTileSelector.ExtractTileFromPlanet(Raycast.HitData);
            return tile.TileContent != null;
        }
    }
}