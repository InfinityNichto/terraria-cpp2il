using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x2000705")]
public class TwinsBigProgressBar : IBigProgressBar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007121")]
	private BigProgressBarCache _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007122")]
	private int _headIndex;

	[Cpp2IlInjected.Token(Token = "0x60045E5")]
	[Cpp2IlInjected.Address(RVA = "0x11822F8", Offset = "0x11822F8", VA = "0x11822F8", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045E6")]
	[Cpp2IlInjected.Address(RVA = "0x1182474", Offset = "0x1182474", VA = "0x1182474", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045E7")]
	[Cpp2IlInjected.Address(RVA = "0x117F4A8", Offset = "0x117F4A8", VA = "0x117F4A8")]
	public TwinsBigProgressBar()
	{
	}
}
