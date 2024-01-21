using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200008B")]
public class GUIControllerDresser : GUIPageContentController
{
	[Cpp2IlInjected.Token(Token = "0x2000791")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x400794C")]
		Style,
		[Cpp2IlInjected.Token(Token = "0x400794D")]
		Skin,
		[Cpp2IlInjected.Token(Token = "0x400794E")]
		Eyes,
		[Cpp2IlInjected.Token(Token = "0x400794F")]
		Shirt,
		[Cpp2IlInjected.Token(Token = "0x4007950")]
		Undershirt,
		[Cpp2IlInjected.Token(Token = "0x4007951")]
		Pants,
		[Cpp2IlInjected.Token(Token = "0x4007952")]
		Shoes,
		[Cpp2IlInjected.Token(Token = "0x4007953")]
		Element,
		[Cpp2IlInjected.Token(Token = "0x4007954")]
		Back,
		[Cpp2IlInjected.Token(Token = "0x4007955")]
		Change
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public Controls selectedControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public int Item;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x1295B3C", Offset = "0x1295B3C", VA = "0x1295B3C")]
	public GUIControllerDresser()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x1295B50", Offset = "0x1295B50", VA = "0x1295B50", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x1295C00", Offset = "0x1295C00", VA = "0x1295C00", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1295EC4", Offset = "0x1295EC4", VA = "0x1295EC4", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
