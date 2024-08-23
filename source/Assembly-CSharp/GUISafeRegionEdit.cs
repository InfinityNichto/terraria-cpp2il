using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020001E1 RID: 481
[global::Cpp2ILInjected.Token(Token = "0x200027E")]
public class GUISafeRegionEdit
{
	// Token: 0x06000D4D RID: 3405 RVA: 0x0002432C File Offset: 0x0002252C
	[global::Cpp2ILInjected.Token(Token = "0x6000E6C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA005F8", Offset = "0xA005F8", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer.CursorUpdater), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer), Member = "set_Priority", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public GUISafeRegionEdit()
	{
		throw null;
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x0002432F File Offset: 0x0002252F
	[global::Cpp2ILInjected.Token(Token = "0x6000E6D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA006C0", Offset = "0xA006C0", Length = "0x2CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(QuickActionButton_Layout)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void UpdateCursor(global::Cursor cursor)
	{
		throw null;
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x00024332 File Offset: 0x00022532
	[global::Cpp2ILInjected.Token(Token = "0x6000E6E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0098C", Offset = "0xA0098C", Length = "0x4D4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void DrawBacking()
	{
		throw null;
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x00024335 File Offset: 0x00022535
	[global::Cpp2ILInjected.Token(Token = "0x6000E6F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA00E60", Offset = "0xA00E60", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISafeRegionEdit), Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "SetSafeArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void UpdateEdit()
	{
		throw null;
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00024338 File Offset: 0x00022538
	[global::Cpp2ILInjected.Token(Token = "0x6000E70")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0161C", Offset = "0xA0161C", Length = "0x2C0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x0002433B File Offset: 0x0002253B
	[global::Cpp2ILInjected.Token(Token = "0x6000E71")]
	[global::Cpp2ILInjected.Address(RVA = "0xA00F30", Offset = "0xA00F30", Length = "0x6EC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionVector),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetNumCursors", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetCursor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_xMin", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_xMax", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_yMin", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_yMax", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	private bool UpdateCursorDragging(ref Rect safeArea)
	{
		throw null;
	}

	// Token: 0x0400153A RID: 5434
	[global::Cpp2ILInjected.Token(Token = "0x4001A53")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private CursorInputLayer _inputLayer;

	// Token: 0x0400153B RID: 5435
	[global::Cpp2ILInjected.Token(Token = "0x4001A54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float leftInitialOffset;

	// Token: 0x0400153C RID: 5436
	[global::Cpp2ILInjected.Token(Token = "0x4001A55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float rightInitialOffset;

	// Token: 0x0400153D RID: 5437
	[global::Cpp2ILInjected.Token(Token = "0x4001A56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float topInitialOffset;

	// Token: 0x0400153E RID: 5438
	[global::Cpp2ILInjected.Token(Token = "0x4001A57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float bottomInitialOffset;

	// Token: 0x0400153F RID: 5439
	[global::Cpp2ILInjected.Token(Token = "0x4001A58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float leftScale;

	// Token: 0x04001540 RID: 5440
	[global::Cpp2ILInjected.Token(Token = "0x4001A59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private float rightScale;

	// Token: 0x04001541 RID: 5441
	[global::Cpp2ILInjected.Token(Token = "0x4001A5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float topScale;

	// Token: 0x04001542 RID: 5442
	[global::Cpp2ILInjected.Token(Token = "0x4001A5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private float bottomScale;

	// Token: 0x04001543 RID: 5443
	[global::Cpp2ILInjected.Token(Token = "0x4001A5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private float finishScale;

	// Token: 0x04001544 RID: 5444
	[global::Cpp2ILInjected.Token(Token = "0x4001A5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private float resetScale;

	// Token: 0x04001545 RID: 5445
	[global::Cpp2ILInjected.Token(Token = "0x4001A5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private bool LeftPressed;

	// Token: 0x04001546 RID: 5446
	[global::Cpp2ILInjected.Token(Token = "0x4001A5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
	private bool RightPressed;

	// Token: 0x04001547 RID: 5447
	[global::Cpp2ILInjected.Token(Token = "0x4001A60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
	private bool TopPressed;

	// Token: 0x04001548 RID: 5448
	[global::Cpp2ILInjected.Token(Token = "0x4001A61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x43")]
	private bool BottomPressed;
}
