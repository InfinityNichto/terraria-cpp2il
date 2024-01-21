using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DrEditorProfile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public string RootFolder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool HasMultiplayerPermission;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public bool HasChatPermission;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public bool HasUGCPermission;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x20CCEA8", Offset = "0x20CCEA8", VA = "0x20CCEA8")]
	public DrEditorProfile()
	{
	}
}
