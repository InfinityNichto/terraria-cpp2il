using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x200070C")]
public class MartianSaucerBigProgressBar : IBigProgressBar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007128")]
	private BigProgressBarCache _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007129")]
	private NPC _referenceDummy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400712A")]
	private HashSet<int> ValidIds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400712B")]
	private HashSet<int> ValidIdsToScanHp;

	[Cpp2IlInjected.Token(Token = "0x6004602")]
	[Cpp2IlInjected.Address(RVA = "0x117F83C", Offset = "0x117F83C", VA = "0x117F83C")]
	public MartianSaucerBigProgressBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004603")]
	[Cpp2IlInjected.Address(RVA = "0x1180D70", Offset = "0x1180D70", VA = "0x1180D70", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004604")]
	[Cpp2IlInjected.Address(RVA = "0x1181170", Offset = "0x1181170", VA = "0x1181170", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004605")]
	[Cpp2IlInjected.Address(RVA = "0x1181090", Offset = "0x1181090", VA = "0x1181090")]
	private bool TryFindingAnotherMartianSaucerPiece(ref BigProgressBarInfo info)
	{
		return default(bool);
	}
}
