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
	[global::Cpp2ILInjected.Token(Token = "0x2000640")]
	public struct PlayerDrawSet
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003662")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DF41C", Offset = "0x13DF41C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawCompositeArmorPiece", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(CompositePlayerDrawContext),
			typeof(DrawData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_01_BackHair", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_03_Carpet", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_03_PortableStool", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_04_ElectrifiedDebuffBack", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_05_ForbiddenSetRing", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_01_3_BackHead", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_01_2_JimsCloak", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_05_2_SafemanSun", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_06_WebbedDebuffBack", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_08_Backpacks", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_08_1_Tails", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_10_BackAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_09_Wings", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_12_1_BalloonFronts", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_11_Balloons", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_12_Skin", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_12_Skin_Composite", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_13_Leggings", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawSittingLongCoats", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Texture2D),
			typeof(Color),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawSittingLegs", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Texture2D),
			typeof(Color),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_14_Shoes", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_15_SkinLongCoat", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_16_ArmorLongCoat", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_17_Torso", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_18_OffhandAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_JimsDroneRadio", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_19_WaistAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_20_NeckAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_21_Head", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_21_Head_TheFace", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_21_1_Magiluminescence", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_22_FaceAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawTiedBalloons", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawStarboardRainbowTrail", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawMeowcartTrail", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_24_Pulley", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_25_Shield", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_26_SolarShield", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_27_HeldItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_28_ArmOverItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_28_ArmOverItemComposite", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_29_OnhandAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_30_BladedGlove", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_32_FrontAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_32_FrontAcc_FrontPart", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_32_FrontAcc_BackPart", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_33_FrozenOrWebbedDebuff", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_34_ElectrifiedDebuffFront", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_35_IceBarrier", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_37_BeetleBuff", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_38_EyebrellaCloud", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 145)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddDrawData(ref DrawData data)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600366A")]
		[global::Cpp2ILInjected.Address(RVA = "0x13E6B0C", Offset = "0x13E6B0C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void UpdateCompositeArm(Player.CompositeArmData data, ref float rotation, ref Point frameIndex, int targetX)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400771A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int DrawDataCacheCount;

		[global::Cpp2ILInjected.Token(Token = "0x400771B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public DrawData[] DrawDataCache;

		[global::Cpp2ILInjected.Token(Token = "0x400771C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<int> DustCache;

		[global::Cpp2ILInjected.Token(Token = "0x400771D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public List<int> GoreCache;

		[global::Cpp2ILInjected.Token(Token = "0x400771E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Player drawPlayer;

		[global::Cpp2ILInjected.Token(Token = "0x400771F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public float shadow;

		[global::Cpp2ILInjected.Token(Token = "0x4007720")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public Vector2 Position;

		[global::Cpp2ILInjected.Token(Token = "0x4007721")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int projectileDrawPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007722")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Vector2 ItemLocation;

		[global::Cpp2ILInjected.Token(Token = "0x4007723")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int armorAdjust;

		[global::Cpp2ILInjected.Token(Token = "0x4007724")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public bool missingHand;

		[global::Cpp2ILInjected.Token(Token = "0x4007725")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
		public bool missingArm;

		[global::Cpp2ILInjected.Token(Token = "0x4007726")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x46")]
		public bool heldProjOverHand;

		[global::Cpp2ILInjected.Token(Token = "0x4007727")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int skinVar;

		[global::Cpp2ILInjected.Token(Token = "0x4007728")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public bool fullHair;

		[global::Cpp2ILInjected.Token(Token = "0x4007729")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D")]
		public bool drawsBackHairWithoutHeadgear;

		[global::Cpp2ILInjected.Token(Token = "0x400772A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E")]
		public bool hatHair;

		[global::Cpp2ILInjected.Token(Token = "0x400772B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F")]
		public bool hideHair;

		[global::Cpp2ILInjected.Token(Token = "0x400772C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public int hairDyePacked;

		[global::Cpp2ILInjected.Token(Token = "0x400772D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public int skinDyePacked;

		[global::Cpp2ILInjected.Token(Token = "0x400772E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float mountOffSet;

		[global::Cpp2ILInjected.Token(Token = "0x400772F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public int cHead;

		[global::Cpp2ILInjected.Token(Token = "0x4007730")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public int cBody;

		[global::Cpp2ILInjected.Token(Token = "0x4007731")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public int cLegs;

		[global::Cpp2ILInjected.Token(Token = "0x4007732")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public int cHandOn;

		[global::Cpp2ILInjected.Token(Token = "0x4007733")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public int cHandOff;

		[global::Cpp2ILInjected.Token(Token = "0x4007734")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public int cBack;

		[global::Cpp2ILInjected.Token(Token = "0x4007735")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		public int cFront;

		[global::Cpp2ILInjected.Token(Token = "0x4007736")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public int cShoe;

		[global::Cpp2ILInjected.Token(Token = "0x4007737")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public int cFlameWaker;

		[global::Cpp2ILInjected.Token(Token = "0x4007738")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public int cWaist;

		[global::Cpp2ILInjected.Token(Token = "0x4007739")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		public int cShield;

		[global::Cpp2ILInjected.Token(Token = "0x400773A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public int cNeck;

		[global::Cpp2ILInjected.Token(Token = "0x400773B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		public int cFace;

		[global::Cpp2ILInjected.Token(Token = "0x400773C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public int cBalloon;

		[global::Cpp2ILInjected.Token(Token = "0x400773D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public int cWings;

		[global::Cpp2ILInjected.Token(Token = "0x400773E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public int cCarpet;

		[global::Cpp2ILInjected.Token(Token = "0x400773F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public int cPortableStool;

		[global::Cpp2ILInjected.Token(Token = "0x4007740")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public int cFloatingTube;

		[global::Cpp2ILInjected.Token(Token = "0x4007741")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		public int cUnicornHorn;

		[global::Cpp2ILInjected.Token(Token = "0x4007742")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public int cAngelHalo;

		[global::Cpp2ILInjected.Token(Token = "0x4007743")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		public int cBeard;

		[global::Cpp2ILInjected.Token(Token = "0x4007744")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public int cLeinShampoo;

		[global::Cpp2ILInjected.Token(Token = "0x4007745")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		public int cBackpack;

		[global::Cpp2ILInjected.Token(Token = "0x4007746")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public int cTail;

		[global::Cpp2ILInjected.Token(Token = "0x4007747")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		public int cFaceHead;

		[global::Cpp2ILInjected.Token(Token = "0x4007748")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public int cFaceFlower;

		[global::Cpp2ILInjected.Token(Token = "0x4007749")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
		public int cBalloonFront;

		[global::Cpp2ILInjected.Token(Token = "0x400774A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public SpriteEffects playerEffect;

		[global::Cpp2ILInjected.Token(Token = "0x400774B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
		public SpriteEffects itemEffect;

		[global::Cpp2ILInjected.Token(Token = "0x400774C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public Color colorHair;

		[global::Cpp2ILInjected.Token(Token = "0x400774D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
		public Color colorEyeWhites;

		[global::Cpp2ILInjected.Token(Token = "0x400774E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public Color colorEyes;

		[global::Cpp2ILInjected.Token(Token = "0x400774F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
		public Color colorHead;

		[global::Cpp2ILInjected.Token(Token = "0x4007750")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public Color colorBodySkin;

		[global::Cpp2ILInjected.Token(Token = "0x4007751")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		public Color colorLegs;

		[global::Cpp2ILInjected.Token(Token = "0x4007752")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public Color colorShirt;

		[global::Cpp2ILInjected.Token(Token = "0x4007753")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
		public Color colorUnderShirt;

		[global::Cpp2ILInjected.Token(Token = "0x4007754")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public Color colorPants;

		[global::Cpp2ILInjected.Token(Token = "0x4007755")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
		public Color colorShoes;

		[global::Cpp2ILInjected.Token(Token = "0x4007756")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public Color colorArmorHead;

		[global::Cpp2ILInjected.Token(Token = "0x4007757")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
		public Color colorArmorBody;

		[global::Cpp2ILInjected.Token(Token = "0x4007758")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public Color colorMount;

		[global::Cpp2ILInjected.Token(Token = "0x4007759")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
		public Color colorArmorLegs;

		[global::Cpp2ILInjected.Token(Token = "0x400775A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public Color colorElectricity;

		[global::Cpp2ILInjected.Token(Token = "0x400775B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
		public Color colorDisplayDollSkin;

		[global::Cpp2ILInjected.Token(Token = "0x400775C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public int headGlowMask;

		[global::Cpp2ILInjected.Token(Token = "0x400775D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
		public int bodyGlowMask;

		[global::Cpp2ILInjected.Token(Token = "0x400775E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public int armGlowMask;

		[global::Cpp2ILInjected.Token(Token = "0x400775F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
		public int legsGlowMask;

		[global::Cpp2ILInjected.Token(Token = "0x4007760")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public Color headGlowColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007761")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
		public Color bodyGlowColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007762")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public Color armGlowColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007763")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
		public Color legsGlowColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007764")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public Color ArkhalisColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007765")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
		public float stealth;

		[global::Cpp2ILInjected.Token(Token = "0x4007766")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public Vector2 legVect;

		[global::Cpp2ILInjected.Token(Token = "0x4007767")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public Vector2 bodyVect;

		[global::Cpp2ILInjected.Token(Token = "0x4007768")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public Vector2 headVect;

		[global::Cpp2ILInjected.Token(Token = "0x4007769")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public Color selectionGlowColor;

		[global::Cpp2ILInjected.Token(Token = "0x400776A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		public float torsoOffset;

		[global::Cpp2ILInjected.Token(Token = "0x400776B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public bool hidesTopSkin;

		[global::Cpp2ILInjected.Token(Token = "0x400776C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x159")]
		public bool hidesBottomSkin;

		[global::Cpp2ILInjected.Token(Token = "0x400776D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
		public float rotation;

		[global::Cpp2ILInjected.Token(Token = "0x400776E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		public Vector2 rotationOrigin;

		[global::Cpp2ILInjected.Token(Token = "0x400776F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public Rectangle hairFrontFrame;

		[global::Cpp2ILInjected.Token(Token = "0x4007770")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		public Rectangle hairBackFrame;

		[global::Cpp2ILInjected.Token(Token = "0x4007771")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		public bool backHairDraw;

		[global::Cpp2ILInjected.Token(Token = "0x4007772")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x189")]
		public Color itemColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007773")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18D")]
		public bool usesCompositeTorso;

		[global::Cpp2ILInjected.Token(Token = "0x4007774")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18E")]
		public bool usesCompositeFrontHandAcc;

		[global::Cpp2ILInjected.Token(Token = "0x4007775")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18F")]
		public bool usesCompositeBackHandAcc;

		[global::Cpp2ILInjected.Token(Token = "0x4007776")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		public bool compShoulderOverFrontArm;

		[global::Cpp2ILInjected.Token(Token = "0x4007777")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x194")]
		public Rectangle compBackShoulderFrame;

		[global::Cpp2ILInjected.Token(Token = "0x4007778")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A4")]
		public Rectangle compFrontShoulderFrame;

		[global::Cpp2ILInjected.Token(Token = "0x4007779")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B4")]
		public Rectangle compBackArmFrame;

		[global::Cpp2ILInjected.Token(Token = "0x400777A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C4")]
		public Rectangle compFrontArmFrame;

		[global::Cpp2ILInjected.Token(Token = "0x400777B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D4")]
		public Rectangle compTorsoFrame;

		[global::Cpp2ILInjected.Token(Token = "0x400777C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E4")]
		public float compositeBackArmRotation;

		[global::Cpp2ILInjected.Token(Token = "0x400777D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
		public float compositeFrontArmRotation;

		[global::Cpp2ILInjected.Token(Token = "0x400777E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1EC")]
		public bool hideCompositeShoulders;

		[global::Cpp2ILInjected.Token(Token = "0x400777F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
		public Vector2 frontShoulderOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4007780")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
		public Vector2 backShoulderOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4007781")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
		public WeaponDrawOrder weaponDrawOrder;

		[global::Cpp2ILInjected.Token(Token = "0x4007782")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x204")]
		public bool weaponOverFrontArm;

		[global::Cpp2ILInjected.Token(Token = "0x4007783")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x205")]
		public bool isSitting;

		[global::Cpp2ILInjected.Token(Token = "0x4007784")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x206")]
		public bool isSleeping;

		[global::Cpp2ILInjected.Token(Token = "0x4007785")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
		public float seatYOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4007786")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20C")]
		public int sittingIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4007787")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
		public bool drawFrontAccInNeckAccLayer;

		[global::Cpp2ILInjected.Token(Token = "0x4007788")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
		public Item heldItem;

		[global::Cpp2ILInjected.Token(Token = "0x4007789")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
		public bool drawFloatingTube;

		[global::Cpp2ILInjected.Token(Token = "0x400778A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x221")]
		public bool drawUnicornHorn;

		[global::Cpp2ILInjected.Token(Token = "0x400778B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x222")]
		public bool drawAngelHalo;

		[global::Cpp2ILInjected.Token(Token = "0x400778C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x223")]
		public Color floatingTubeColor;

		[global::Cpp2ILInjected.Token(Token = "0x400778D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
		public Vector2 hairOffset;

		[global::Cpp2ILInjected.Token(Token = "0x400778E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
		public Vector2 helmetOffset;

		[global::Cpp2ILInjected.Token(Token = "0x400778F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
		public Vector2 legsOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4007790")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
		public bool hideEntirePlayer;
	}
}
