using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class GUIPlayerCreateController_Info : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly GUIPlayerCreateController _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public int element;

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x11413A4", Offset = "0x11413A4", VA = "0x11413A4")]
	public GUIPlayerCreateController_Info(GUIPlayerCreateController controller)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x11425C4", Offset = "0x11425C4", VA = "0x11425C4", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x1142684", Offset = "0x1142684", VA = "0x1142684", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x114268C", Offset = "0x114268C", VA = "0x114268C", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x1142678", Offset = "0x1142678", VA = "0x1142678")]
	public void ActivateOptions(int selectedOption)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x1142748", Offset = "0x1142748", VA = "0x1142748")]
	public void DeactivateOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x1142754", Offset = "0x1142754", VA = "0x1142754")]
	public void ActivateName()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x1142760", Offset = "0x1142760", VA = "0x1142760")]
	public void DeactivateName()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x114276C", Offset = "0x114276C", VA = "0x114276C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
