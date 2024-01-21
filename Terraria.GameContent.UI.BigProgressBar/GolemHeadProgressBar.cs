using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x2000701")]
public class GolemHeadProgressBar : IBigProgressBar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007117")]
	private BigProgressBarCache _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007118")]
	private NPC _referenceDummy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4007119")]
	private HashSet<int> ValidIds;

	[Cpp2IlInjected.Token(Token = "0x60045D7")]
	[Cpp2IlInjected.Address(RVA = "0x117F598", Offset = "0x117F598", VA = "0x117F598")]
	public GolemHeadProgressBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045D8")]
	[Cpp2IlInjected.Address(RVA = "0x1180534", Offset = "0x1180534", VA = "0x1180534", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045D9")]
	[Cpp2IlInjected.Address(RVA = "0x1180830", Offset = "0x1180830", VA = "0x1180830", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045DA")]
	[Cpp2IlInjected.Address(RVA = "0x1180750", Offset = "0x1180750", VA = "0x1180750")]
	private bool TryFindingAnotherGolemPiece(ref BigProgressBarInfo info)
	{
		return default(bool);
	}
}
