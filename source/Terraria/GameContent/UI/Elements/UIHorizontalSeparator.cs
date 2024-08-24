using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006D3 RID: 1747
	[global::Cpp2ILInjected.Token(Token = "0x2000AB7")]
	public class UIHorizontalSeparator : UIElement
	{
		// Token: 0x06004486 RID: 17542 RVA: 0x0002E433 File Offset: 0x0002C633
		[global::Cpp2ILInjected.Token(Token = "0x60050D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x928E48", Offset = "0x928E48", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCStatsReportInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmotesGroupListItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = "AddInfoToList", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(ExtraBestiaryInfoPageInformation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public UIHorizontalSeparator(int EdgeWidth = 2, bool highlightSideUp = true)
		{
			throw null;
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x0002E436 File Offset: 0x0002C636
		[global::Cpp2ILInjected.Token(Token = "0x60050D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x929088", Offset = "0x929088", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawPanel", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x0002E439 File Offset: 0x0002C639
		[global::Cpp2ILInjected.Token(Token = "0x60050DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x929160", Offset = "0x929160", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool ContainsPoint(Vector2 point)
		{
			throw null;
		}

		// Token: 0x0400704D RID: 28749
		[global::Cpp2ILInjected.Token(Token = "0x4008994")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400704E RID: 28750
		[global::Cpp2ILInjected.Token(Token = "0x4008995")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public Color Color;

		// Token: 0x0400704F RID: 28751
		[global::Cpp2ILInjected.Token(Token = "0x4008996")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		public int EdgeWidth;
	}
}
