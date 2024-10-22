﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200001C")]
internal class DrKeyboard_IME : DrKeyboard_Base
{
	[global::Cpp2ILInjected.Token(Token = "0x600008D")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE3CC", Offset = "0x6FE3CC", Length = "0x78")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "set_imeCompositionMode", MemberParameters = new object[] { typeof(IMECompositionMode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public DrKeyboard_IME(string initialText, int maxChars, string title, string prompt)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000027")]
	public override bool active
	{
		[global::Cpp2ILInjected.Token(Token = "0x600008E")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FE694", Offset = "0x6FE694", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_imeCompositionMode", ReturnType = typeof(IMECompositionMode))]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600008F")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FE6B0", Offset = "0x6FE6B0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "set_imeCompositionMode", MemberParameters = new object[] { typeof(IMECompositionMode) }, ReturnType = typeof(void))]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000028")]
	public override bool done
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000090")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FE6C4", Offset = "0x6FE6C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000029")]
	public override string text
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000091")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FE6CC", Offset = "0x6FE6CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000092")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FE6D4", Offset = "0x6FE6D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
	public override bool wasCanceled
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000093")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FE6DC", Offset = "0x6FE6DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000094")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE6E4", Offset = "0x6FE6E4", Length = "0x1E4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyDown", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_inputString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrKeyboard_IME), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public override void Update()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000095")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE99C", Offset = "0x6FE99C", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrKeyboard_IME), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	private void Append(string input)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000063")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int _lastFrame;

	[global::Cpp2ILInjected.Token(Token = "0x4000064")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private string _lastIME;

	[global::Cpp2ILInjected.Token(Token = "0x4000065")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private string _text;

	[global::Cpp2ILInjected.Token(Token = "0x4000066")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool _wasCanceled;
}
