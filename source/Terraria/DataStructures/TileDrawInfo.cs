using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using Terraria.Utilities;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000679")]
	public class TileDrawInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003741")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E4A4", Offset = "0x141E4A4", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUserGameState.<>c", Member = "<.ctor>b__331_0", ReturnType = typeof(TileDrawInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public TileDrawInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400783C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public SpriteBatch spriteBatch;

		[global::Cpp2ILInjected.Token(Token = "0x400783D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public SpriteBatch spriteBatch2;

		[global::Cpp2ILInjected.Token(Token = "0x400783E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int tileIndex;

		[global::Cpp2ILInjected.Token(Token = "0x400783F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public uint tilePalIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4007840")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Tile tileCache;

		[global::Cpp2ILInjected.Token(Token = "0x4007841")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public ushort typeCache;

		[global::Cpp2ILInjected.Token(Token = "0x4007842")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E")]
		public short tileSHeader;

		[global::Cpp2ILInjected.Token(Token = "0x4007843")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public short tileFrameX;

		[global::Cpp2ILInjected.Token(Token = "0x4007844")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		public short tileFrameY;

		[global::Cpp2ILInjected.Token(Token = "0x4007845")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public unsafe uint* tileLookup;

		[global::Cpp2ILInjected.Token(Token = "0x4007846")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public unsafe ushort* tileTypeData;

		[global::Cpp2ILInjected.Token(Token = "0x4007847")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public unsafe short* tileTypeSHeader;

		[global::Cpp2ILInjected.Token(Token = "0x4007848")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public unsafe byte* tileTypeLiquid;

		[global::Cpp2ILInjected.Token(Token = "0x4007849")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public unsafe byte* tileTypeBHeader;

		[global::Cpp2ILInjected.Token(Token = "0x400784A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public unsafe byte* tileTypeBHeader3;

		[global::Cpp2ILInjected.Token(Token = "0x400784B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public unsafe ushort* tileTypeWall;

		[global::Cpp2ILInjected.Token(Token = "0x400784C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public unsafe short* tileTypeFrameX;

		[global::Cpp2ILInjected.Token(Token = "0x400784D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public unsafe short* tileTypeFrameY;

		[global::Cpp2ILInjected.Token(Token = "0x400784E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public int lightMinX;

		[global::Cpp2ILInjected.Token(Token = "0x400784F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		public int lightMinY;

		[global::Cpp2ILInjected.Token(Token = "0x4007850")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public int lightMaxX;

		[global::Cpp2ILInjected.Token(Token = "0x4007851")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		public int lightMaxY;

		[global::Cpp2ILInjected.Token(Token = "0x4007852")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public unsafe Vector3* lightColors;

		[global::Cpp2ILInjected.Token(Token = "0x4007853")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public int lightMapHeight;

		[global::Cpp2ILInjected.Token(Token = "0x4007854")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public float lightGlobal255;

		[global::Cpp2ILInjected.Token(Token = "0x4007855")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public EffectPass drawEffect;

		[global::Cpp2ILInjected.Token(Token = "0x4007856")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public Texture2D drawTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4007857")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public Color tileLight;

		[global::Cpp2ILInjected.Token(Token = "0x4007858")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		public int tileTop;

		[global::Cpp2ILInjected.Token(Token = "0x4007859")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public int tileWidth;

		[global::Cpp2ILInjected.Token(Token = "0x400785A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		public int tileHeight;

		[global::Cpp2ILInjected.Token(Token = "0x400785B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public int halfBrickHeight;

		[global::Cpp2ILInjected.Token(Token = "0x400785C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
		public int addFrY;

		[global::Cpp2ILInjected.Token(Token = "0x400785D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public int addFrX;

		[global::Cpp2ILInjected.Token(Token = "0x400785E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
		public SpriteEffects tileSpriteEffect;

		[global::Cpp2ILInjected.Token(Token = "0x400785F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public Texture2D glowTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4007860")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public Rectangle glowSourceRect;

		[global::Cpp2ILInjected.Token(Token = "0x4007861")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public Color glowColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007862")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public Vector3[] colorSlices;

		[global::Cpp2ILInjected.Token(Token = "0x4007863")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public Color finalColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007864")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public UnifiedRandom _rand;

		[global::Cpp2ILInjected.Token(Token = "0x4007865")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public Dictionary<Point, int> _displayDollTileEntityPositions;

		[global::Cpp2ILInjected.Token(Token = "0x4007866")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public Dictionary<Point, int> _hatRackTileEntityPositions;

		[global::Cpp2ILInjected.Token(Token = "0x4007867")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public Dictionary<Point, int> _trainingDummyTileEntityPositions;

		[global::Cpp2ILInjected.Token(Token = "0x4007868")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public Dictionary<Point, int> _itemFrameTileEntityPositions;

		[global::Cpp2ILInjected.Token(Token = "0x4007869")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public Dictionary<Point, int> _foodPlatterTileEntityPositions;

		[global::Cpp2ILInjected.Token(Token = "0x400786A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public Dictionary<Point, int> _weaponRackTileEntityPositions;

		[global::Cpp2ILInjected.Token(Token = "0x400786B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public Dictionary<Point, int> _chestPositions;

		[global::Cpp2ILInjected.Token(Token = "0x400786C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public VertexColors tileColors;
	}
}
