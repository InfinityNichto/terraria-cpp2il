using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000079")]
public class GUIWorldCreateController : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public int selectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private bool nameActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private bool seedActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private bool worldActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private int worldIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private bool difficultyActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private int difficultyIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private int difficultyWrapAround;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private bool evilTypeActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private int evilTypeIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private int evilTypeWrapAround;

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x12B1FA8", Offset = "0x12B1FA8", VA = "0x12B1FA8", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x12B1FB4", Offset = "0x12B1FB4", VA = "0x12B1FB4", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x12B1FBC", Offset = "0x12B1FBC", VA = "0x12B1FBC", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x12B21D0", Offset = "0x12B21D0", VA = "0x12B21D0")]
	public void ActivateName()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x12B21DC", Offset = "0x12B21DC", VA = "0x12B21DC")]
	public void DeactivateName()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x12B21E8", Offset = "0x12B21E8", VA = "0x12B21E8")]
	public void ActivateSeed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x12B21F4", Offset = "0x12B21F4", VA = "0x12B21F4")]
	public void DeactivateSeed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x12B2200", Offset = "0x12B2200", VA = "0x12B2200")]
	public void ActivateDifficultyOptions(int selectedOption, int wrapAround)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x12B2218", Offset = "0x12B2218", VA = "0x12B2218")]
	public void DeactivateDifficultyOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x12B2224", Offset = "0x12B2224", VA = "0x12B2224")]
	public void ActivateWorldOptions(int selectedOption)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x12B2234", Offset = "0x12B2234", VA = "0x12B2234")]
	public void DeactivateWorldOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x12B2240", Offset = "0x12B2240", VA = "0x12B2240")]
	public void ActivateEvilTypeOptions(int selectedOption, int wrapAround)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x12B2258", Offset = "0x12B2258", VA = "0x12B2258")]
	public void DeactivateEvilTypeOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x12B2264", Offset = "0x12B2264", VA = "0x12B2264", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x12B28A0", Offset = "0x12B28A0", VA = "0x12B28A0")]
	public GUIWorldCreateController()
	{
	}
}
