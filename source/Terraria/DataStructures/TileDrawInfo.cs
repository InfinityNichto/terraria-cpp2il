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
	// Token: 0x02000478 RID: 1144
	[global::Cpp2ILInjected.Token(Token = "0x2000679")]
	public class TileDrawInfo
	{
		// Token: 0x0600321B RID: 12827 RVA: 0x0002AF68 File Offset: 0x00029168
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

		// Token: 0x04006443 RID: 25667
		[global::Cpp2ILInjected.Token(Token = "0x400783C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public SpriteBatch spriteBatch;

		// Token: 0x04006444 RID: 25668
		[global::Cpp2ILInjected.Token(Token = "0x400783D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public SpriteBatch spriteBatch2;

		// Token: 0x04006445 RID: 25669
		[global::Cpp2ILInjected.Token(Token = "0x400783E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int tileIndex;

		// Token: 0x04006446 RID: 25670
		[global::Cpp2ILInjected.Token(Token = "0x400783F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public uint tilePalIndex;

		// Token: 0x04006447 RID: 25671
		[global::Cpp2ILInjected.Token(Token = "0x4007840")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Tile tileCache;

		// Token: 0x04006448 RID: 25672
		[global::Cpp2ILInjected.Token(Token = "0x4007841")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public ushort typeCache;

		// Token: 0x04006449 RID: 25673
		[global::Cpp2ILInjected.Token(Token = "0x4007842")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E")]
		public short tileSHeader;

		// Token: 0x0400644A RID: 25674
		[global::Cpp2ILInjected.Token(Token = "0x4007843")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public short tileFrameX;

		// Token: 0x0400644B RID: 25675
		[global::Cpp2ILInjected.Token(Token = "0x4007844")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		public short tileFrameY;

		// Token: 0x0400644C RID: 25676
		[global::Cpp2ILInjected.Token(Token = "0x4007845")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public unsafe uint* tileLookup;

		// Token: 0x0400644D RID: 25677
		[global::Cpp2ILInjected.Token(Token = "0x4007846")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public unsafe ushort* tileTypeData;

		// Token: 0x0400644E RID: 25678
		[global::Cpp2ILInjected.Token(Token = "0x4007847")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public unsafe short* tileTypeSHeader;

		// Token: 0x0400644F RID: 25679
		[global::Cpp2ILInjected.Token(Token = "0x4007848")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public unsafe byte* tileTypeLiquid;

		// Token: 0x04006450 RID: 25680
		[global::Cpp2ILInjected.Token(Token = "0x4007849")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public unsafe byte* tileTypeBHeader;

		// Token: 0x04006451 RID: 25681
		[global::Cpp2ILInjected.Token(Token = "0x400784A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public unsafe byte* tileTypeBHeader3;

		// Token: 0x04006452 RID: 25682
		[global::Cpp2ILInjected.Token(Token = "0x400784B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public unsafe ushort* tileTypeWall;

		// Token: 0x04006453 RID: 25683
		[global::Cpp2ILInjected.Token(Token = "0x400784C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public unsafe short* tileTypeFrameX;

		// Token: 0x04006454 RID: 25684
		[global::Cpp2ILInjected.Token(Token = "0x400784D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public unsafe short* tileTypeFrameY;

		// Token: 0x04006455 RID: 25685
		[global::Cpp2ILInjected.Token(Token = "0x400784E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public int lightMinX;

		// Token: 0x04006456 RID: 25686
		[global::Cpp2ILInjected.Token(Token = "0x400784F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		public int lightMinY;

		// Token: 0x04006457 RID: 25687
		[global::Cpp2ILInjected.Token(Token = "0x4007850")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public int lightMaxX;

		// Token: 0x04006458 RID: 25688
		[global::Cpp2ILInjected.Token(Token = "0x4007851")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		public int lightMaxY;

		// Token: 0x04006459 RID: 25689
		[global::Cpp2ILInjected.Token(Token = "0x4007852")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public unsafe Vector3* lightColors;

		// Token: 0x0400645A RID: 25690
		[global::Cpp2ILInjected.Token(Token = "0x4007853")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public int lightMapHeight;

		// Token: 0x0400645B RID: 25691
		[global::Cpp2ILInjected.Token(Token = "0x4007854")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public float lightGlobal255;

		// Token: 0x0400645C RID: 25692
		[global::Cpp2ILInjected.Token(Token = "0x4007855")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public EffectPass drawEffect;

		// Token: 0x0400645D RID: 25693
		[global::Cpp2ILInjected.Token(Token = "0x4007856")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public Texture2D drawTexture;

		// Token: 0x0400645E RID: 25694
		[global::Cpp2ILInjected.Token(Token = "0x4007857")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public Color tileLight;

		// Token: 0x0400645F RID: 25695
		[global::Cpp2ILInjected.Token(Token = "0x4007858")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		public int tileTop;

		// Token: 0x04006460 RID: 25696
		[global::Cpp2ILInjected.Token(Token = "0x4007859")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public int tileWidth;

		// Token: 0x04006461 RID: 25697
		[global::Cpp2ILInjected.Token(Token = "0x400785A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		public int tileHeight;

		// Token: 0x04006462 RID: 25698
		[global::Cpp2ILInjected.Token(Token = "0x400785B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public int halfBrickHeight;

		// Token: 0x04006463 RID: 25699
		[global::Cpp2ILInjected.Token(Token = "0x400785C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
		public int addFrY;

		// Token: 0x04006464 RID: 25700
		[global::Cpp2ILInjected.Token(Token = "0x400785D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public int addFrX;

		// Token: 0x04006465 RID: 25701
		[global::Cpp2ILInjected.Token(Token = "0x400785E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
		public SpriteEffects tileSpriteEffect;

		// Token: 0x04006466 RID: 25702
		[global::Cpp2ILInjected.Token(Token = "0x400785F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public Texture2D glowTexture;

		// Token: 0x04006467 RID: 25703
		[global::Cpp2ILInjected.Token(Token = "0x4007860")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public Rectangle glowSourceRect;

		// Token: 0x04006468 RID: 25704
		[global::Cpp2ILInjected.Token(Token = "0x4007861")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public Color glowColor;

		// Token: 0x04006469 RID: 25705
		[global::Cpp2ILInjected.Token(Token = "0x4007862")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public Vector3[] colorSlices;

		// Token: 0x0400646A RID: 25706
		[global::Cpp2ILInjected.Token(Token = "0x4007863")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public Color finalColor;

		// Token: 0x0400646B RID: 25707
		[global::Cpp2ILInjected.Token(Token = "0x4007864")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public UnifiedRandom _rand;

		// Token: 0x0400646C RID: 25708
		[global::Cpp2ILInjected.Token(Token = "0x4007865")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public Dictionary<Point, int> _displayDollTileEntityPositions;

		// Token: 0x0400646D RID: 25709
		[global::Cpp2ILInjected.Token(Token = "0x4007866")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public Dictionary<Point, int> _hatRackTileEntityPositions;

		// Token: 0x0400646E RID: 25710
		[global::Cpp2ILInjected.Token(Token = "0x4007867")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public Dictionary<Point, int> _trainingDummyTileEntityPositions;

		// Token: 0x0400646F RID: 25711
		[global::Cpp2ILInjected.Token(Token = "0x4007868")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public Dictionary<Point, int> _itemFrameTileEntityPositions;

		// Token: 0x04006470 RID: 25712
		[global::Cpp2ILInjected.Token(Token = "0x4007869")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public Dictionary<Point, int> _foodPlatterTileEntityPositions;

		// Token: 0x04006471 RID: 25713
		[global::Cpp2ILInjected.Token(Token = "0x400786A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public Dictionary<Point, int> _weaponRackTileEntityPositions;

		// Token: 0x04006472 RID: 25714
		[global::Cpp2ILInjected.Token(Token = "0x400786B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public Dictionary<Point, int> _chestPositions;

		// Token: 0x04006473 RID: 25715
		[global::Cpp2ILInjected.Token(Token = "0x400786C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public VertexColors tileColors;
	}
}
