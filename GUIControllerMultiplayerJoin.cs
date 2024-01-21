using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GUIControllerMultiplayerJoin : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private bool serverIPActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private bool serverPortActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public int selectionIndex;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1210B98", Offset = "0x1210B98", VA = "0x1210B98", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1210BA4", Offset = "0x1210BA4", VA = "0x1210BA4", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1210BAC", Offset = "0x1210BAC", VA = "0x1210BAC", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1210C38", Offset = "0x1210C38", VA = "0x1210C38")]
	public void ActivateServerIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1210C44", Offset = "0x1210C44", VA = "0x1210C44")]
	public void DeactivateServerIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1210C50", Offset = "0x1210C50", VA = "0x1210C50")]
	public void ActivateServerPort()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1210C5C", Offset = "0x1210C5C", VA = "0x1210C5C")]
	public void DeactivateServerPort()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x1210C68", Offset = "0x1210C68", VA = "0x1210C68", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1210DDC", Offset = "0x1210DDC", VA = "0x1210DDC")]
	public GUIControllerMultiplayerJoin()
	{
	}
}
