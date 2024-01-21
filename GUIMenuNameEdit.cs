using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001CF")]
public class GUIMenuNameEdit
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001474")]
	private string _editedName;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001475")]
	private bool _enabled;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool Enabled
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB3")]
		[Cpp2IlInjected.Address(RVA = "0x11E0118", Offset = "0x11E0118", VA = "0x11E0118")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CB4")]
		[Cpp2IlInjected.Address(RVA = "0x11E0120", Offset = "0x11E0120", VA = "0x11E0120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public string Name
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB5")]
		[Cpp2IlInjected.Address(RVA = "0x11E01B0", Offset = "0x11E01B0", VA = "0x11E01B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x11E01B8", Offset = "0x11E01B8", VA = "0x11E01B8")]
	public void Enable(string nomen)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x11E02AC", Offset = "0x11E02AC", VA = "0x11E02AC")]
	public string GetInputText(Rectangle region, int maxCharacters = -1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x11E04B8", Offset = "0x11E04B8", VA = "0x11E04B8")]
	public GUIMenuNameEdit()
	{
	}
}
