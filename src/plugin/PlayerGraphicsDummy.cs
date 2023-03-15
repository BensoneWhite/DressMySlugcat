﻿using BepInEx;
using System.Security.Permissions;
using System.Security;
using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using DressMySlugcat.Hooks;
using System.IO;
using Menu;
using IL.Menu.Remix;

namespace DressMySlugcat
{
    public class PlayerGraphicsDummy
    {
        public FSprite[] Sprites;
        public FContainer Container;
        public Vector2 SlugcatPosition
        {
            get 
            { 
                return Sprites[0].GetPosition(); 
            }
            set
            {
                Sprites[0].SetPosition(value);
                UpdateSpritePositions();
            }
        }

        FAtlas atlas;

        public PlayerGraphicsDummy()
        {
            Container = new FContainer();
            Futile.stage.AddChild(Container);

            Sprites = new FSprite[10];
            Sprites[0] = new FSprite("BodyA");
            Sprites[1] = new FSprite("HipsA");
            TriangleMesh.Triangle[] tris = new TriangleMesh.Triangle[13]
            {
                new TriangleMesh.Triangle(0, 1, 2),
                new TriangleMesh.Triangle(1, 2, 3),
                new TriangleMesh.Triangle(4, 5, 6),
                new TriangleMesh.Triangle(5, 6, 7),
                new TriangleMesh.Triangle(8, 9, 10),
                new TriangleMesh.Triangle(9, 10, 11),
                new TriangleMesh.Triangle(12, 13, 14),
                new TriangleMesh.Triangle(2, 3, 4),
                new TriangleMesh.Triangle(3, 4, 5),
                new TriangleMesh.Triangle(6, 7, 8),
                new TriangleMesh.Triangle(7, 8, 9),
                new TriangleMesh.Triangle(10, 11, 12),
                new TriangleMesh.Triangle(11, 12, 13)
            };
            TriangleMesh triangleMesh = new TriangleMesh("Futile_White", tris, customColor: false);
            Sprites[2] = triangleMesh;
            Sprites[3] = new FSprite("HeadA0");
            Sprites[4] = new FSprite("LegsA0");
            Sprites[5] = new FSprite("PlayerArm12");
            Sprites[6] = new FSprite("PlayerArm12");
            Sprites[7] = new FSprite("OnTopOfTerrainHand");
            Sprites[8] = new FSprite("OnTopOfTerrainHand");
            Sprites[8].scaleX = -1f;
            Sprites[9] = new FSprite("FaceA0");

            Sprites[9].color = new Color(0.1f, 0.1f, 0.1f);

            AddToContainer();
        }

        public void AddToContainer()
        {
            foreach (var sprite in Sprites)
            {
                Container.AddChild(sprite);
            }
        }

        public void UpdateSpritePositions()
        {
            var baseSprite = Sprites[0];

            Sprites[0].x = 0 + baseSprite.x;
            Sprites[0].y = 0 + baseSprite.y;
            Sprites[0].anchorX = 0.5f;
            Sprites[0].anchorY = 0.7894737f;
            Sprites[0].scaleX = 0.9551261f;
            Sprites[0].scaleY = 1;
            Sprites[0].rotation = 4.872149f;
            Sprites[1].x = -1.000122f + baseSprite.x;
            Sprites[1].y = -11.73291f + baseSprite.y;
            Sprites[1].anchorX = 0.5f;
            Sprites[1].anchorY = 0.5f;
            Sprites[1].scaleX = 1.002563f;
            Sprites[1].scaleY = 1;
            Sprites[1].rotation = -175.3343f;
            Sprites[2].isVisible = false;
            Sprites[3].x = -0.04528809f + baseSprite.x;
            Sprites[3].y = 2.469299f + baseSprite.y;
            Sprites[3].anchorX = 0.5f;
            Sprites[3].anchorY = 0.5f;
            Sprites[3].scaleX = 1;
            Sprites[3].scaleY = 1;
            Sprites[3].rotation = 3.578826f;
            Sprites[4].x = -0.0001831055f + baseSprite.x;
            Sprites[4].y = -23.5994f + baseSprite.y;
            Sprites[4].anchorX = 0.5f;
            Sprites[4].anchorY = 0.25f;
            Sprites[4].scaleX = 1;
            Sprites[4].scaleY = 1;
            Sprites[4].rotation = 0;
            Sprites[5].x = -21f + baseSprite.x;
            Sprites[5].y = -2.017578f + baseSprite.y;
            Sprites[5].anchorX = 0.9f;
            Sprites[5].anchorY = 0.5f;
            Sprites[5].scaleX = 1;
            Sprites[5].scaleY = -1;
            Sprites[5].rotation = 180f;
            Sprites[6].x = 21f + baseSprite.x;
            Sprites[6].y = -2 + baseSprite.y;
            Sprites[6].anchorX = 0.9f;
            Sprites[6].anchorY = 0.5f;
            Sprites[6].scaleX = 1;
            Sprites[6].scaleY = 1;
            Sprites[6].rotation = 0f;
            Sprites[7].isVisible = false;
            Sprites[8].isVisible = false;
            Sprites[9].x = -0.04528809f + baseSprite.x;
            Sprites[9].y = 0.4692993f + baseSprite.y;
            Sprites[9].anchorX = 0.5f;
            Sprites[9].anchorY = 0.5f;
            Sprites[9].scaleX = 1;
            Sprites[9].scaleY = 1;
            Sprites[9].rotation = 0;
        }
    }
}