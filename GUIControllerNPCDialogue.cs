using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GUIControllerNPCDialogue : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private int _selected;

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1211658", Offset = "0x1211658", VA = "0x1211658", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1211664", Offset = "0x1211664", VA = "0x1211664", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x121166C", Offset = "0x121166C", VA = "0x121166C", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x121171C", Offset = "0x121171C", VA = "0x121171C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x1211870", Offset = "0x1211870", VA = "0x1211870")]
	public GUIControllerNPCDialogue()
	{
	}
}
