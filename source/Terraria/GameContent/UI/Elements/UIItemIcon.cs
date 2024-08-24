using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006D9 RID: 1753
	[global::Cpp2ILInjected.Token(Token = "0x2000ABD")]
	public class UIItemIcon : UIElement
	{
		// Token: 0x060044A4 RID: 17572 RVA: 0x0002E487 File Offset: 0x0002C687
		[global::Cpp2ILInjected.Token(Token = "0x60050F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A450", Offset = "0x92A450", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKillCounterInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoItemLine), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DropRateInfo),
			typeof(BestiaryUICollectionInfo),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UIItemIcon(Item item, bool blackedOut)
		{
			throw null;
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x0002E48A File Offset: 0x0002C68A
		[global::Cpp2ILInjected.Token(Token = "0x60050F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A4FC", Offset = "0x92A4FC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DrawItemIcon", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x04007069 RID: 28777
		[global::Cpp2ILInjected.Token(Token = "0x40089B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Item _item;

		// Token: 0x0400706A RID: 28778
		[global::Cpp2ILInjected.Token(Token = "0x40089B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private bool _blackedOut;
	}
}
