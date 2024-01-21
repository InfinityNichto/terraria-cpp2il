using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006C8")]
public class UIBestiaryNPCEntryPortrait : UIElement
{
	[Cpp2IlInjected.Token(Token = "0x170007C4")]
	public BestiaryEntry Entry
	{
		[Cpp2IlInjected.Token(Token = "0x6004452")]
		[Cpp2IlInjected.Address(RVA = "0x14829DC", Offset = "0x14829DC", VA = "0x14829DC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004453")]
		[Cpp2IlInjected.Address(RVA = "0x14829E4", Offset = "0x14829E4", VA = "0x14829E4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004454")]
	[Cpp2IlInjected.Address(RVA = "0x14829EC", Offset = "0x14829EC", VA = "0x14829EC")]
	public UIBestiaryNPCEntryPortrait(BestiaryEntry entry, Asset<Texture2D> portraitBackgroundAsset, Color portraitColor, List<IBestiaryBackgroundOverlayAndColorProvider> overlays)
	{
	}
}
