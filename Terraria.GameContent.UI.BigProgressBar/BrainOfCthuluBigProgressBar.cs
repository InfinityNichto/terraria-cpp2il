using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x2000700")]
public class BrainOfCthuluBigProgressBar : IBigProgressBar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007115")]
	private BigProgressBarCache _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007116")]
	private NPC _creeperForReference;

	[Cpp2IlInjected.Token(Token = "0x60045D4")]
	[Cpp2IlInjected.Address(RVA = "0x117F524", Offset = "0x117F524", VA = "0x117F524")]
	public BrainOfCthuluBigProgressBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045D5")]
	[Cpp2IlInjected.Address(RVA = "0x117F94C", Offset = "0x117F94C", VA = "0x117F94C", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045D6")]
	[Cpp2IlInjected.Address(RVA = "0x117FB38", Offset = "0x117FB38", VA = "0x117FB38", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}
}
