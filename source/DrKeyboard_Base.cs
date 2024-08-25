using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200001B")]
public abstract class DrKeyboard_Base
{
	[global::Cpp2ILInjected.Token(Token = "0x6000083")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE2D8", Offset = "0x6FE2D8", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OpenKeyboard", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrKeyboard_IME), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrKeyboard_Touch), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(TouchScreenKeyboardType),
		typeof(string),
		typeof(int),
		typeof(string),
		typeof(string),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public static DrKeyboard_Base Create(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool password = false, bool multiline = false, bool filterText = true)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000022")]
	public static bool isSupported
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000084")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FE660", Offset = "0x6FE660", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000023")]
	public abstract bool active
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000085")]
		get;
		[global::Cpp2ILInjected.Token(Token = "0x6000086")]
		set;
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000024")]
	public abstract bool wasCanceled
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000087")]
		get;
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000025")]
	public abstract bool done
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000088")]
		get;
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000026")]
	public abstract string text
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000089")]
		get;
		[global::Cpp2ILInjected.Token(Token = "0x600008A")]
		set;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008B")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE688", Offset = "0x6FE688", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Update()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008C")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE68C", Offset = "0x6FE68C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	protected DrKeyboard_Base()
	{
		throw null;
	}
}
