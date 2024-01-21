using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x20006FD")]
public class CommonBossBigProgressBar : IBigProgressBar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400710F")]
	private BigProgressBarCache _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007110")]
	private int _headIndex;

	[Cpp2IlInjected.Token(Token = "0x60045CA")]
	[Cpp2IlInjected.Address(RVA = "0x117FCA8", Offset = "0x117FCA8", VA = "0x117FCA8", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045CB")]
	[Cpp2IlInjected.Address(RVA = "0x117FD8C", Offset = "0x117FD8C", VA = "0x117FD8C", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045CC")]
	[Cpp2IlInjected.Address(RVA = "0x117F224", Offset = "0x117F224", VA = "0x117F224")]
	public CommonBossBigProgressBar()
	{
	}
}
