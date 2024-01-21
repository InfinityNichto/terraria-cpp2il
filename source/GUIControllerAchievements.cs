using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200005C")]
public class GUIControllerAchievements : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x2000784")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x40078E5")]
		FilterSlayer,
		[Cpp2IlInjected.Token(Token = "0x40078E6")]
		FilterCollector,
		[Cpp2IlInjected.Token(Token = "0x40078E7")]
		FilterExplorer,
		[Cpp2IlInjected.Token(Token = "0x40078E8")]
		FilterChallenger,
		[Cpp2IlInjected.Token(Token = "0x40078E9")]
		Element,
		[Cpp2IlInjected.Token(Token = "0x40078EA")]
		Back
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public Controls selectedControl;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xF8CF14", Offset = "0xF8CF14", VA = "0xF8CF14", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0xF8CF90", Offset = "0xF8CF90", VA = "0xF8CF90", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0xF8CF98", Offset = "0xF8CF98", VA = "0xF8CF98")]
	private void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0xF8D140", Offset = "0xF8D140", VA = "0xF8D140", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xF8D328", Offset = "0xF8D328", VA = "0xF8D328", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xF8D5C8", Offset = "0xF8D5C8", VA = "0xF8D5C8")]
	public GUIControllerAchievements()
	{
	}
}
