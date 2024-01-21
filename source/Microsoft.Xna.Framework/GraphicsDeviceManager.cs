using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000279")]
public class GraphicsDeviceManager
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001CE5")]
	private Game game;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001CE6")]
	public bool SynchronizeWithVerticalRetrace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001CE7")]
	public int PreferredBackBufferWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001CE8")]
	public int PreferredBackBufferHeight;

	[Cpp2IlInjected.Token(Token = "0x4001CE9")]
	public static int DefaultBackBufferWidth;

	[Cpp2IlInjected.Token(Token = "0x4001CEA")]
	public static int DefaultBackBufferHeight;

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	public GraphicsDevice GraphicsDevice
	{
		[Cpp2IlInjected.Token(Token = "0x6001395")]
		[Cpp2IlInjected.Address(RVA = "0x154FA48", Offset = "0x154FA48", VA = "0x154FA48")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	public bool IsFullScreen
	{
		[Cpp2IlInjected.Token(Token = "0x6001397")]
		[Cpp2IlInjected.Address(RVA = "0x154FA74", Offset = "0x154FA74", VA = "0x154FA74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001396")]
	[Cpp2IlInjected.Address(RVA = "0x154FA54", Offset = "0x154FA54", VA = "0x154FA54")]
	public GraphicsDeviceManager(Game game)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001398")]
	[Cpp2IlInjected.Address(RVA = "0x154FA7C", Offset = "0x154FA7C", VA = "0x154FA7C")]
	public void ApplyChanges()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001399")]
	[Cpp2IlInjected.Address(RVA = "0x154FA80", Offset = "0x154FA80", VA = "0x154FA80")]
	public void ToggleFullScreen()
	{
	}
}
