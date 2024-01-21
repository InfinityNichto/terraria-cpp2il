using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GUIControllerCraftingMaterials : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private int selectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public DateTime LastActivated;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public float UITextAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1294284", Offset = "0x1294284", VA = "0x1294284")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x12940E4", Offset = "0x12940E4", VA = "0x12940E4", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1294178", Offset = "0x1294178", VA = "0x1294178")]
	private void Clamp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x129427C", Offset = "0x129427C", VA = "0x129427C", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x12943A0", Offset = "0x12943A0", VA = "0x12943A0")]
	public void NavigateNext()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1294498", Offset = "0x1294498", VA = "0x1294498")]
	public void NavigatePrevious()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1294574", Offset = "0x1294574", VA = "0x1294574")]
	public void Tick()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1294600", Offset = "0x1294600", VA = "0x1294600", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x12946B8", Offset = "0x12946B8", VA = "0x12946B8")]
	public int GetSelectedItem()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x12946C0", Offset = "0x12946C0", VA = "0x12946C0", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x129494C", Offset = "0x129494C", VA = "0x129494C")]
	public GUIControllerCraftingMaterials()
	{
	}
}
