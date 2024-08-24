using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006BC RID: 1724
	[global::Cpp2ILInjected.Token(Token = "0x2000A9A")]
	public class UIBestiarySortingOptionsGrid : UIPanel
	{
		// Token: 0x14000057 RID: 87
		// (add) Token: 0x060043D0 RID: 17360 RVA: 0x0002E217 File Offset: 0x0002C417
		// (remove) Token: 0x060043D1 RID: 17361 RVA: 0x0002E21A File Offset: 0x0002C41A
		[global::Cpp2ILInjected.Token(Token = "0x1400005D")]
		public event Action OnClickingOption
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005015")]
			[global::Cpp2ILInjected.Address(RVA = "0x908038", Offset = "0x908038", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005016")]
			[global::Cpp2ILInjected.Address(RVA = "0x9080D8", Offset = "0x9080D8", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x0002E21D File Offset: 0x0002C41D
		[global::Cpp2ILInjected.Token(Token = "0x6005017")]
		[global::Cpp2ILInjected.Address(RVA = "0x908178", Offset = "0x908178", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiarySortingOptionsGrid), Member = "BuildGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public UIBestiarySortingOptionsGrid(EntrySorter<BestiaryEntry, IBestiarySortStep> sorter)
		{
			throw null;
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x0002E220 File Offset: 0x0002C420
		[global::Cpp2ILInjected.Token(Token = "0x6005018")]
		[global::Cpp2ILInjected.Address(RVA = "0x908308", Offset = "0x908308", Length = "0x700")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiarySortingOptionsGrid), Member = ".ctor", MemberParameters = new object[] { typeof(EntrySorter<BestiaryEntry, IBestiarySortStep>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(Color),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private void BuildGrid()
		{
			throw null;
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x0002E223 File Offset: 0x0002C423
		[global::Cpp2ILInjected.Token(Token = "0x6005019")]
		[global::Cpp2ILInjected.Address(RVA = "0x908A08", Offset = "0x908A08", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<int>), Member = "SetColor", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void ClickOption(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x0002E226 File Offset: 0x0002C426
		[global::Cpp2ILInjected.Token(Token = "0x600501A")]
		[global::Cpp2ILInjected.Address(RVA = "0x908CA0", Offset = "0x908CA0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
		{
			throw null;
		}

		// Token: 0x04006FBF RID: 28607
		[global::Cpp2ILInjected.Token(Token = "0x40088EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

		// Token: 0x04006FC0 RID: 28608
		[global::Cpp2ILInjected.Token(Token = "0x40088F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private List<GroupOptionButton<int>> _buttonsBySorting;

		// Token: 0x04006FC1 RID: 28609
		[global::Cpp2ILInjected.Token(Token = "0x40088F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private int _currentSelected;

		// Token: 0x04006FC2 RID: 28610
		[global::Cpp2ILInjected.Token(Token = "0x40088F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x17C")]
		private int _defaultStepIndex;

		// Token: 0x04006FC3 RID: 28611
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40088F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private Action OnClickingOption;
	}
}
