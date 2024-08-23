using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200001B RID: 27
[global::Cpp2ILInjected.Token(Token = "0x2000020")]
public class DrKeyboard_Touch : DrKeyboard_Base
{
	// Token: 0x0600008D RID: 141 RVA: 0x00021D1F File Offset: 0x0001FF1F
	[global::Cpp2ILInjected.Token(Token = "0x6000099")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEA58", Offset = "0x6FEA58", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "OnApplicationFocus", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static void AppFocusGained()
	{
		throw null;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00021D22 File Offset: 0x0001FF22
	[global::Cpp2ILInjected.Token(Token = "0x600009A")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE58C", Offset = "0x6FE58C", Length = "0xD4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrKeyboard_Base), Member = "Create", MemberParameters = new object[]
	{
		typeof(TouchScreenKeyboardType),
		typeof(string),
		typeof(int),
		typeof(string),
		typeof(string),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(DrKeyboard_Base))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrKeyboard_PS4), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(TouchScreenKeyboardType),
		typeof(string),
		typeof(int),
		typeof(string),
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrKeyboard_Stadia), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(TouchScreenKeyboardType),
		typeof(string),
		typeof(int),
		typeof(string),
		typeof(string),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrKeyboard_Switch), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(TouchScreenKeyboardType),
		typeof(string),
		typeof(int),
		typeof(string),
		typeof(string),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrKeyboard_XBO), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(TouchScreenKeyboardType),
		typeof(string),
		typeof(int),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new object[]
	{
		typeof(string),
		typeof(TouchScreenKeyboardType),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(TouchScreenKeyboard))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public DrKeyboard_Touch(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool password = false, bool multiline = false)
	{
		throw null;
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600008F RID: 143 RVA: 0x00021D25 File Offset: 0x0001FF25
	// (set) Token: 0x06000090 RID: 144 RVA: 0x00021D28 File Offset: 0x0001FF28
	[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
	public override bool active
	{
		[global::Cpp2ILInjected.Token(Token = "0x600009B")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FEAA4", Offset = "0x6FEAA4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(TouchScreenKeyboard.Status))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600009C")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FEB10", Offset = "0x6FEB10", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000091 RID: 145 RVA: 0x00021D2B File Offset: 0x0001FF2B
	[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
	public override bool done
	{
		[global::Cpp2ILInjected.Token(Token = "0x600009D")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FEB20", Offset = "0x6FEB20", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(TouchScreenKeyboard.Status))]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000092 RID: 146 RVA: 0x00021D2E File Offset: 0x0001FF2E
	// (set) Token: 0x06000093 RID: 147 RVA: 0x00021D31 File Offset: 0x0001FF31
	[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
	public override string text
	{
		[global::Cpp2ILInjected.Token(Token = "0x600009E")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FEB40", Offset = "0x6FEB40", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600009F")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FEB4C", Offset = "0x6FEB4C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000094 RID: 148 RVA: 0x00021D34 File Offset: 0x0001FF34
	[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
	public override bool wasCanceled
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FEB58", Offset = "0x6FEB58", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(TouchScreenKeyboard.Status))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		get
		{
			throw null;
		}
	}

	// Token: 0x04000061 RID: 97
	[global::Cpp2ILInjected.Token(Token = "0x4000068")]
	private static bool appGainedFocus;

	// Token: 0x04000062 RID: 98
	[global::Cpp2ILInjected.Token(Token = "0x4000069")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private TouchScreenKeyboard _keyboard;
}
