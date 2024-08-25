using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Initializers;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000104")]
public static class GUIControllerInputButton
{
	[global::Cpp2ILInjected.Token(Token = "0x60006B2")]
	[global::Cpp2ILInjected.Address(RVA = "0xD206D0", Offset = "0xD206D0", Length = "0x12C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static void LoadContent(ContentManager content)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60006B3")]
	[global::Cpp2ILInjected.Address(RVA = "0xD207FC", Offset = "0xD207FC", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInputButton), Member = "GetButtonTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "get_SwapBumpersTriggers", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Microsoft.Xna.Framework.Graphics.Texture2D GetShoulderButtonTexureInformation(GUIControllerInputButton.ShoulderButtonControl controlType, out Rectangle srcRegion, int overloadedControlType = -1)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60006B4")]
	[global::Cpp2ILInjected.Address(RVA = "0xD18A9C", Offset = "0xD18A9C", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "GetTexure", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsAxisTagHandler.ControlsAxisSnippet), Member = "Draw", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.AxisControl),
		typeof(bool),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInputButton), Member = "GetButtonTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemRightDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static Microsoft.Xna.Framework.Graphics.Texture2D GetAxisTexureInformation(GUIControllerInputButton.AxisControl controlType, out Rectangle srcRegion, int overloadedControlType = -1)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60006B5")]
	[global::Cpp2ILInjected.Address(RVA = "0xD19F3C", Offset = "0xD19F3C", Length = "0x130")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "GetTexure", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ControlsButtonTagHandler.ControlsButtonSnippet", Member = "Draw", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(bool),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "DrawControlIcon", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemRightDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawMoreOptionsBanner", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "DrawOptionFaceButtons", MemberParameters = new object[] { typeof(ControllerDevice.ControlScheme) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetAxisTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.AxisControl),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetShoulderButtonTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.ShoulderButtonControl),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Microsoft.Xna.Framework.Graphics.Texture2D GetButtonTexureInformation(GUIControllerInputButton.LinkedControlType controlType, out Rectangle srcRegion, int overloadedControlType = -1)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000529")]
	private const ControllerDevice.ControlScheme defaultScheme = ControllerDevice.ControlScheme.CONTROLS_ABXY_XBOX;

	[global::Cpp2ILInjected.Token(Token = "0x400052A")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D ButtonControls;

	[global::Cpp2ILInjected.Token(Token = "0x400052B")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D ShoulderButtonControls;

	[global::Cpp2ILInjected.Token(Token = "0x400052C")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D AxisControls;

	[global::Cpp2ILInjected.Token(Token = "0x400052D")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D PS4TouchPad;

	[global::Cpp2ILInjected.Token(Token = "0x2000105")]
	public enum LinkedControlType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400052F")]
		Action1,
		[global::Cpp2ILInjected.Token(Token = "0x4000530")]
		Action2,
		[global::Cpp2ILInjected.Token(Token = "0x4000531")]
		Action3,
		[global::Cpp2ILInjected.Token(Token = "0x4000532")]
		Action4,
		[global::Cpp2ILInjected.Token(Token = "0x4000533")]
		LB,
		[global::Cpp2ILInjected.Token(Token = "0x4000534")]
		RB,
		[global::Cpp2ILInjected.Token(Token = "0x4000535")]
		LT,
		[global::Cpp2ILInjected.Token(Token = "0x4000536")]
		RT,
		[global::Cpp2ILInjected.Token(Token = "0x4000537")]
		View,
		[global::Cpp2ILInjected.Token(Token = "0x4000538")]
		Options,
		[global::Cpp2ILInjected.Token(Token = "0x4000539")]
		LeftStick,
		[global::Cpp2ILInjected.Token(Token = "0x400053A")]
		RightStick
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000106")]
	public enum ShoulderButtonControl
	{
		[global::Cpp2ILInjected.Token(Token = "0x400053C")]
		LB,
		[global::Cpp2ILInjected.Token(Token = "0x400053D")]
		RB,
		[global::Cpp2ILInjected.Token(Token = "0x400053E")]
		LT,
		[global::Cpp2ILInjected.Token(Token = "0x400053F")]
		RT,
		[global::Cpp2ILInjected.Token(Token = "0x4000540")]
		View,
		[global::Cpp2ILInjected.Token(Token = "0x4000541")]
		Options
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000107")]
	public enum AxisControl
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000543")]
		DPad,
		[global::Cpp2ILInjected.Token(Token = "0x4000544")]
		DPadLeft,
		[global::Cpp2ILInjected.Token(Token = "0x4000545")]
		DPadRight,
		[global::Cpp2ILInjected.Token(Token = "0x4000546")]
		DPadUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000547")]
		DPadDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000548")]
		DPadDummy,
		[global::Cpp2ILInjected.Token(Token = "0x4000549")]
		LS,
		[global::Cpp2ILInjected.Token(Token = "0x400054A")]
		LSLeft,
		[global::Cpp2ILInjected.Token(Token = "0x400054B")]
		LSRight,
		[global::Cpp2ILInjected.Token(Token = "0x400054C")]
		LSUp,
		[global::Cpp2ILInjected.Token(Token = "0x400054D")]
		LSDown,
		[global::Cpp2ILInjected.Token(Token = "0x400054E")]
		LSClick,
		[global::Cpp2ILInjected.Token(Token = "0x400054F")]
		RS,
		[global::Cpp2ILInjected.Token(Token = "0x4000550")]
		RSLeft,
		[global::Cpp2ILInjected.Token(Token = "0x4000551")]
		RSRight,
		[global::Cpp2ILInjected.Token(Token = "0x4000552")]
		RSUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000553")]
		RSDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000554")]
		RSClick
	}
}
