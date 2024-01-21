using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x20006FF")]
public class EaterOfWorldsProgressBar : IBigProgressBar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007113")]
	private BigProgressBarCache _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007114")]
	private NPC _segmentForReference;

	[Cpp2IlInjected.Token(Token = "0x60045D0")]
	[Cpp2IlInjected.Address(RVA = "0x117F4B0", Offset = "0x117F4B0", VA = "0x117F4B0")]
	public EaterOfWorldsProgressBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045D1")]
	[Cpp2IlInjected.Address(RVA = "0x1180124", Offset = "0x1180124", VA = "0x1180124", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045D2")]
	[Cpp2IlInjected.Address(RVA = "0x11803C4", Offset = "0x11803C4", VA = "0x11803C4", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045D3")]
	[Cpp2IlInjected.Address(RVA = "0x11802FC", Offset = "0x11802FC", VA = "0x11802FC")]
	private bool TryFindingAnotherEOWPiece(ref BigProgressBarInfo info)
	{
		return default(bool);
	}
}
