using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200003C")]
[Serializable]
public class DrEditorProfile
{
	[global::Cpp2ILInjected.Token(Token = "0x600014C")]
	[global::Cpp2ILInjected.Address(RVA = "0x704694", Offset = "0x704694", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public DrEditorProfile()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Name;

	[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string RootFolder;

	[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool HasMultiplayerPermission;

	[global::Cpp2ILInjected.Token(Token = "0x40000DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
	public bool HasChatPermission;

	[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
	public bool HasUGCPermission;
}
