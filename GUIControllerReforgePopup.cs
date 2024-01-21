using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200009F")]
public class GUIControllerReforgePopup : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x2000793")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x400795D")]
		Reforge,
		[Cpp2IlInjected.Token(Token = "0x400795E")]
		Back
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public Controls selectedControl;

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x1219484", Offset = "0x1219484", VA = "0x1219484", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x121948C", Offset = "0x121948C", VA = "0x121948C", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x1219498", Offset = "0x1219498", VA = "0x1219498", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x12194C0", Offset = "0x12194C0", VA = "0x12194C0", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x121960C", Offset = "0x121960C", VA = "0x121960C")]
	public GUIControllerReforgePopup()
	{
	}
}
