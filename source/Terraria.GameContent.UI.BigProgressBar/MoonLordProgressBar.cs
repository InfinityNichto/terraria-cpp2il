using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x2000702")]
public class MoonLordProgressBar : IBigProgressBar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400711A")]
	private BigProgressBarCache _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400711B")]
	private NPC _referenceDummy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400711C")]
	private HashSet<int> ValidIds;

	[Cpp2IlInjected.Token(Token = "0x60045DB")]
	[Cpp2IlInjected.Address(RVA = "0x117F66C", Offset = "0x117F66C", VA = "0x117F66C")]
	public MoonLordProgressBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045DC")]
	[Cpp2IlInjected.Address(RVA = "0x11812E0", Offset = "0x11812E0", VA = "0x11812E0", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045DD")]
	[Cpp2IlInjected.Address(RVA = "0x118163C", Offset = "0x118163C", VA = "0x118163C")]
	private bool IsInBadAI(NPC npc)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045DE")]
	[Cpp2IlInjected.Address(RVA = "0x118181C", Offset = "0x118181C", VA = "0x118181C", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045DF")]
	[Cpp2IlInjected.Address(RVA = "0x11816B4", Offset = "0x11816B4", VA = "0x11816B4")]
	private bool TryFindingAnotherMoonLordPiece(ref BigProgressBarInfo info)
	{
		return default(bool);
	}
}
