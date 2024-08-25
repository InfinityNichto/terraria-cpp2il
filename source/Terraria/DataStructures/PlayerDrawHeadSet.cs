using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.Graphics;
using Terraria.Graphics.Renderers;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000643")]
	public struct PlayerDrawHeadSet
	{
		[global::Cpp2ILInjected.Token(Token = "0x60036BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x141840C", Offset = "0x141840C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddDrawData(ref DrawData data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006A4")]
		public Rectangle HairFrame
		{
			[global::Cpp2ILInjected.Token(Token = "0x60036BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1418444", Offset = "0x1418444", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60036C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1418454", Offset = "0x1418454", Length = "0x754")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerHead", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerHeadDrawRenderTargetContent), Member = "DrawTheContent", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHelper), Member = "PackShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(PlayerDrawHelper.ShaderConfiguration)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccFace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadHair", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "quickAlpha", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetHairColor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_HeightMapOffset", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadArmorHead", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccBeard", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetHairSettings", MemberParameters = new object[]
		{
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetHairDrawOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_Directions", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetHelmetDrawOffset", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public void BoringSetup(Player drawPlayer2, DrawData[] drawData, List<int> dust, List<int> gore, float X, float Y, float Alpha, float Scale)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400779D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int DrawDataCount;

		[global::Cpp2ILInjected.Token(Token = "0x400779E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public DrawData[] DrawData;

		[global::Cpp2ILInjected.Token(Token = "0x400779F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<int> Dust;

		[global::Cpp2ILInjected.Token(Token = "0x40077A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public List<int> Gore;

		[global::Cpp2ILInjected.Token(Token = "0x40077A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Player drawPlayer;

		[global::Cpp2ILInjected.Token(Token = "0x40077A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int cHead;

		[global::Cpp2ILInjected.Token(Token = "0x40077A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int cFace;

		[global::Cpp2ILInjected.Token(Token = "0x40077A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int cFaceHead;

		[global::Cpp2ILInjected.Token(Token = "0x40077A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int cFaceFlower;

		[global::Cpp2ILInjected.Token(Token = "0x40077A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int cUnicornHorn;

		[global::Cpp2ILInjected.Token(Token = "0x40077A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int cAngelHalo;

		[global::Cpp2ILInjected.Token(Token = "0x40077A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int cBeard;

		[global::Cpp2ILInjected.Token(Token = "0x40077A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int skinVar;

		[global::Cpp2ILInjected.Token(Token = "0x40077AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int hairShaderPacked;

		[global::Cpp2ILInjected.Token(Token = "0x40077AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public int skinDyePacked;

		[global::Cpp2ILInjected.Token(Token = "0x40077AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float scale;

		[global::Cpp2ILInjected.Token(Token = "0x40077AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public Color colorEyeWhites;

		[global::Cpp2ILInjected.Token(Token = "0x40077AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public Color colorEyes;

		[global::Cpp2ILInjected.Token(Token = "0x40077AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public Color colorHair;

		[global::Cpp2ILInjected.Token(Token = "0x40077B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public Color colorHead;

		[global::Cpp2ILInjected.Token(Token = "0x40077B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public Color colorArmorHead;

		[global::Cpp2ILInjected.Token(Token = "0x40077B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public Color colorDisplayDollSkin;

		[global::Cpp2ILInjected.Token(Token = "0x40077B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public SpriteEffects playerEffect;

		[global::Cpp2ILInjected.Token(Token = "0x40077B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public Vector2 headVect;

		[global::Cpp2ILInjected.Token(Token = "0x40077B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public Rectangle bodyFrameMemory;

		[global::Cpp2ILInjected.Token(Token = "0x40077B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public bool fullHair;

		[global::Cpp2ILInjected.Token(Token = "0x40077B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x89")]
		public bool hatHair;

		[global::Cpp2ILInjected.Token(Token = "0x40077B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8A")]
		public bool hideHair;

		[global::Cpp2ILInjected.Token(Token = "0x40077B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8B")]
		public bool helmetIsTall;

		[global::Cpp2ILInjected.Token(Token = "0x40077BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		public bool helmetIsOverFullHair;

		[global::Cpp2ILInjected.Token(Token = "0x40077BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8D")]
		public bool helmetIsNormal;

		[global::Cpp2ILInjected.Token(Token = "0x40077BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8E")]
		public bool drawUnicornHorn;

		[global::Cpp2ILInjected.Token(Token = "0x40077BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8F")]
		public bool drawAngelHalo;

		[global::Cpp2ILInjected.Token(Token = "0x40077BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public Vector2 Position;

		[global::Cpp2ILInjected.Token(Token = "0x40077BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public Vector2 hairOffset;

		[global::Cpp2ILInjected.Token(Token = "0x40077C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public Vector2 helmetOffset;
	}
}
