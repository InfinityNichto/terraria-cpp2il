using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.Audio;
using UnityEngine;

// Token: 0x02000109 RID: 265
[global::Cpp2ILInjected.Token(Token = "0x200017A")]
public class GUIZoom
{
	// Token: 0x060009BD RID: 2493 RVA: 0x0002387C File Offset: 0x00021A7C
	[global::Cpp2ILInjected.Token(Token = "0x6000ABD")]
	[global::Cpp2ILInjected.Address(RVA = "0x99FD38", Offset = "0x99FD38", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "LoadDefaultZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public float GetDefaultWorldZoomScale()
	{
		throw null;
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x0002387F File Offset: 0x00021A7F
	[global::Cpp2ILInjected.Token(Token = "0x6000ABE")]
	[global::Cpp2ILInjected.Address(RVA = "0x99FDFC", Offset = "0x99FDFC", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIZoom), Member = "GetDefaultWorldZoomScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void LoadDefaultZoom()
	{
		throw null;
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00023882 File Offset: 0x00021A82
	[global::Cpp2ILInjected.Token(Token = "0x6000ABF")]
	[global::Cpp2ILInjected.Address(RVA = "0x99FEB4", Offset = "0x99FEB4", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public GUIZoom()
	{
		throw null;
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00023885 File Offset: 0x00021A85
	[global::Cpp2ILInjected.Token(Token = "0x6000AC0")]
	[global::Cpp2ILInjected.Address(RVA = "0x99FFE8", Offset = "0x99FFE8", Length = "0x1F0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	private bool IsCursorOver(Microsoft.Xna.Framework.Vector2 position, out float sliderPosition)
	{
		throw null;
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00023888 File Offset: 0x00021A88
	[global::Cpp2ILInjected.Token(Token = "0x6000AC1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A01D8", Offset = "0x9A01D8", Length = "0x434")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "UpdatePixelZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "UpdatePinchZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_playerInventory", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_npcChatCornerItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapFullscreen", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapFullscreenPos", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapFullscreenScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_flushLighting", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private void ApplyPixelZoom(float pixelScale)
	{
		throw null;
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x0002388B File Offset: 0x00021A8B
	[global::Cpp2ILInjected.Token(Token = "0x6000AC2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A060C", Offset = "0x9A060C", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIZoom), Member = "ApplyPixelZoom", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void UpdatePixelZoom()
	{
		throw null;
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x0002388E File Offset: 0x00021A8E
	[global::Cpp2ILInjected.Token(Token = "0x6000AC3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A066C", Offset = "0x9A066C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void UpdateCursorDummy(global::Cursor cursor)
	{
		throw null;
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00023891 File Offset: 0x00021A91
	[global::Cpp2ILInjected.Token(Token = "0x6000AC4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A0670", Offset = "0x9A0670", Length = "0x138")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIZoom), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(ref float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIZoom), Member = "UpdatePixelZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void UpdateCursor(global::Cursor cursor)
	{
		throw null;
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00023894 File Offset: 0x00021A94
	[global::Cpp2ILInjected.Token(Token = "0x6000AC5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A07A8", Offset = "0x9A07A8", Length = "0x648")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetNumCursors", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetCursor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "ResetMapPing", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreenPos", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreenScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapFullscreenPos", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "IsCursorOverFullScreenMapControls", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIZoom), Member = "ApplyPixelZoom", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
	public void UpdatePinchZoom()
	{
		throw null;
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00023897 File Offset: 0x00021A97
	[global::Cpp2ILInjected.Token(Token = "0x6000AC6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A0DF0", Offset = "0x9A0DF0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x0400083E RID: 2110
	[global::Cpp2ILInjected.Token(Token = "0x4000B15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool draggingSlider;

	// Token: 0x0400083F RID: 2111
	[global::Cpp2ILInjected.Token(Token = "0x4000B16")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float ZoomValue;

	// Token: 0x04000840 RID: 2112
	[global::Cpp2ILInjected.Token(Token = "0x4000B17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private CursorInputLayer _inputLayer;

	// Token: 0x04000841 RID: 2113
	[global::Cpp2ILInjected.Token(Token = "0x4000B18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private CursorInputLayer _inputlayerZoomPinch;

	// Token: 0x04000842 RID: 2114
	[global::Cpp2ILInjected.Token(Token = "0x4000B19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float MaxZoomValue;

	// Token: 0x04000843 RID: 2115
	[global::Cpp2ILInjected.Token(Token = "0x4000B1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float DefaultWorldZoomScale;

	// Token: 0x04000844 RID: 2116
	[global::Cpp2ILInjected.Token(Token = "0x4000B1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private bool _pinchZoomActive;

	// Token: 0x04000845 RID: 2117
	[global::Cpp2ILInjected.Token(Token = "0x4000B1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private global::Cursor _zoomCursor0;

	// Token: 0x04000846 RID: 2118
	[global::Cpp2ILInjected.Token(Token = "0x4000B1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private global::Cursor _zoomCursor1;

	// Token: 0x04000847 RID: 2119
	[global::Cpp2ILInjected.Token(Token = "0x4000B1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::UnityEngine.Vector2 _initialPosition0;

	// Token: 0x04000848 RID: 2120
	[global::Cpp2ILInjected.Token(Token = "0x4000B1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private global::UnityEngine.Vector2 _initialPosition1;

	// Token: 0x04000849 RID: 2121
	[global::Cpp2ILInjected.Token(Token = "0x4000B20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private bool _lastFrameFullScreenMap;

	// Token: 0x0400084A RID: 2122
	[global::Cpp2ILInjected.Token(Token = "0x4000B21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private Microsoft.Xna.Framework.Vector2 _lastFrameGrabCentre;

	// Token: 0x0400084B RID: 2123
	[global::Cpp2ILInjected.Token(Token = "0x4000B22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private float _initialZoom;

	// Token: 0x0400084C RID: 2124
	[global::Cpp2ILInjected.Token(Token = "0x4000B23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public bool PinchZoomWorldEnabled;

	// Token: 0x0400084D RID: 2125
	[global::Cpp2ILInjected.Token(Token = "0x4000B24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
	public bool PinchZoomMapEnabled;
}
