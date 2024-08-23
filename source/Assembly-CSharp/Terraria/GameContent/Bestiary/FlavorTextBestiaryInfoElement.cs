using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200063F RID: 1599
	[global::Cpp2ILInjected.Token(Token = "0x2000962")]
	public class FlavorTextBestiaryInfoElement : IBestiaryInfoElement
	{
		// Token: 0x06003EF9 RID: 16121 RVA: 0x0002D3DD File Offset: 0x0002B5DD
		[global::Cpp2ILInjected.Token(Token = "0x600480D")]
		[global::Cpp2ILInjected.Address(RVA = "0x819C24", Offset = "0x819C24", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "TryGivingEntryFlavorTextIfItIsMissing", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FlavorTextBestiaryInfoElement(string languageKey)
		{
			throw null;
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0002D3E0 File Offset: 0x0002B5E0
		[global::Cpp2ILInjected.Token(Token = "0x600480E")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DED4", Offset = "0x81DED4", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixelsAndPercent", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "set_IsWrapped", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlavorTextBestiaryInfoElement), Member = "AddDynamicResize", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIText)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x0002D3E3 File Offset: 0x0002B5E3
		[global::Cpp2ILInjected.Token(Token = "0x600480F")]
		[global::Cpp2ILInjected.Address(RVA = "0x81E1E4", Offset = "0x81E1E4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlavorTextBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "add_OnInternalTextChange", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void AddDynamicResize(UIElement container, UIText text)
		{
			throw null;
		}

		// Token: 0x04006C83 RID: 27779
		[global::Cpp2ILInjected.Token(Token = "0x40083A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string _key;

		// Token: 0x02000A23 RID: 2595
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000963")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004FD1 RID: 20433 RVA: 0x00030185 File Offset: 0x0002E385
			[global::Cpp2ILInjected.Token(Token = "0x6004810")]
			[global::Cpp2ILInjected.Address(RVA = "0x81E2A0", Offset = "0x81E2A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass3_0()
			{
				throw null;
			}

			// Token: 0x06004FD2 RID: 20434 RVA: 0x00030188 File Offset: 0x0002E388
			[global::Cpp2ILInjected.Token(Token = "0x6004811")]
			[global::Cpp2ILInjected.Address(RVA = "0x81E2A8", Offset = "0x81E2A8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			internal void <AddDynamicResize>b__0()
			{
				throw null;
			}

			// Token: 0x04008D82 RID: 36226
			[global::Cpp2ILInjected.Token(Token = "0x40083A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public UIElement container;

			// Token: 0x04008D83 RID: 36227
			[global::Cpp2ILInjected.Token(Token = "0x40083A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public UIText text;
		}
	}
}
