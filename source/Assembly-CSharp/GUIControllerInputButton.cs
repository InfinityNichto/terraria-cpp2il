using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Initializers;
using UnityEngine;

// Token: 0x020000B8 RID: 184
[global::Cpp2ILInjected.Token(Token = "0x2000104")]
public static class GUIControllerInputButton
{
	// Token: 0x060005DC RID: 1500 RVA: 0x00022CD9 File Offset: 0x00020ED9
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

	// Token: 0x060005DD RID: 1501 RVA: 0x00022CDC File Offset: 0x00020EDC
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

	// Token: 0x060005DE RID: 1502 RVA: 0x00022CDF File Offset: 0x00020EDF
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

	// Token: 0x060005DF RID: 1503 RVA: 0x00022CE2 File Offset: 0x00020EE2
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

	// Token: 0x0400036A RID: 874
	[global::Cpp2ILInjected.Token(Token = "0x4000529")]
	private const ControllerDevice.ControlScheme defaultScheme = ControllerDevice.ControlScheme.CONTROLS_ABXY_XBOX;

	// Token: 0x0400036B RID: 875
	[global::Cpp2ILInjected.Token(Token = "0x400052A")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D ButtonControls;

	// Token: 0x0400036C RID: 876
	[global::Cpp2ILInjected.Token(Token = "0x400052B")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D ShoulderButtonControls;

	// Token: 0x0400036D RID: 877
	[global::Cpp2ILInjected.Token(Token = "0x400052C")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D AxisControls;

	// Token: 0x0400036E RID: 878
	[global::Cpp2ILInjected.Token(Token = "0x400052D")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D PS4TouchPad;

	// Token: 0x020007AE RID: 1966
	[global::Cpp2ILInjected.Token(Token = "0x2000105")]
	public enum LinkedControlType
	{
		// Token: 0x040079A5 RID: 31141
		[global::Cpp2ILInjected.Token(Token = "0x400052F")]
		Action1,
		// Token: 0x040079A6 RID: 31142
		[global::Cpp2ILInjected.Token(Token = "0x4000530")]
		Action2,
		// Token: 0x040079A7 RID: 31143
		[global::Cpp2ILInjected.Token(Token = "0x4000531")]
		Action3,
		// Token: 0x040079A8 RID: 31144
		[global::Cpp2ILInjected.Token(Token = "0x4000532")]
		Action4,
		// Token: 0x040079A9 RID: 31145
		[global::Cpp2ILInjected.Token(Token = "0x4000533")]
		LB,
		// Token: 0x040079AA RID: 31146
		[global::Cpp2ILInjected.Token(Token = "0x4000534")]
		RB,
		// Token: 0x040079AB RID: 31147
		[global::Cpp2ILInjected.Token(Token = "0x4000535")]
		LT,
		// Token: 0x040079AC RID: 31148
		[global::Cpp2ILInjected.Token(Token = "0x4000536")]
		RT,
		// Token: 0x040079AD RID: 31149
		[global::Cpp2ILInjected.Token(Token = "0x4000537")]
		View,
		// Token: 0x040079AE RID: 31150
		[global::Cpp2ILInjected.Token(Token = "0x4000538")]
		Options,
		// Token: 0x040079AF RID: 31151
		[global::Cpp2ILInjected.Token(Token = "0x4000539")]
		LeftStick,
		// Token: 0x040079B0 RID: 31152
		[global::Cpp2ILInjected.Token(Token = "0x400053A")]
		RightStick
	}

	// Token: 0x020007AF RID: 1967
	[global::Cpp2ILInjected.Token(Token = "0x2000106")]
	public enum ShoulderButtonControl
	{
		// Token: 0x040079B2 RID: 31154
		[global::Cpp2ILInjected.Token(Token = "0x400053C")]
		LB,
		// Token: 0x040079B3 RID: 31155
		[global::Cpp2ILInjected.Token(Token = "0x400053D")]
		RB,
		// Token: 0x040079B4 RID: 31156
		[global::Cpp2ILInjected.Token(Token = "0x400053E")]
		LT,
		// Token: 0x040079B5 RID: 31157
		[global::Cpp2ILInjected.Token(Token = "0x400053F")]
		RT,
		// Token: 0x040079B6 RID: 31158
		[global::Cpp2ILInjected.Token(Token = "0x4000540")]
		View,
		// Token: 0x040079B7 RID: 31159
		[global::Cpp2ILInjected.Token(Token = "0x4000541")]
		Options
	}

	// Token: 0x020007B0 RID: 1968
	[global::Cpp2ILInjected.Token(Token = "0x2000107")]
	public enum AxisControl
	{
		// Token: 0x040079B9 RID: 31161
		[global::Cpp2ILInjected.Token(Token = "0x4000543")]
		DPad,
		// Token: 0x040079BA RID: 31162
		[global::Cpp2ILInjected.Token(Token = "0x4000544")]
		DPadLeft,
		// Token: 0x040079BB RID: 31163
		[global::Cpp2ILInjected.Token(Token = "0x4000545")]
		DPadRight,
		// Token: 0x040079BC RID: 31164
		[global::Cpp2ILInjected.Token(Token = "0x4000546")]
		DPadUp,
		// Token: 0x040079BD RID: 31165
		[global::Cpp2ILInjected.Token(Token = "0x4000547")]
		DPadDown,
		// Token: 0x040079BE RID: 31166
		[global::Cpp2ILInjected.Token(Token = "0x4000548")]
		DPadDummy,
		// Token: 0x040079BF RID: 31167
		[global::Cpp2ILInjected.Token(Token = "0x4000549")]
		LS,
		// Token: 0x040079C0 RID: 31168
		[global::Cpp2ILInjected.Token(Token = "0x400054A")]
		LSLeft,
		// Token: 0x040079C1 RID: 31169
		[global::Cpp2ILInjected.Token(Token = "0x400054B")]
		LSRight,
		// Token: 0x040079C2 RID: 31170
		[global::Cpp2ILInjected.Token(Token = "0x400054C")]
		LSUp,
		// Token: 0x040079C3 RID: 31171
		[global::Cpp2ILInjected.Token(Token = "0x400054D")]
		LSDown,
		// Token: 0x040079C4 RID: 31172
		[global::Cpp2ILInjected.Token(Token = "0x400054E")]
		LSClick,
		// Token: 0x040079C5 RID: 31173
		[global::Cpp2ILInjected.Token(Token = "0x400054F")]
		RS,
		// Token: 0x040079C6 RID: 31174
		[global::Cpp2ILInjected.Token(Token = "0x4000550")]
		RSLeft,
		// Token: 0x040079C7 RID: 31175
		[global::Cpp2ILInjected.Token(Token = "0x4000551")]
		RSRight,
		// Token: 0x040079C8 RID: 31176
		[global::Cpp2ILInjected.Token(Token = "0x4000552")]
		RSUp,
		// Token: 0x040079C9 RID: 31177
		[global::Cpp2ILInjected.Token(Token = "0x4000553")]
		RSDown,
		// Token: 0x040079CA RID: 31178
		[global::Cpp2ILInjected.Token(Token = "0x4000554")]
		RSClick
	}
}
