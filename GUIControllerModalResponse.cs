using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000069")]
public class GUIControllerModalResponse : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x2000787")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x40078FC")]
		Cancel,
		[Cpp2IlInjected.Token(Token = "0x40078FD")]
		Confirm
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public Controls selectedControl;

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x12107C4", Offset = "0x12107C4", VA = "0x12107C4", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x12107D0", Offset = "0x12107D0", VA = "0x12107D0", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x12107F8", Offset = "0x12107F8", VA = "0x12107F8", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x1210920", Offset = "0x1210920", VA = "0x1210920", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1210928", Offset = "0x1210928", VA = "0x1210928")]
	public GUIControllerModalResponse()
	{
	}
}
