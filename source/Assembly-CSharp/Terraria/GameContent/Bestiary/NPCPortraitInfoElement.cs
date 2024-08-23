﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000644 RID: 1604
	[global::Cpp2ILInjected.Token(Token = "0x2000969")]
	public class NPCPortraitInfoElement : IBestiaryInfoElement
	{
		// Token: 0x06003F09 RID: 16137 RVA: 0x0002D40A File Offset: 0x0002B60A
		[global::Cpp2ILInjected.Token(Token = "0x6004821")]
		[global::Cpp2ILInjected.Address(RVA = "0x8199E8", Offset = "0x8199E8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NPCPortraitInfoElement(int? rarityStars = null)
		{
			throw null;
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x0002D40D File Offset: 0x0002B60D
		[global::Cpp2ILInjected.Token(Token = "0x6004822")]
		[global::Cpp2ILInjected.Address(RVA = "0x81EAE0", Offset = "0x81EAE0", Length = "0xC48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "OrderBy", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(float)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, float>)
		}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryNPCEntryPortrait), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(Asset<Texture2D>),
			typeof(Color),
			typeof(List<IBestiaryBackgroundOverlayAndColorProvider>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCPortraitInfoElement), Member = "CreateStarsContainer", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 72)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x0002D410 File Offset: 0x0002B610
		[global::Cpp2ILInjected.Token(Token = "0x6004823")]
		[global::Cpp2ILInjected.Address(RVA = "0x81FBB0", Offset = "0x81FBB0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int GetStarCount()
		{
			throw null;
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x0002D413 File Offset: 0x0002B613
		[global::Cpp2ILInjected.Token(Token = "0x6004824")]
		[global::Cpp2ILInjected.Address(RVA = "0x81FC1C", Offset = "0x81FC1C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private float GetSortingValueForElement(IBestiaryInfoElement element)
		{
			throw null;
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x0002D416 File Offset: 0x0002B616
		[global::Cpp2ILInjected.Token(Token = "0x6004825")]
		[global::Cpp2ILInjected.Address(RVA = "0x81F730", Offset = "0x81F730", Length = "0x480")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCPortraitInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImage), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private UIElement CreateStarsContainer()
		{
			throw null;
		}

		// Token: 0x04006C8A RID: 27786
		[global::Cpp2ILInjected.Token(Token = "0x40083AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int? _filledStarsCount;

		// Token: 0x02000A25 RID: 2597
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200096A")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06004FD5 RID: 20437 RVA: 0x00030191 File Offset: 0x0002E391
			[global::Cpp2ILInjected.Token(Token = "0x6004826")]
			[global::Cpp2ILInjected.Address(RVA = "0x81F728", Offset = "0x81F728", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass2_0()
			{
				throw null;
			}

			// Token: 0x06004FD6 RID: 20438 RVA: 0x00030194 File Offset: 0x0002E394
			[global::Cpp2ILInjected.Token(Token = "0x6004827")]
			[global::Cpp2ILInjected.Address(RVA = "0x81FCD8", Offset = "0x81FCD8", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal bool <ProvideUIElement>b__0(IBestiaryBackgroundImagePathAndColorProvider provider)
			{
				throw null;
			}

			// Token: 0x04008D86 RID: 36230
			[global::Cpp2ILInjected.Token(Token = "0x40083AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public IEnumerable<IPreferenceProviderElement> preferences;
		}

		// Token: 0x02000A26 RID: 2598
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200096B")]
		private sealed class <>c__DisplayClass2_1
		{
			// Token: 0x06004FD7 RID: 20439 RVA: 0x00030197 File Offset: 0x0002E397
			[global::Cpp2ILInjected.Token(Token = "0x6004828")]
			[global::Cpp2ILInjected.Address(RVA = "0x81FDAC", Offset = "0x81FDAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass2_1()
			{
				throw null;
			}

			// Token: 0x06004FD8 RID: 20440 RVA: 0x0003019A File Offset: 0x0002E39A
			[global::Cpp2ILInjected.Token(Token = "0x6004829")]
			[global::Cpp2ILInjected.Address(RVA = "0x81FDB4", Offset = "0x81FDB4", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <ProvideUIElement>b__2(IPreferenceProviderElement preference)
			{
				throw null;
			}

			// Token: 0x04008D87 RID: 36231
			[global::Cpp2ILInjected.Token(Token = "0x40083AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public IBestiaryBackgroundImagePathAndColorProvider provider;
		}

		// Token: 0x02000A27 RID: 2599
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200096C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004FD9 RID: 20441 RVA: 0x0003019D File Offset: 0x0002E39D
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600482A")]
			[global::Cpp2ILInjected.Address(RVA = "0x81FE60", Offset = "0x81FE60", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004FDA RID: 20442 RVA: 0x000301A0 File Offset: 0x0002E3A0
			[global::Cpp2ILInjected.Token(Token = "0x600482B")]
			[global::Cpp2ILInjected.Address(RVA = "0x81FEBC", Offset = "0x81FEBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004FDB RID: 20443 RVA: 0x000301A3 File Offset: 0x0002E3A3
			[global::Cpp2ILInjected.Token(Token = "0x600482C")]
			[global::Cpp2ILInjected.Address(RVA = "0x81FEC4", Offset = "0x81FEC4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal IBestiaryBackgroundOverlayAndColorProvider <ProvideUIElement>b__2_1(IBestiaryInfoElement x)
			{
				throw null;
			}

			// Token: 0x04008D88 RID: 36232
			[global::Cpp2ILInjected.Token(Token = "0x40083B0")]
			public static readonly NPCPortraitInfoElement.<>c <>9;

			// Token: 0x04008D89 RID: 36233
			[global::Cpp2ILInjected.Token(Token = "0x40083B1")]
			public static Func<IBestiaryInfoElement, IBestiaryBackgroundOverlayAndColorProvider> <>9__2_1;
		}
	}
}