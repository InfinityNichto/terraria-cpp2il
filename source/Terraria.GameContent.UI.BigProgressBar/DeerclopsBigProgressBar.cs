using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x20006FE")]
public class DeerclopsBigProgressBar : IBigProgressBar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007111")]
	private BigProgressBarCache _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007112")]
	private int _headIndex;

	[Cpp2IlInjected.Token(Token = "0x60045CD")]
	[Cpp2IlInjected.Address(RVA = "0x117FEC4", Offset = "0x117FEC4", VA = "0x117FEC4", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045CE")]
	[Cpp2IlInjected.Address(RVA = "0x117FFEC", Offset = "0x117FFEC", VA = "0x117FFEC", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045CF")]
	[Cpp2IlInjected.Address(RVA = "0x117F944", Offset = "0x117F944", VA = "0x117F944")]
	public DeerclopsBigProgressBar()
	{
	}
}
