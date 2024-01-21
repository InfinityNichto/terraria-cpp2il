using Cpp2IlInjected;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004C3")]
public class GameInterfaceLayer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006690")]
	public readonly string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006691")]
	public InterfaceScaleType ScaleType;

	[Cpp2IlInjected.Token(Token = "0x60035CA")]
	[Cpp2IlInjected.Address(RVA = "0x13A4604", Offset = "0x13A4604", VA = "0x13A4604")]
	public GameInterfaceLayer(string name, InterfaceScaleType scaleType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035CB")]
	[Cpp2IlInjected.Address(RVA = "0x13A462C", Offset = "0x13A462C", VA = "0x13A462C")]
	public bool Draw()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60035CC")]
	[Cpp2IlInjected.Address(RVA = "0x13A4B80", Offset = "0x13A4B80", VA = "0x13A4B80", Slot = "4")]
	protected virtual bool DrawSelf()
	{
		return default(bool);
	}
}
