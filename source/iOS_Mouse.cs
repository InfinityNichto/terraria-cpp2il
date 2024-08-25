using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200003F")]
public class iOS_Mouse
{
	[global::Cpp2ILInjected.Token(Token = "0x600015F")]
	[global::Cpp2ILInjected.Address(RVA = "0x7028D8", Offset = "0x7028D8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	public void Setup()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000160")]
	[global::Cpp2ILInjected.Address(RVA = "0x702C98", Offset = "0x702C98", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
	public void Update()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000161")]
	[global::Cpp2ILInjected.Address(RVA = "0x7028C8", Offset = "0x7028C8", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public iOS_Mouse()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40000F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool wasMouseConnected;

	[global::Cpp2ILInjected.Token(Token = "0x40000F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public Vector3 lastUnityMousePosition;

	[global::Cpp2ILInjected.Token(Token = "0x40000F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector3 MousePosition;

	[global::Cpp2ILInjected.Token(Token = "0x40000F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public bool MouseLeft;

	[global::Cpp2ILInjected.Token(Token = "0x40000F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
	public bool MouseRight;

	[global::Cpp2ILInjected.Token(Token = "0x40000FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E")]
	public bool MouseMiddle;

	[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F")]
	public bool MouseLeftPrev;

	[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool MouseRightPrev;

	[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
	public bool MouseMiddlePrev;

	[global::Cpp2ILInjected.Token(Token = "0x40000FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float MouseScroll;

	[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool UseSWCursor;
}
