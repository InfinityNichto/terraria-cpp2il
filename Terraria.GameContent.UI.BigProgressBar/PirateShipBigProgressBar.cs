using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x200070B")]
public class PirateShipBigProgressBar : IBigProgressBar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007125")]
	private BigProgressBarCache _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007126")]
	private NPC _referenceDummy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4007127")]
	private HashSet<int> ValidIds;

	[Cpp2IlInjected.Token(Token = "0x60045FE")]
	[Cpp2IlInjected.Address(RVA = "0x117F778", Offset = "0x117F778", VA = "0x117F778")]
	public PirateShipBigProgressBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045FF")]
	[Cpp2IlInjected.Address(RVA = "0x1181B14", Offset = "0x1181B14", VA = "0x1181B14", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004600")]
	[Cpp2IlInjected.Address(RVA = "0x1181E90", Offset = "0x1181E90", VA = "0x1181E90", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004601")]
	[Cpp2IlInjected.Address(RVA = "0x1181DB0", Offset = "0x1181DB0", VA = "0x1181DB0")]
	private bool TryFindingAnotherPirateShipPiece(ref BigProgressBarInfo info)
	{
		return default(bool);
	}
}
