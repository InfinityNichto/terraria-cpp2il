using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200006A")]
public class GUIControllerMultiplayerHost : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private bool serverPasswordActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public int selectionIndex;

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x1210930", Offset = "0x1210930", VA = "0x1210930", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x121093C", Offset = "0x121093C", VA = "0x121093C", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1210944", Offset = "0x1210944", VA = "0x1210944", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x12109D0", Offset = "0x12109D0", VA = "0x12109D0")]
	public void ActivateServerPassword()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x12109DC", Offset = "0x12109DC", VA = "0x12109DC")]
	public void DeactivateServerPassword()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x12109E8", Offset = "0x12109E8", VA = "0x12109E8", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1210B90", Offset = "0x1210B90", VA = "0x1210B90")]
	public GUIControllerMultiplayerHost()
	{
	}
}
