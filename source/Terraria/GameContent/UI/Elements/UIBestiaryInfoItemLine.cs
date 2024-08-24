using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006C2 RID: 1730
	[global::Cpp2ILInjected.Token(Token = "0x2000AA4")]
	public class UIBestiaryInfoItemLine : UIPanel, IManuallyOrderedUIElement
	{
		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x0002E295 File Offset: 0x0002C495
		// (set) Token: 0x060043FB RID: 17403 RVA: 0x0002E298 File Offset: 0x0002C498
		[global::Cpp2ILInjected.Token(Token = "0x170008BC")]
		public int OrderInUIList
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005047")]
			[global::Cpp2ILInjected.Address(RVA = "0x90CBC8", Offset = "0x90CBC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005048")]
			[global::Cpp2ILInjected.Address(RVA = "0x90CBD0", Offset = "0x90CBD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x0002E29B File Offset: 0x0002C49B
		[global::Cpp2ILInjected.Token(Token = "0x6005049")]
		[global::Cpp2ILInjected.Address(RVA = "0x90CBD8", Offset = "0x90CBD8", Length = "0x518")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryInfoItemLine), Member = "SetBestiaryNotesOnItemCache", MemberParameters = new object[] { typeof(DropRateInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryInfoItemLine), Member = "GetDropInfo", MemberParameters = new object[]
		{
			typeof(DropRateInfo),
			typeof(BestiaryUICollectionInfo),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIItemIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImage), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public UIBestiaryInfoItemLine(DropRateInfo info, BestiaryUICollectionInfo uiinfo, float textScale = 1f)
		{
			throw null;
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x0002E29E File Offset: 0x0002C49E
		[global::Cpp2ILInjected.Token(Token = "0x600504A")]
		[global::Cpp2ILInjected.Address(RVA = "0x90D398", Offset = "0x90D398", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DropDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoItemLine), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DropRateInfo),
			typeof(BestiaryUICollectionInfo),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PrettifyPercentDisplay", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void GetDropInfo(DropRateInfo dropRateInfo, BestiaryUICollectionInfo uiinfo, out string stackRange, out string droprate)
		{
			throw null;
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x0002E2A1 File Offset: 0x0002C4A1
		[global::Cpp2ILInjected.Token(Token = "0x600504B")]
		[global::Cpp2ILInjected.Address(RVA = "0x90D5C8", Offset = "0x90D5C8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x0002E2A4 File Offset: 0x0002C4A4
		[global::Cpp2ILInjected.Token(Token = "0x600504C")]
		[global::Cpp2ILInjected.Address(RVA = "0x90D5FC", Offset = "0x90D5FC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void DrawMouseOver()
		{
			throw null;
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x0002E2A7 File Offset: 0x0002C4A7
		[global::Cpp2ILInjected.Token(Token = "0x600504D")]
		[global::Cpp2ILInjected.Address(RVA = "0x90D6B4", Offset = "0x90D6B4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int CompareTo(object obj)
		{
			throw null;
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x0002E2AA File Offset: 0x0002C4AA
		[global::Cpp2ILInjected.Token(Token = "0x600504E")]
		[global::Cpp2ILInjected.Address(RVA = "0x90D0F0", Offset = "0x90D0F0", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoItemLine), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DropRateInfo),
			typeof(BestiaryUICollectionInfo),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IEnumerable<string>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void SetBestiaryNotesOnItemCache(DropRateInfo info)
		{
			throw null;
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x0002E2AD File Offset: 0x0002C4AD
		[global::Cpp2ILInjected.Token(Token = "0x600504F")]
		[global::Cpp2ILInjected.Address(RVA = "0x90D79C", Offset = "0x90D79C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void MouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x0002E2B0 File Offset: 0x0002C4B0
		[global::Cpp2ILInjected.Token(Token = "0x6005050")]
		[global::Cpp2ILInjected.Address(RVA = "0x90D81C", Offset = "0x90D81C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void MouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x04006FD9 RID: 28633
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008919")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private int <OrderInUIList>k__BackingField;

		// Token: 0x04006FDA RID: 28634
		[global::Cpp2ILInjected.Token(Token = "0x400891A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private Item _infoDisplayItem;

		// Token: 0x04006FDB RID: 28635
		[global::Cpp2ILInjected.Token(Token = "0x400891B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private bool _hideMouseOver;
	}
}
