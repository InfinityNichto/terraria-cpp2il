using Cpp2IlInjected;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x2000102")]
public class GUISettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40007AE")]
	public bool Visible;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40007AF")]
	public bool KeySwitch;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40007B0")]
	public bool KeyRelease;

	[Cpp2IlInjected.Token(Token = "0x40007B1")]
	public static Texture2D _settingsTexture;

	[Cpp2IlInjected.Token(Token = "0x40007B2")]
	private static Texture2D _settingsSelectedTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40007B3")]
	private float settingsButtonScale;

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0xEE3C0C", Offset = "0xEE3C0C", VA = "0xEE3C0C")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0xEE3CB8", Offset = "0xEE3CB8", VA = "0xEE3CB8")]
	public void ShutdownUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0xEE3E84", Offset = "0xEE3E84", VA = "0xEE3E84")]
	public bool Draw()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0xEE68A4", Offset = "0xEE68A4", VA = "0xEE68A4")]
	public GUISettings()
	{
	}
}
