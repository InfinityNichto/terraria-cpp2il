using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Utilities;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000501 RID: 1281
	[global::Cpp2ILInjected.Token(Token = "0x200075D")]
	public class LegacyPlayerRenderer : IPlayerRenderer
	{
		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06003783 RID: 14211 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
		[global::Cpp2ILInjected.Token(Token = "0x1700078C")]
		public static SamplerState MountedSamplerState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003DFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A83D0", Offset = "0x14A83D0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerFull", MemberParameters = new object[]
			{
				typeof(Camera),
				typeof(Player)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x0002BEB3 File Offset: 0x0002A0B3
		[global::Cpp2ILInjected.Token(Token = "0x6003DFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A8468", Offset = "0x14A8468", Length = "0x3AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "getRect", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerFull", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void DrawPlayers(Camera camera, IEnumerable<Player> players)
		{
			throw null;
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x0002BEB6 File Offset: 0x0002A0B6
		[global::Cpp2ILInjected.Token(Token = "0x6003DFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A954C", Offset = "0x14A954C", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ShouldNotDraw", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Floor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_00_BackHelmet", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_01_FaceSkin", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_02_DrawArmorWithFullHair", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_03_HelmetHair", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_04_HatsWithFullHair", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_05_TallHats", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_06_NormalHats", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_07_JustHair", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_08_FaceAcc", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyPlayerRenderer), Member = "RenderOutlines", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_RenderAllLayers", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PopClippedImageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, Color borderColor = default(Color))
		{
			throw null;
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x0002BEB9 File Offset: 0x0002A0B9
		[global::Cpp2ILInjected.Token(Token = "0x6003DFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A97D8", Offset = "0x14A97D8", Length = "0x678")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_pixelShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void RenderOutlines(int count, float alpha, float scale, Color borderColor)
		{
			throw null;
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x0002BEBC File Offset: 0x0002A0BC
		[global::Cpp2ILInjected.Token(Token = "0x6003DFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A9E50", Offset = "0x14A9E50", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerFull", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ShouldNotDraw", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayer_UseNormalLayers", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_TransformDrawData", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_ScaleDrawData", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_RenderAllLayers", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_UsingSuperCart", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawProj", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, Vector2[] positionalOffsets = null)
		{
			throw null;
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x0002BEBF File Offset: 0x0002A0BF
		[global::Cpp2ILInjected.Token(Token = "0x6003DFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AA570", Offset = "0x14AA570", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_02_MountBehindPlayer", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_23_MountFront", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_extra_MountPlus", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_26_SolarShield", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_extra_MountMinus", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void DrawPlayer_MountTransformation(ref PlayerDrawSet drawInfo)
		{
			throw null;
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x0002BEC2 File Offset: 0x0002A0C2
		[global::Cpp2ILInjected.Token(Token = "0x6003E00")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AA0F0", Offset = "0x14AA0F0", Length = "0x480")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_extra_TorsoPlus", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_01_2_JimsCloak", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_extra_TorsoMinus", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_02_MountBehindPlayer", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_03_Carpet", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_03_PortableStool", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_04_ElectrifiedDebuffBack", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_05_ForbiddenSetRing", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_05_2_SafemanSun", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_06_WebbedDebuffBack", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_07_LeinforsHairShampoo", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_08_Backpacks", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_08_1_Tails", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_09_Wings", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_01_BackHair", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_10_BackAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_01_3_BackHead", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_11_Balloons", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_27_HeldItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_12_Skin", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_13_Leggings", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_14_Shoes", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_15_SkinLongCoat", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_16_ArmorLongCoat", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_17_Torso", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_18_OffhandAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_19_WaistAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_20_NeckAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_21_Head", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_21_1_Magiluminescence", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_22_FaceAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_32_FrontAcc_FrontPart", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_23_MountFront", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_24_Pulley", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_JimsDroneRadio", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_32_FrontAcc_BackPart", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_25_Shield", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_extra_MountPlus", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_26_SolarShield", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_extra_MountMinus", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_28_ArmOverItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_29_OnhandAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_30_BladedGlove", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_31_ProjectileOverArm", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_33_FrozenOrWebbedDebuff", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_34_ElectrifiedDebuffFront", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_35_IceBarrier", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_36_CTG", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_37_BeetleBuff", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_38_EyebrellaCloud", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_MakeIntoFirstFractalAfterImage", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static void DrawPlayer_UseNormalLayers(ref PlayerDrawSet drawInfo)
		{
			throw null;
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x0002BEC5 File Offset: 0x0002A0C5
		[global::Cpp2ILInjected.Token(Token = "0x6003E01")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A8814", Offset = "0x14A8814", Length = "0xD38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayers", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(IEnumerable<Player>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_Sampler", ReturnType = typeof(SamplerState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyPlayerRenderer), Member = "get_MountedSamplerState", ReturnType = typeof(SamplerState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "get_TransformationMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyPlayerRenderer), Member = "DrawGhost", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayer", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerStoned", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private void DrawPlayerFull(Camera camera, Player drawPlayer)
		{
			throw null;
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x0002BEC8 File Offset: 0x0002A0C8
		[global::Cpp2ILInjected.Token(Token = "0x6003E02")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AAA44", Offset = "0x14AAA44", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerFull", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void DrawPlayerStoned(Camera camera, Player drawPlayer, Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x0002BECB File Offset: 0x0002A0CB
		[global::Cpp2ILInjected.Token(Token = "0x6003E03")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AA5F8", Offset = "0x14AA5F8", Length = "0x44C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerFull", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetImmuneAlpha", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void DrawGhost(Camera camera, Player drawPlayer, Vector2 position, float shadow = 0f)
		{
			throw null;
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x0002BECE File Offset: 0x0002A0CE
		[global::Cpp2ILInjected.Token(Token = "0x6003E04")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AAE58", Offset = "0x14AAE58", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public LegacyPlayerRenderer()
		{
			throw null;
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x0002BED1 File Offset: 0x0002A0D1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003E05")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AAF10", Offset = "0x14AAF10", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static LegacyPlayerRenderer()
		{
			throw null;
		}

		// Token: 0x040067DC RID: 26588
		[global::Cpp2ILInjected.Token(Token = "0x4007CC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly DrawData[] _drawData;

		// Token: 0x040067DD RID: 26589
		[global::Cpp2ILInjected.Token(Token = "0x4007CC5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly List<int> _dust;

		// Token: 0x040067DE RID: 26590
		[global::Cpp2ILInjected.Token(Token = "0x4007CC6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly List<int> _gore;

		// Token: 0x040067DF RID: 26591
		[global::Cpp2ILInjected.Token(Token = "0x4007CC7")]
		private static Vector2[] OutlineOffsets;
	}
}
