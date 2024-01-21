using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class GUIControllerTrash : GUIPageContentController
{
	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x1217FB4", Offset = "0x1217FB4", VA = "0x1217FB4")]
	public GUIControllerTrash()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x121E590", Offset = "0x121E590", VA = "0x121E590", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x121E594", Offset = "0x121E594", VA = "0x121E594", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x121E64C", Offset = "0x121E64C", VA = "0x121E64C", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
