using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class GUIPlayerCreateController : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private GUIControllerItem _activeItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public readonly GUIPlayerCreateController_MainButtons Buttons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly GUIPlayerCreateController_Tabs Tabs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly GUIPlayerCreateController_Info InfoPage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly GUIPlayerCreateController_Gender GenderPage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public readonly GUIPlayerCreateController_HairStyle HairStlyePage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public readonly GUIPlayerCreateController_ItemColour HairColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public readonly GUIPlayerCreateController_ItemColour EyeColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public readonly GUIPlayerCreateController_ItemColour SkinColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public readonly GUIPlayerCreateController_ItemColour ShirtColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public readonly GUIPlayerCreateController_ItemColour UndershirtColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public readonly GUIPlayerCreateController_ItemColour PantsColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public readonly GUIPlayerCreateController_ItemColour ShoesColour;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public GUIControllerItem CurrentItem
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x1141814", Offset = "0x1141814", VA = "0x1141814")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x1141170", Offset = "0x1141170", VA = "0x1141170")]
	public GUIPlayerCreateController()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x1141430", Offset = "0x1141430", VA = "0x1141430", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x114164C", Offset = "0x114164C", VA = "0x114164C")]
	public void ActivateRandomise()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x1141664", Offset = "0x1141664", VA = "0x1141664", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x114166C", Offset = "0x114166C", VA = "0x114166C", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x114174C", Offset = "0x114174C", VA = "0x114174C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
