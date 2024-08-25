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
	[global::Cpp2ILInjected.Token(Token = "0x20005BC")]
	public static class Colors
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4004754")]
		public static readonly Color RarityAmber;

		[global::Cpp2ILInjected.Token(Token = "0x4004755")]
		public static readonly Color RarityTrash;

		[global::Cpp2ILInjected.Token(Token = "0x4004756")]
		public static readonly Color RarityNormal;

		[global::Cpp2ILInjected.Token(Token = "0x4004757")]
		public static readonly Color RarityBlue;

		[global::Cpp2ILInjected.Token(Token = "0x4004758")]
		public static readonly Color RarityGreen;

		[global::Cpp2ILInjected.Token(Token = "0x4004759")]
		public static readonly Color RarityOrange;

		[global::Cpp2ILInjected.Token(Token = "0x400475A")]
		public static readonly Color RarityRed;

		[global::Cpp2ILInjected.Token(Token = "0x400475B")]
		public static readonly Color RarityPink;

		[global::Cpp2ILInjected.Token(Token = "0x400475C")]
		public static readonly Color RarityPurple;

		[global::Cpp2ILInjected.Token(Token = "0x400475D")]
		public static readonly Color RarityLime;

		[global::Cpp2ILInjected.Token(Token = "0x400475E")]
		public static readonly Color RarityYellow;

		[global::Cpp2ILInjected.Token(Token = "0x400475F")]
		public static readonly Color RarityCyan;

		[global::Cpp2ILInjected.Token(Token = "0x4004760")]
		public static readonly Color CoinPlatinum;

		[global::Cpp2ILInjected.Token(Token = "0x4004761")]
		public static readonly Color CoinGold;

		[global::Cpp2ILInjected.Token(Token = "0x4004762")]
		public static readonly Color CoinSilver;

		[global::Cpp2ILInjected.Token(Token = "0x4004763")]
		public static readonly Color CoinCopper;

		[global::Cpp2ILInjected.Token(Token = "0x4004764")]
		public static readonly Color AmbientNPCGastropodLight;

		[global::Cpp2ILInjected.Token(Token = "0x4004765")]
		public static readonly Color JourneyMode;

		[global::Cpp2ILInjected.Token(Token = "0x4004766")]
		public static readonly Color Mediumcore;

		[global::Cpp2ILInjected.Token(Token = "0x4004767")]
		public static readonly Color Hardcore;

		[global::Cpp2ILInjected.Token(Token = "0x4004768")]
		public static readonly Color LanternBG;

		[global::Cpp2ILInjected.Token(Token = "0x4004769")]
		public static readonly Color[] _waterfallColors;

		[global::Cpp2ILInjected.Token(Token = "0x400476A")]
		public static readonly Color[] _liquidColors;

		[global::Cpp2ILInjected.Token(Token = "0x400476B")]
		public static readonly Color FancyUIFatButtonMouseOver;

		[global::Cpp2ILInjected.Token(Token = "0x400476C")]
		public static readonly Color InventoryDefaultColor;

		[global::Cpp2ILInjected.Token(Token = "0x400476D")]
		public static readonly Color InventoryDefaultColorWithOpacity;
	}
}
