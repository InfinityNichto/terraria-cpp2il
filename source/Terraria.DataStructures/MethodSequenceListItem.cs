using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200043E")]
public class MethodSequenceListItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006305")]
	public string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006306")]
	public MethodSequenceListItem Parent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006307")]
	public Func<bool> Method;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006308")]
	public bool Skip;

	[Cpp2IlInjected.Token(Token = "0x600314C")]
	[Cpp2IlInjected.Address(RVA = "0x1014040", Offset = "0x1014040", VA = "0x1014040")]
	public MethodSequenceListItem(string name, Func<bool> method, [Optional] MethodSequenceListItem parent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600314D")]
	[Cpp2IlInjected.Address(RVA = "0x1014070", Offset = "0x1014070", VA = "0x1014070")]
	public bool ShouldAct(List<MethodSequenceListItem> sequence)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600314E")]
	[Cpp2IlInjected.Address(RVA = "0x101410C", Offset = "0x101410C", VA = "0x101410C")]
	public bool Act()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600314F")]
	[Cpp2IlInjected.Address(RVA = "0x1014168", Offset = "0x1014168", VA = "0x1014168")]
	public static void ExecuteSequence(List<MethodSequenceListItem> sequence)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003150")]
	[Cpp2IlInjected.Address(RVA = "0x101428C", Offset = "0x101428C", VA = "0x101428C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
