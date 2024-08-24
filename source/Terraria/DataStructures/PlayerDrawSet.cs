using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.Golf;
using Terraria.Graphics;
using Terraria.Graphics.Renderers;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Utilities;

namespace Terraria.DataStructures
{
	// Token: 0x02000444 RID: 1092
	[global::Cpp2ILInjected.Token(Token = "0x2000640")]
	public struct PlayerDrawSet
	{
		// Token: 0x06003145 RID: 12613 RVA: 0x0002AD01 File Offset: 0x00028F01
		[global::Cpp2ILInjected.Token(Token = "0x6003662")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DF41C", Offset = "0x13DF41C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 145)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddDrawData(ref DrawData data)
		{
			throw null;
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x0002AD04 File Offset: 0x00028F04
		[global::Cpp2ILInjected.Token(Token = "0x6003663")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DF454", Offset = "0x13DF454", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawCompositeArmorPiece", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(CompositePlayerDrawContext),
			typeof(DrawData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_12_Skin_Composite", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_12_SkinComposite_BackArmShirt", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_17_TorsoComposite", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_28_ArmOverItemComposite", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_36_CTG", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddDrawData(DrawData data)
		{
			throw null;
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x0002AD07 File Offset: 0x00028F07
		[global::Cpp2ILInjected.Token(Token = "0x170006A2")]
		public Vector2 Center
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003664")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DF48C", Offset = "0x13DF48C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x0002AD0A File Offset: 0x00028F0A
		[global::Cpp2ILInjected.Token(Token = "0x6003665")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DF4E0", Offset = "0x13DF4E0", Length = "0x6AC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayer", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player),
			typeof(Vector2),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerSittingHelper), Member = "GetSittingOffsetInfo", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(ref Vector2),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_MountXOffset", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerSleepingHelper), Member = "GetSleepingOffsetInfo", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper), Member = "IsPlayerHoldingClub", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetHairSettings", MemberParameters = new object[]
		{
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawSet), Member = "AdjustmentsForWolfMount", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawSet), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "InSmartCursorHighlightArea", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Colors), Member = "GetSelectionGlowColor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_HeightOffsetVisual", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_Cart", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetHairColor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetImmuneAlpha", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColorVector3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetImmuneAlphaPure", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_Male", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadArmorHead", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadArmorBody", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadArmorLegs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccHandsOn", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccHandsOff", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccBack", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccFront", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccShoes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccWaist", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccShield", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccNeck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccFace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccBalloon", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadAccBeard", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadHair", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadProjectile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColorClamped", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "SelectRandom", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(int[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gFade", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderDataSet), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(short),
			typeof(Player),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4),
			typeof(float)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiplyRGBA", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetHairDrawOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetHelmetDrawOffset", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetLegsDrawOffset", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawSet), Member = "CreateCompositeData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "buffColor", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 309)]
		public void BoringSetup(Player player, DrawData[] drawData, List<int> dust, List<int> gore, Vector2 drawPosition, float shadowOpacity, float rotation, Vector2 rotationOrigin)
		{
			throw null;
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x0002AD0D File Offset: 0x00028F0D
		[global::Cpp2ILInjected.Token(Token = "0x6003666")]
		[global::Cpp2ILInjected.Address(RVA = "0x13E5FA8", Offset = "0x13E5FA8", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void AdjustmentsForWolfMount()
		{
			throw null;
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x0002AD10 File Offset: 0x00028F10
		[global::Cpp2ILInjected.Token(Token = "0x6003667")]
		[global::Cpp2ILInjected.Address(RVA = "0x13E6258", Offset = "0x13E6258", Length = "0x734")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawSet), Member = "CreateCompositeData_DetermineShoulderOffsets", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_Male", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void CreateCompositeData()
		{
			throw null;
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x0002AD13 File Offset: 0x00028F13
		[global::Cpp2ILInjected.Token(Token = "0x6003668")]
		[global::Cpp2ILInjected.Address(RVA = "0x13E698C", Offset = "0x13E698C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "CreateCompositeData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CreateCompositeData_DetermineShoulderOffsets(int armor, int targetFrameNumber)
		{
			throw null;
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x0002AD16 File Offset: 0x00028F16
		[global::Cpp2ILInjected.Token(Token = "0x6003669")]
		[global::Cpp2ILInjected.Address(RVA = "0x13E6B64", Offset = "0x13E6B64", Length = "0x1044")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private Rectangle CreateCompositeFrameRect(Point pt)
		{
			throw null;
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x0002AD19 File Offset: 0x00028F19
		[global::Cpp2ILInjected.Token(Token = "0x600366A")]
		[global::Cpp2ILInjected.Address(RVA = "0x13E6B0C", Offset = "0x13E6B0C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void UpdateCompositeArm(Player.CompositeArmData data, ref float rotation, ref Point frameIndex, int targetX)
		{
			throw null;
		}

		// Token: 0x0400632A RID: 25386
		[global::Cpp2ILInjected.Token(Token = "0x400771A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int DrawDataCacheCount;

		// Token: 0x0400632B RID: 25387
		[global::Cpp2ILInjected.Token(Token = "0x400771B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public DrawData[] DrawDataCache;

		// Token: 0x0400632C RID: 25388
		[global::Cpp2ILInjected.Token(Token = "0x400771C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<int> DustCache;

		// Token: 0x0400632D RID: 25389
		[global::Cpp2ILInjected.Token(Token = "0x400771D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public List<int> GoreCache;

		// Token: 0x0400632E RID: 25390
		[global::Cpp2ILInjected.Token(Token = "0x400771E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Player drawPlayer;

		// Token: 0x0400632F RID: 25391
		[global::Cpp2ILInjected.Token(Token = "0x400771F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public float shadow;

		// Token: 0x04006330 RID: 25392
		[global::Cpp2ILInjected.Token(Token = "0x4007720")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public Vector2 Position;

		// Token: 0x04006331 RID: 25393
		[global::Cpp2ILInjected.Token(Token = "0x4007721")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int projectileDrawPosition;

		// Token: 0x04006332 RID: 25394
		[global::Cpp2ILInjected.Token(Token = "0x4007722")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Vector2 ItemLocation;

		// Token: 0x04006333 RID: 25395
		[global::Cpp2ILInjected.Token(Token = "0x4007723")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int armorAdjust;

		// Token: 0x04006334 RID: 25396
		[global::Cpp2ILInjected.Token(Token = "0x4007724")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public bool missingHand;

		// Token: 0x04006335 RID: 25397
		[global::Cpp2ILInjected.Token(Token = "0x4007725")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
		public bool missingArm;

		// Token: 0x04006336 RID: 25398
		[global::Cpp2ILInjected.Token(Token = "0x4007726")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x46")]
		public bool heldProjOverHand;

		// Token: 0x04006337 RID: 25399
		[global::Cpp2ILInjected.Token(Token = "0x4007727")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int skinVar;

		// Token: 0x04006338 RID: 25400
		[global::Cpp2ILInjected.Token(Token = "0x4007728")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public bool fullHair;

		// Token: 0x04006339 RID: 25401
		[global::Cpp2ILInjected.Token(Token = "0x4007729")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D")]
		public bool drawsBackHairWithoutHeadgear;

		// Token: 0x0400633A RID: 25402
		[global::Cpp2ILInjected.Token(Token = "0x400772A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E")]
		public bool hatHair;

		// Token: 0x0400633B RID: 25403
		[global::Cpp2ILInjected.Token(Token = "0x400772B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F")]
		public bool hideHair;

		// Token: 0x0400633C RID: 25404
		[global::Cpp2ILInjected.Token(Token = "0x400772C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public int hairDyePacked;

		// Token: 0x0400633D RID: 25405
		[global::Cpp2ILInjected.Token(Token = "0x400772D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public int skinDyePacked;

		// Token: 0x0400633E RID: 25406
		[global::Cpp2ILInjected.Token(Token = "0x400772E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float mountOffSet;

		// Token: 0x0400633F RID: 25407
		[global::Cpp2ILInjected.Token(Token = "0x400772F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public int cHead;

		// Token: 0x04006340 RID: 25408
		[global::Cpp2ILInjected.Token(Token = "0x4007730")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public int cBody;

		// Token: 0x04006341 RID: 25409
		[global::Cpp2ILInjected.Token(Token = "0x4007731")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public int cLegs;

		// Token: 0x04006342 RID: 25410
		[global::Cpp2ILInjected.Token(Token = "0x4007732")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public int cHandOn;

		// Token: 0x04006343 RID: 25411
		[global::Cpp2ILInjected.Token(Token = "0x4007733")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public int cHandOff;

		// Token: 0x04006344 RID: 25412
		[global::Cpp2ILInjected.Token(Token = "0x4007734")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public int cBack;

		// Token: 0x04006345 RID: 25413
		[global::Cpp2ILInjected.Token(Token = "0x4007735")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		public int cFront;

		// Token: 0x04006346 RID: 25414
		[global::Cpp2ILInjected.Token(Token = "0x4007736")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public int cShoe;

		// Token: 0x04006347 RID: 25415
		[global::Cpp2ILInjected.Token(Token = "0x4007737")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public int cFlameWaker;

		// Token: 0x04006348 RID: 25416
		[global::Cpp2ILInjected.Token(Token = "0x4007738")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public int cWaist;

		// Token: 0x04006349 RID: 25417
		[global::Cpp2ILInjected.Token(Token = "0x4007739")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		public int cShield;

		// Token: 0x0400634A RID: 25418
		[global::Cpp2ILInjected.Token(Token = "0x400773A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public int cNeck;

		// Token: 0x0400634B RID: 25419
		[global::Cpp2ILInjected.Token(Token = "0x400773B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		public int cFace;

		// Token: 0x0400634C RID: 25420
		[global::Cpp2ILInjected.Token(Token = "0x400773C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public int cBalloon;

		// Token: 0x0400634D RID: 25421
		[global::Cpp2ILInjected.Token(Token = "0x400773D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public int cWings;

		// Token: 0x0400634E RID: 25422
		[global::Cpp2ILInjected.Token(Token = "0x400773E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public int cCarpet;

		// Token: 0x0400634F RID: 25423
		[global::Cpp2ILInjected.Token(Token = "0x400773F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public int cPortableStool;

		// Token: 0x04006350 RID: 25424
		[global::Cpp2ILInjected.Token(Token = "0x4007740")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public int cFloatingTube;

		// Token: 0x04006351 RID: 25425
		[global::Cpp2ILInjected.Token(Token = "0x4007741")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		public int cUnicornHorn;

		// Token: 0x04006352 RID: 25426
		[global::Cpp2ILInjected.Token(Token = "0x4007742")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public int cAngelHalo;

		// Token: 0x04006353 RID: 25427
		[global::Cpp2ILInjected.Token(Token = "0x4007743")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		public int cBeard;

		// Token: 0x04006354 RID: 25428
		[global::Cpp2ILInjected.Token(Token = "0x4007744")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public int cLeinShampoo;

		// Token: 0x04006355 RID: 25429
		[global::Cpp2ILInjected.Token(Token = "0x4007745")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		public int cBackpack;

		// Token: 0x04006356 RID: 25430
		[global::Cpp2ILInjected.Token(Token = "0x4007746")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public int cTail;

		// Token: 0x04006357 RID: 25431
		[global::Cpp2ILInjected.Token(Token = "0x4007747")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		public int cFaceHead;

		// Token: 0x04006358 RID: 25432
		[global::Cpp2ILInjected.Token(Token = "0x4007748")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public int cFaceFlower;

		// Token: 0x04006359 RID: 25433
		[global::Cpp2ILInjected.Token(Token = "0x4007749")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
		public int cBalloonFront;

		// Token: 0x0400635A RID: 25434
		[global::Cpp2ILInjected.Token(Token = "0x400774A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public SpriteEffects playerEffect;

		// Token: 0x0400635B RID: 25435
		[global::Cpp2ILInjected.Token(Token = "0x400774B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
		public SpriteEffects itemEffect;

		// Token: 0x0400635C RID: 25436
		[global::Cpp2ILInjected.Token(Token = "0x400774C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public Color colorHair;

		// Token: 0x0400635D RID: 25437
		[global::Cpp2ILInjected.Token(Token = "0x400774D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
		public Color colorEyeWhites;

		// Token: 0x0400635E RID: 25438
		[global::Cpp2ILInjected.Token(Token = "0x400774E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public Color colorEyes;

		// Token: 0x0400635F RID: 25439
		[global::Cpp2ILInjected.Token(Token = "0x400774F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
		public Color colorHead;

		// Token: 0x04006360 RID: 25440
		[global::Cpp2ILInjected.Token(Token = "0x4007750")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public Color colorBodySkin;

		// Token: 0x04006361 RID: 25441
		[global::Cpp2ILInjected.Token(Token = "0x4007751")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		public Color colorLegs;

		// Token: 0x04006362 RID: 25442
		[global::Cpp2ILInjected.Token(Token = "0x4007752")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public Color colorShirt;

		// Token: 0x04006363 RID: 25443
		[global::Cpp2ILInjected.Token(Token = "0x4007753")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
		public Color colorUnderShirt;

		// Token: 0x04006364 RID: 25444
		[global::Cpp2ILInjected.Token(Token = "0x4007754")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public Color colorPants;

		// Token: 0x04006365 RID: 25445
		[global::Cpp2ILInjected.Token(Token = "0x4007755")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
		public Color colorShoes;

		// Token: 0x04006366 RID: 25446
		[global::Cpp2ILInjected.Token(Token = "0x4007756")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public Color colorArmorHead;

		// Token: 0x04006367 RID: 25447
		[global::Cpp2ILInjected.Token(Token = "0x4007757")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
		public Color colorArmorBody;

		// Token: 0x04006368 RID: 25448
		[global::Cpp2ILInjected.Token(Token = "0x4007758")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public Color colorMount;

		// Token: 0x04006369 RID: 25449
		[global::Cpp2ILInjected.Token(Token = "0x4007759")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
		public Color colorArmorLegs;

		// Token: 0x0400636A RID: 25450
		[global::Cpp2ILInjected.Token(Token = "0x400775A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public Color colorElectricity;

		// Token: 0x0400636B RID: 25451
		[global::Cpp2ILInjected.Token(Token = "0x400775B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
		public Color colorDisplayDollSkin;

		// Token: 0x0400636C RID: 25452
		[global::Cpp2ILInjected.Token(Token = "0x400775C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public int headGlowMask;

		// Token: 0x0400636D RID: 25453
		[global::Cpp2ILInjected.Token(Token = "0x400775D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
		public int bodyGlowMask;

		// Token: 0x0400636E RID: 25454
		[global::Cpp2ILInjected.Token(Token = "0x400775E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public int armGlowMask;

		// Token: 0x0400636F RID: 25455
		[global::Cpp2ILInjected.Token(Token = "0x400775F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
		public int legsGlowMask;

		// Token: 0x04006370 RID: 25456
		[global::Cpp2ILInjected.Token(Token = "0x4007760")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public Color headGlowColor;

		// Token: 0x04006371 RID: 25457
		[global::Cpp2ILInjected.Token(Token = "0x4007761")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
		public Color bodyGlowColor;

		// Token: 0x04006372 RID: 25458
		[global::Cpp2ILInjected.Token(Token = "0x4007762")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public Color armGlowColor;

		// Token: 0x04006373 RID: 25459
		[global::Cpp2ILInjected.Token(Token = "0x4007763")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
		public Color legsGlowColor;

		// Token: 0x04006374 RID: 25460
		[global::Cpp2ILInjected.Token(Token = "0x4007764")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public Color ArkhalisColor;

		// Token: 0x04006375 RID: 25461
		[global::Cpp2ILInjected.Token(Token = "0x4007765")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
		public float stealth;

		// Token: 0x04006376 RID: 25462
		[global::Cpp2ILInjected.Token(Token = "0x4007766")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public Vector2 legVect;

		// Token: 0x04006377 RID: 25463
		[global::Cpp2ILInjected.Token(Token = "0x4007767")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public Vector2 bodyVect;

		// Token: 0x04006378 RID: 25464
		[global::Cpp2ILInjected.Token(Token = "0x4007768")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public Vector2 headVect;

		// Token: 0x04006379 RID: 25465
		[global::Cpp2ILInjected.Token(Token = "0x4007769")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public Color selectionGlowColor;

		// Token: 0x0400637A RID: 25466
		[global::Cpp2ILInjected.Token(Token = "0x400776A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		public float torsoOffset;

		// Token: 0x0400637B RID: 25467
		[global::Cpp2ILInjected.Token(Token = "0x400776B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public bool hidesTopSkin;

		// Token: 0x0400637C RID: 25468
		[global::Cpp2ILInjected.Token(Token = "0x400776C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x159")]
		public bool hidesBottomSkin;

		// Token: 0x0400637D RID: 25469
		[global::Cpp2ILInjected.Token(Token = "0x400776D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
		public float rotation;

		// Token: 0x0400637E RID: 25470
		[global::Cpp2ILInjected.Token(Token = "0x400776E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		public Vector2 rotationOrigin;

		// Token: 0x0400637F RID: 25471
		[global::Cpp2ILInjected.Token(Token = "0x400776F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public Rectangle hairFrontFrame;

		// Token: 0x04006380 RID: 25472
		[global::Cpp2ILInjected.Token(Token = "0x4007770")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		public Rectangle hairBackFrame;

		// Token: 0x04006381 RID: 25473
		[global::Cpp2ILInjected.Token(Token = "0x4007771")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		public bool backHairDraw;

		// Token: 0x04006382 RID: 25474
		[global::Cpp2ILInjected.Token(Token = "0x4007772")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x189")]
		public Color itemColor;

		// Token: 0x04006383 RID: 25475
		[global::Cpp2ILInjected.Token(Token = "0x4007773")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18D")]
		public bool usesCompositeTorso;

		// Token: 0x04006384 RID: 25476
		[global::Cpp2ILInjected.Token(Token = "0x4007774")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18E")]
		public bool usesCompositeFrontHandAcc;

		// Token: 0x04006385 RID: 25477
		[global::Cpp2ILInjected.Token(Token = "0x4007775")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18F")]
		public bool usesCompositeBackHandAcc;

		// Token: 0x04006386 RID: 25478
		[global::Cpp2ILInjected.Token(Token = "0x4007776")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		public bool compShoulderOverFrontArm;

		// Token: 0x04006387 RID: 25479
		[global::Cpp2ILInjected.Token(Token = "0x4007777")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x194")]
		public Rectangle compBackShoulderFrame;

		// Token: 0x04006388 RID: 25480
		[global::Cpp2ILInjected.Token(Token = "0x4007778")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A4")]
		public Rectangle compFrontShoulderFrame;

		// Token: 0x04006389 RID: 25481
		[global::Cpp2ILInjected.Token(Token = "0x4007779")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B4")]
		public Rectangle compBackArmFrame;

		// Token: 0x0400638A RID: 25482
		[global::Cpp2ILInjected.Token(Token = "0x400777A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C4")]
		public Rectangle compFrontArmFrame;

		// Token: 0x0400638B RID: 25483
		[global::Cpp2ILInjected.Token(Token = "0x400777B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D4")]
		public Rectangle compTorsoFrame;

		// Token: 0x0400638C RID: 25484
		[global::Cpp2ILInjected.Token(Token = "0x400777C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E4")]
		public float compositeBackArmRotation;

		// Token: 0x0400638D RID: 25485
		[global::Cpp2ILInjected.Token(Token = "0x400777D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
		public float compositeFrontArmRotation;

		// Token: 0x0400638E RID: 25486
		[global::Cpp2ILInjected.Token(Token = "0x400777E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1EC")]
		public bool hideCompositeShoulders;

		// Token: 0x0400638F RID: 25487
		[global::Cpp2ILInjected.Token(Token = "0x400777F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
		public Vector2 frontShoulderOffset;

		// Token: 0x04006390 RID: 25488
		[global::Cpp2ILInjected.Token(Token = "0x4007780")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
		public Vector2 backShoulderOffset;

		// Token: 0x04006391 RID: 25489
		[global::Cpp2ILInjected.Token(Token = "0x4007781")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
		public WeaponDrawOrder weaponDrawOrder;

		// Token: 0x04006392 RID: 25490
		[global::Cpp2ILInjected.Token(Token = "0x4007782")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x204")]
		public bool weaponOverFrontArm;

		// Token: 0x04006393 RID: 25491
		[global::Cpp2ILInjected.Token(Token = "0x4007783")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x205")]
		public bool isSitting;

		// Token: 0x04006394 RID: 25492
		[global::Cpp2ILInjected.Token(Token = "0x4007784")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x206")]
		public bool isSleeping;

		// Token: 0x04006395 RID: 25493
		[global::Cpp2ILInjected.Token(Token = "0x4007785")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
		public float seatYOffset;

		// Token: 0x04006396 RID: 25494
		[global::Cpp2ILInjected.Token(Token = "0x4007786")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20C")]
		public int sittingIndex;

		// Token: 0x04006397 RID: 25495
		[global::Cpp2ILInjected.Token(Token = "0x4007787")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
		public bool drawFrontAccInNeckAccLayer;

		// Token: 0x04006398 RID: 25496
		[global::Cpp2ILInjected.Token(Token = "0x4007788")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
		public Item heldItem;

		// Token: 0x04006399 RID: 25497
		[global::Cpp2ILInjected.Token(Token = "0x4007789")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
		public bool drawFloatingTube;

		// Token: 0x0400639A RID: 25498
		[global::Cpp2ILInjected.Token(Token = "0x400778A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x221")]
		public bool drawUnicornHorn;

		// Token: 0x0400639B RID: 25499
		[global::Cpp2ILInjected.Token(Token = "0x400778B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x222")]
		public bool drawAngelHalo;

		// Token: 0x0400639C RID: 25500
		[global::Cpp2ILInjected.Token(Token = "0x400778C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x223")]
		public Color floatingTubeColor;

		// Token: 0x0400639D RID: 25501
		[global::Cpp2ILInjected.Token(Token = "0x400778D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
		public Vector2 hairOffset;

		// Token: 0x0400639E RID: 25502
		[global::Cpp2ILInjected.Token(Token = "0x400778E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
		public Vector2 helmetOffset;

		// Token: 0x0400639F RID: 25503
		[global::Cpp2ILInjected.Token(Token = "0x400778F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
		public Vector2 legsOffset;

		// Token: 0x040063A0 RID: 25504
		[global::Cpp2ILInjected.Token(Token = "0x4007790")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
		public bool hideEntirePlayer;
	}
}
