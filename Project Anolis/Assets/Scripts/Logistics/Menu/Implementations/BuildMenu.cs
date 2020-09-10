﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logistics
{
    public class BuildMenu : RadialMenu
    {
        private Builder _builder;
        [SerializeField] private List<TileContent> _buildingList;

        public override void Show()
        {
            Debug.Log("Showing Build Menu");
        }

        protected override void Awake()
        {
            _builder = GetComponent<Builder>();
            base.Awake();
        }

        public override void ManageClick()
        {
            _builder.Build(_buildingList[0], ref UnoptimalTileSelector.ExtractTileFromPlanet(Raycast.HitData), UnoptimalTileSelector.ExtractTransformFromPlanet(Raycast.HitData));
            Hide();
        }

        public override bool CheckIfValidForSelection()
        {
            var tile = UnoptimalTileSelector.ExtractTileFromPlanet(Raycast.HitData);
            return tile.IsEmpty();
        }
    }
}