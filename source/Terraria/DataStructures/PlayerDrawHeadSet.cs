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
	// Token: 0x02000447 RID: 1095
	[global::Cpp2ILInjected.Token(Token = "0x2000643")]
	public struct PlayerDrawHeadSet
	{
		// Token: 0x060031A1 RID: 12705 RVA: 0x0002AE15 File Offset: 0x00029015
		[global::Cpp2ILInjected.Token(Token = "0x60036BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x141840C", Offset = "0x141840C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddDrawData(ref DrawData data)
		{
			throw null;
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060031A2 RID: 12706 RVA: 0x0002AE18 File Offset: 0x00029018
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

		// Token: 0x060031A3 RID: 12707 RVA: 0x0002AE1B File Offset: 0x0002901B
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

		// Token: 0x040063AD RID: 25517
		[global::Cpp2ILInjected.Token(Token = "0x400779D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int DrawDataCount;

		// Token: 0x040063AE RID: 25518
		[global::Cpp2ILInjected.Token(Token = "0x400779E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public DrawData[] DrawData;

		// Token: 0x040063AF RID: 25519
		[global::Cpp2ILInjected.Token(Token = "0x400779F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<int> Dust;

		// Token: 0x040063B0 RID: 25520
		[global::Cpp2ILInjected.Token(Token = "0x40077A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public List<int> Gore;

		// Token: 0x040063B1 RID: 25521
		[global::Cpp2ILInjected.Token(Token = "0x40077A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Player drawPlayer;

		// Token: 0x040063B2 RID: 25522
		[global::Cpp2ILInjected.Token(Token = "0x40077A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int cHead;

		// Token: 0x040063B3 RID: 25523
		[global::Cpp2ILInjected.Token(Token = "0x40077A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int cFace;

		// Token: 0x040063B4 RID: 25524
		[global::Cpp2ILInjected.Token(Token = "0x40077A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int cFaceHead;

		// Token: 0x040063B5 RID: 25525
		[global::Cpp2ILInjected.Token(Token = "0x40077A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int cFaceFlower;

		// Token: 0x040063B6 RID: 25526
		[global::Cpp2ILInjected.Token(Token = "0x40077A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int cUnicornHorn;

		// Token: 0x040063B7 RID: 25527
		[global::Cpp2ILInjected.Token(Token = "0x40077A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int cAngelHalo;

		// Token: 0x040063B8 RID: 25528
		[global::Cpp2ILInjected.Token(Token = "0x40077A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int cBeard;

		// Token: 0x040063B9 RID: 25529
		[global::Cpp2ILInjected.Token(Token = "0x40077A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int skinVar;

		// Token: 0x040063BA RID: 25530
		[global::Cpp2ILInjected.Token(Token = "0x40077AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int hairShaderPacked;

		// Token: 0x040063BB RID: 25531
		[global::Cpp2ILInjected.Token(Token = "0x40077AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public int skinDyePacked;

		// Token: 0x040063BC RID: 25532
		[global::Cpp2ILInjected.Token(Token = "0x40077AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float scale;

		// Token: 0x040063BD RID: 25533
		[global::Cpp2ILInjected.Token(Token = "0x40077AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public Color colorEyeWhites;

		// Token: 0x040063BE RID: 25534
		[global::Cpp2ILInjected.Token(Token = "0x40077AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public Color colorEyes;

		// Token: 0x040063BF RID: 25535
		[global::Cpp2ILInjected.Token(Token = "0x40077AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public Color colorHair;

		// Token: 0x040063C0 RID: 25536
		[global::Cpp2ILInjected.Token(Token = "0x40077B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public Color colorHead;

		// Token: 0x040063C1 RID: 25537
		[global::Cpp2ILInjected.Token(Token = "0x40077B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public Color colorArmorHead;

		// Token: 0x040063C2 RID: 25538
		[global::Cpp2ILInjected.Token(Token = "0x40077B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public Color colorDisplayDollSkin;

		// Token: 0x040063C3 RID: 25539
		[global::Cpp2ILInjected.Token(Token = "0x40077B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public SpriteEffects playerEffect;

		// Token: 0x040063C4 RID: 25540
		[global::Cpp2ILInjected.Token(Token = "0x40077B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public Vector2 headVect;

		// Token: 0x040063C5 RID: 25541
		[global::Cpp2ILInjected.Token(Token = "0x40077B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public Rectangle bodyFrameMemory;

		// Token: 0x040063C6 RID: 25542
		[global::Cpp2ILInjected.Token(Token = "0x40077B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public bool fullHair;

		// Token: 0x040063C7 RID: 25543
		[global::Cpp2ILInjected.Token(Token = "0x40077B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x89")]
		public bool hatHair;

		// Token: 0x040063C8 RID: 25544
		[global::Cpp2ILInjected.Token(Token = "0x40077B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8A")]
		public bool hideHair;

		// Token: 0x040063C9 RID: 25545
		[global::Cpp2ILInjected.Token(Token = "0x40077B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8B")]
		public bool helmetIsTall;

		// Token: 0x040063CA RID: 25546
		[global::Cpp2ILInjected.Token(Token = "0x40077BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		public bool helmetIsOverFullHair;

		// Token: 0x040063CB RID: 25547
		[global::Cpp2ILInjected.Token(Token = "0x40077BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8D")]
		public bool helmetIsNormal;

		// Token: 0x040063CC RID: 25548
		[global::Cpp2ILInjected.Token(Token = "0x40077BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8E")]
		public bool drawUnicornHorn;

		// Token: 0x040063CD RID: 25549
		[global::Cpp2ILInjected.Token(Token = "0x40077BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8F")]
		public bool drawAngelHalo;

		// Token: 0x040063CE RID: 25550
		[global::Cpp2ILInjected.Token(Token = "0x40077BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public Vector2 Position;

		// Token: 0x040063CF RID: 25551
		[global::Cpp2ILInjected.Token(Token = "0x40077BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public Vector2 hairOffset;

		// Token: 0x040063D0 RID: 25552
		[global::Cpp2ILInjected.Token(Token = "0x40077C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public Vector2 helmetOffset;
	}
}
