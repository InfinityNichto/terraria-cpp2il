using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;

namespace Terraria.ID
{
	// Token: 0x020003E3 RID: 995
	[global::Cpp2ILInjected.Token(Token = "0x20005BC")]
	public static class Colors
	{
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x0002A9FB File Offset: 0x00028BFB
		[global::Cpp2ILInjected.Token(Token = "0x17000687")]
		public static Color CurrentLiquidColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x600350E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1385474", Offset = "0x1385474", Length = "0x16C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
			{
				typeof(ref PlayerDrawSet),
				typeof(int),
				typeof(Player),
				typeof(Vector2),
				typeof(Color),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_liquidAlpha", ReturnType = typeof(float[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x0002A9FE File Offset: 0x00028BFE
		[global::Cpp2ILInjected.Token(Token = "0x600350F")]
		[global::Cpp2ILInjected.Address(RVA = "0x13855E0", Offset = "0x13855E0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Color AlphaDarken(Color input)
		{
			throw null;
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x0002AA01 File Offset: 0x00028C01
		[global::Cpp2ILInjected.Token(Token = "0x6003510")]
		[global::Cpp2ILInjected.Address(RVA = "0x1385684", Offset = "0x1385684", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VoidLensHelper), Member = "DrawToDrawData", MemberParameters = new object[]
		{
			typeof(List<DrawData>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PotionOfReturnGateHelper), Member = "DrawToDrawData", MemberParameters = new object[]
		{
			typeof(List<DrawData>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileOutlineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(ref Color),
			typeof(ref Texture2D),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTeleportationPylons", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Color GetSelectionGlowColor(bool isTileSelected, int averageTileLighting)
		{
			throw null;
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x0002AA04 File Offset: 0x00028C04
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003511")]
		[global::Cpp2ILInjected.Address(RVA = "0x13856E8", Offset = "0x13856E8", Length = "0x988")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static Colors()
		{
			throw null;
		}

		// Token: 0x04003563 RID: 13667
		[global::Cpp2ILInjected.Token(Token = "0x4004754")]
		public static readonly Color RarityAmber;

		// Token: 0x04003564 RID: 13668
		[global::Cpp2ILInjected.Token(Token = "0x4004755")]
		public static readonly Color RarityTrash;

		// Token: 0x04003565 RID: 13669
		[global::Cpp2ILInjected.Token(Token = "0x4004756")]
		public static readonly Color RarityNormal;

		// Token: 0x04003566 RID: 13670
		[global::Cpp2ILInjected.Token(Token = "0x4004757")]
		public static readonly Color RarityBlue;

		// Token: 0x04003567 RID: 13671
		[global::Cpp2ILInjected.Token(Token = "0x4004758")]
		public static readonly Color RarityGreen;

		// Token: 0x04003568 RID: 13672
		[global::Cpp2ILInjected.Token(Token = "0x4004759")]
		public static readonly Color RarityOrange;

		// Token: 0x04003569 RID: 13673
		[global::Cpp2ILInjected.Token(Token = "0x400475A")]
		public static readonly Color RarityRed;

		// Token: 0x0400356A RID: 13674
		[global::Cpp2ILInjected.Token(Token = "0x400475B")]
		public static readonly Color RarityPink;

		// Token: 0x0400356B RID: 13675
		[global::Cpp2ILInjected.Token(Token = "0x400475C")]
		public static readonly Color RarityPurple;

		// Token: 0x0400356C RID: 13676
		[global::Cpp2ILInjected.Token(Token = "0x400475D")]
		public static readonly Color RarityLime;

		// Token: 0x0400356D RID: 13677
		[global::Cpp2ILInjected.Token(Token = "0x400475E")]
		public static readonly Color RarityYellow;

		// Token: 0x0400356E RID: 13678
		[global::Cpp2ILInjected.Token(Token = "0x400475F")]
		public static readonly Color RarityCyan;

		// Token: 0x0400356F RID: 13679
		[global::Cpp2ILInjected.Token(Token = "0x4004760")]
		public static readonly Color CoinPlatinum;

		// Token: 0x04003570 RID: 13680
		[global::Cpp2ILInjected.Token(Token = "0x4004761")]
		public static readonly Color CoinGold;

		// Token: 0x04003571 RID: 13681
		[global::Cpp2ILInjected.Token(Token = "0x4004762")]
		public static readonly Color CoinSilver;

		// Token: 0x04003572 RID: 13682
		[global::Cpp2ILInjected.Token(Token = "0x4004763")]
		public static readonly Color CoinCopper;

		// Token: 0x04003573 RID: 13683
		[global::Cpp2ILInjected.Token(Token = "0x4004764")]
		public static readonly Color AmbientNPCGastropodLight;

		// Token: 0x04003574 RID: 13684
		[global::Cpp2ILInjected.Token(Token = "0x4004765")]
		public static readonly Color JourneyMode;

		// Token: 0x04003575 RID: 13685
		[global::Cpp2ILInjected.Token(Token = "0x4004766")]
		public static readonly Color Mediumcore;

		// Token: 0x04003576 RID: 13686
		[global::Cpp2ILInjected.Token(Token = "0x4004767")]
		public static readonly Color Hardcore;

		// Token: 0x04003577 RID: 13687
		[global::Cpp2ILInjected.Token(Token = "0x4004768")]
		public static readonly Color LanternBG;

		// Token: 0x04003578 RID: 13688
		[global::Cpp2ILInjected.Token(Token = "0x4004769")]
		public static readonly Color[] _waterfallColors;

		// Token: 0x04003579 RID: 13689
		[global::Cpp2ILInjected.Token(Token = "0x400476A")]
		public static readonly Color[] _liquidColors;

		// Token: 0x0400357A RID: 13690
		[global::Cpp2ILInjected.Token(Token = "0x400476B")]
		public static readonly Color FancyUIFatButtonMouseOver;

		// Token: 0x0400357B RID: 13691
		[global::Cpp2ILInjected.Token(Token = "0x400476C")]
		public static readonly Color InventoryDefaultColor;

		// Token: 0x0400357C RID: 13692
		[global::Cpp2ILInjected.Token(Token = "0x400476D")]
		public static readonly Color InventoryDefaultColorWithOpacity;
	}
}
