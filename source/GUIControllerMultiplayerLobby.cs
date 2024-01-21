using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200006C")]
public class GUIControllerMultiplayerLobby : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x2000788")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x40078FF")]
		Local,
		[Cpp2IlInjected.Token(Token = "0x4007900")]
		Dedicated,
		[Cpp2IlInjected.Token(Token = "0x4007901")]
		Delete,
		[Cpp2IlInjected.Token(Token = "0x4007902")]
		Favourite,
		[Cpp2IlInjected.Token(Token = "0x4007903")]
		Play,
		[Cpp2IlInjected.Token(Token = "0x4007904")]
		Back,
		[Cpp2IlInjected.Token(Token = "0x4007905")]
		New
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public int selectedControl;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1210DE4", Offset = "0x1210DE4", VA = "0x1210DE4", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1210E88", Offset = "0x1210E88", VA = "0x1210E88", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x1210E90", Offset = "0x1210E90", VA = "0x1210E90")]
	private void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1211124", Offset = "0x1211124", VA = "0x1211124", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x12113F4", Offset = "0x12113F4", VA = "0x12113F4", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1211650", Offset = "0x1211650", VA = "0x1211650")]
	public GUIControllerMultiplayerLobby()
	{
	}
}
