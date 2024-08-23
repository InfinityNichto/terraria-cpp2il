using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using UnityEngine;

// Token: 0x02000015 RID: 21
[global::Cpp2ILInjected.Token(Token = "0x2000018")]
public class CursorManager
{
	// Token: 0x0600005F RID: 95 RVA: 0x00021CA7 File Offset: 0x0001FEA7
	[global::Cpp2ILInjected.Token(Token = "0x600006A")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FC5DC", Offset = "0x6FC5DC", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static CursorManager Create()
	{
		throw null;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00021CAA File Offset: 0x0001FEAA
	[global::Cpp2ILInjected.Token(Token = "0x600006B")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FC638", Offset = "0x6FC638", Length = "0x1CC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "Create", ReturnType = typeof(CursorManager))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<CursorManager.TouchInput>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<CursorManager.CursorFirstContact>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
	public CursorManager()
	{
		throw null;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00021CAD File Offset: 0x0001FEAD
	[global::Cpp2ILInjected.Token(Token = "0x600006C")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FC804", Offset = "0x6FC804", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "IsMouseActive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	public bool IsCursorActive()
	{
		throw null;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00021CB0 File Offset: 0x0001FEB0
	[global::Cpp2ILInjected.Token(Token = "0x600006D")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FC9A4", Offset = "0x6FC9A4", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "GetPressedControlPosition", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType),
		typeof(ref VirtualControlsHardwareConfigurationMapping_Layout)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "UpdatePinchZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetCursor", MemberParameters = new object[] { typeof(GUIPageIconGrouping) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "CancelDrag", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "GetWorldCursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mouse), Member = "ActiveCursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_36_Cursor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSunAndMoon", MemberParameters = new object[]
	{
		typeof(Main.SceneArea),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawStarsInBackground", MemberParameters = new object[]
	{
		typeof(Main.SceneArea),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public int GetNumCursors()
	{
		throw null;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00021CB3 File Offset: 0x0001FEB3
	[global::Cpp2ILInjected.Token(Token = "0x600006E")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FC9E4", Offset = "0x6FC9E4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "GetPressedControlPosition", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType),
		typeof(ref VirtualControlsHardwareConfigurationMapping_Layout)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "UpdatePinchZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetCursor", MemberParameters = new object[] { typeof(GUIPageIconGrouping) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "CancelDrag", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "GetWorldCursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mouse), Member = "ActiveCursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_36_Cursor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public global::Cursor GetCursor(int index)
	{
		throw null;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00021CB6 File Offset: 0x0001FEB6
	[global::Cpp2ILInjected.Token(Token = "0x600006F")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FCA3C", Offset = "0x6FCA3C", Length = "0x450")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer), Member = "Resort", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
	public void UpdateCursors()
	{
		throw null;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00021CB9 File Offset: 0x0001FEB9
	[global::Cpp2ILInjected.Token(Token = "0x6000070")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FC850", Offset = "0x6FC850", Length = "0x154")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "IsCursorActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "GetTouchCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonDown", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButton", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonUp", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private bool IsMouseActive(int index)
	{
		throw null;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00021CBC File Offset: 0x0001FEBC
	[global::Cpp2ILInjected.Token(Token = "0x6000071")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FD588", Offset = "0x6FD588", Length = "0xF4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonDown", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButton", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonUp", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private bool IsTouchScrollOnly(int touchIndex)
	{
		throw null;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00021CBF File Offset: 0x0001FEBF
	[global::Cpp2ILInjected.Token(Token = "0x6000072")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FD70C", Offset = "0x6FD70C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	public int GetRealTouchCount()
	{
		throw null;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00021CC2 File Offset: 0x0001FEC2
	[global::Cpp2ILInjected.Token(Token = "0x6000073")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FD714", Offset = "0x6FD714", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateMouseEMUTouches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "IsMouseActive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public int GetTouchCount()
	{
		throw null;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00021CC5 File Offset: 0x0001FEC5
	[global::Cpp2ILInjected.Token(Token = "0x6000074")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FD67C", Offset = "0x6FD67C", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "IsTouchScrollOnly", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "GetTouchPhase", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TouchPhase))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "GetTouchPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateMouseEMUTouches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touches", ReturnType = typeof(Touch[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_fingerId", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private int GetTouchId(int touchIndex)
	{
		throw null;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00021CC8 File Offset: 0x0001FEC8
	[global::Cpp2ILInjected.Token(Token = "0x6000075")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FD808", Offset = "0x6FD808", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touches", ReturnType = typeof(Touch[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_fingerId", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private int GetTouchIndex(int touchId)
	{
		throw null;
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600006B RID: 107 RVA: 0x00021CCB File Offset: 0x0001FECB
	[global::Cpp2ILInjected.Token(Token = "0x17000021")]
	public bool EmuMouseModeActive
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000076")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FD914", Offset = "0x6FD914", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "get_MousePosition", ReturnType = typeof(global::UnityEngine.Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseScrollDelta", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseButton", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonUp", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonDown", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_HasHWCursor", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00021CCE File Offset: 0x0001FECE
	[global::Cpp2ILInjected.Token(Token = "0x6000077")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FD934", Offset = "0x6FD934", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseButton", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public bool GetEMUMouseButton(int index)
	{
		throw null;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00021CD1 File Offset: 0x0001FED1
	[global::Cpp2ILInjected.Token(Token = "0x6000078")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FD98C", Offset = "0x6FD98C", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonDown", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public bool GetEMUMouseButtonDown(int index)
	{
		throw null;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00021CD4 File Offset: 0x0001FED4
	[global::Cpp2ILInjected.Token(Token = "0x6000079")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FD9F0", Offset = "0x6FD9F0", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonUp", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public bool GetEMUMouseButtonUp(int index)
	{
		throw null;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00021CD7 File Offset: 0x0001FED7
	[global::Cpp2ILInjected.Token(Token = "0x600007A")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FDA58", Offset = "0x6FDA58", Length = "0x278")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateMouseEMUTouches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonDown", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touches", ReturnType = typeof(Touch[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButton", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonUp", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseScrollDelta", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	private TouchPhase GetTouchPhase(int touchIndex)
	{
		throw null;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00021CDA File Offset: 0x0001FEDA
	[global::Cpp2ILInjected.Token(Token = "0x600007B")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FDCD0", Offset = "0x6FDCD0", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touches", ReturnType = typeof(Touch[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_type", ReturnType = typeof(TouchType))]
	private bool ShouldIgnoreTouch(int touchIndex)
	{
		throw null;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00021CDD File Offset: 0x0001FEDD
	[global::Cpp2ILInjected.Token(Token = "0x600007C")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FDD18", Offset = "0x6FDD18", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateMouseEMUTouches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touches", ReturnType = typeof(Touch[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_position", ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_MousePositionReal", ReturnType = typeof(global::UnityEngine.Vector3))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private global::UnityEngine.Vector2 GetTouchPosition(int touchIndex)
	{
		throw null;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00021CE0 File Offset: 0x0001FEE0
	[global::Cpp2ILInjected.Token(Token = "0x600007D")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FDDD4", Offset = "0x6FDDD4", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private global::UnityEngine.Vector2 GetTouchScroll(int touchIndex)
	{
		throw null;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00021CE3 File Offset: 0x0001FEE3
	[global::Cpp2ILInjected.Token(Token = "0x600007E")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FDE28", Offset = "0x6FDE28", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "ScaleUIDirectionForRealScreen", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private bool ShouldIgnoreForWorld(global::UnityEngine.Vector2 position)
	{
		throw null;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00021CE6 File Offset: 0x0001FEE6
	[global::Cpp2ILInjected.Token(Token = "0x600007F")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FDF5C", Offset = "0x6FDF5C", Length = "0x260")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_KeyboardModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_MousePosition", ReturnType = typeof(global::UnityEngine.Vector3))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButton", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchPhase", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TouchPhase))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<CursorManager.TouchInput>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void UpdateMouseEMUTouches()
	{
		throw null;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00021CE9 File Offset: 0x0001FEE9
	[global::Cpp2ILInjected.Token(Token = "0x6000080")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FCE8C", Offset = "0x6FCE8C", Length = "0x6FC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursors", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButton", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonUp", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "UpdateMouseEMUTouches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchPhase", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TouchPhase))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchScroll", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "ShouldIgnoreTouch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetTouchId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "IsTouchScrollOnly", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "ShouldIgnoreForWorld", MemberParameters = new object[] { typeof(global::UnityEngine.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<CursorManager.CursorFirstContact>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<CursorManager.CursorFirstContact>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
	private void UpdateCursorList()
	{
		throw null;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00021CEC File Offset: 0x0001FEEC
	[global::Cpp2ILInjected.Token(Token = "0x6000081")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE1CC", Offset = "0x6FE1CC", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<CursorManager.CursorFirstContact>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawPickPoint", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void DrawCursorOverlay(SpriteBatch batch)
	{
		throw null;
	}

	// Token: 0x0400004A RID: 74
	[global::Cpp2ILInjected.Token(Token = "0x400004C")]
	public static CursorManager Instance;

	// Token: 0x0400004B RID: 75
	[global::Cpp2ILInjected.Token(Token = "0x400004D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int _touchCount;

	// Token: 0x0400004C RID: 76
	[global::Cpp2ILInjected.Token(Token = "0x400004E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public bool ActivateMouseMode;

	// Token: 0x0400004D RID: 77
	[global::Cpp2ILInjected.Token(Token = "0x400004F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
	private bool emuTouchFromMouse;

	// Token: 0x0400004E RID: 78
	[global::Cpp2ILInjected.Token(Token = "0x4000050")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x16")]
	private bool fakeMouseActive;

	// Token: 0x0400004F RID: 79
	[global::Cpp2ILInjected.Token(Token = "0x4000051")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x17")]
	private bool mouseActive;

	// Token: 0x04000050 RID: 80
	[global::Cpp2ILInjected.Token(Token = "0x4000052")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private global::UnityEngine.Vector2 fakeMousePosition;

	// Token: 0x04000051 RID: 81
	[global::Cpp2ILInjected.Token(Token = "0x4000053")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private bool updatingSwitchTouches;

	// Token: 0x04000052 RID: 82
	[global::Cpp2ILInjected.Token(Token = "0x4000054")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private List<CursorManager.TouchInput> UserSwitchTouches;

	// Token: 0x04000053 RID: 83
	[global::Cpp2ILInjected.Token(Token = "0x4000055")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private bool emuMouseModeActive;

	// Token: 0x04000054 RID: 84
	[global::Cpp2ILInjected.Token(Token = "0x4000056")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
	private bool updatingEMUMouseTouches;

	// Token: 0x04000055 RID: 85
	[global::Cpp2ILInjected.Token(Token = "0x4000057")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private global::UnityEngine.Vector3 emuMouseLastHWMousePosition;

	// Token: 0x04000056 RID: 86
	[global::Cpp2ILInjected.Token(Token = "0x4000058")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::UnityEngine.Vector2 EmuMousePosition;

	// Token: 0x04000057 RID: 87
	[global::Cpp2ILInjected.Token(Token = "0x4000059")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private List<CursorManager.TouchInput> EMUMouseTouches;

	// Token: 0x04000058 RID: 88
	[global::Cpp2ILInjected.Token(Token = "0x400005A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private List<CursorManager.TouchInput> PreviousEMUMouseTouches;

	// Token: 0x04000059 RID: 89
	[global::Cpp2ILInjected.Token(Token = "0x400005B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private List<global::Cursor> _cursors;

	// Token: 0x0400005A RID: 90
	[global::Cpp2ILInjected.Token(Token = "0x400005C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private List<CursorManager.CursorFirstContact> _cursorsInpacts;

	// Token: 0x0400005B RID: 91
	[global::Cpp2ILInjected.Token(Token = "0x400005D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public List<CursorInputLayer> Layers;

	// Token: 0x0200076D RID: 1901
	[global::Cpp2ILInjected.Token(Token = "0x2000019")]
	public struct TouchInput
	{
		// Token: 0x0600480B RID: 18443 RVA: 0x0002EDA2 File Offset: 0x0002CFA2
		[global::Cpp2ILInjected.Token(Token = "0x6000082")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FE1BC", Offset = "0x6FE1BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public TouchInput(int id, global::UnityEngine.Vector2 position, TouchPhase phase)
		{
			throw null;
		}

		// Token: 0x040077F9 RID: 30713
		[global::Cpp2ILInjected.Token(Token = "0x400005E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly int TouchId;

		// Token: 0x040077FA RID: 30714
		[global::Cpp2ILInjected.Token(Token = "0x400005F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly global::UnityEngine.Vector2 TouchPosition;

		// Token: 0x040077FB RID: 30715
		[global::Cpp2ILInjected.Token(Token = "0x4000060")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public readonly TouchPhase TouchPhase;
	}

	// Token: 0x0200076E RID: 1902
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	private struct CursorFirstContact
	{
		// Token: 0x040077FC RID: 30716
		[global::Cpp2ILInjected.Token(Token = "0x4000061")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::UnityEngine.Vector2 position;

		// Token: 0x040077FD RID: 30717
		[global::Cpp2ILInjected.Token(Token = "0x4000062")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public DateTime time;
	}
}
