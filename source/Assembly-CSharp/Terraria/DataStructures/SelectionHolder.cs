using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Content;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.IO;

namespace Terraria.DataStructures
{
	// Token: 0x02000471 RID: 1137
	[global::Cpp2ILInjected.Token(Token = "0x200066D")]
	public abstract class SelectionHolder<TCycleType> where TCycleType : class, IConfigKeyHolder
	{
		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x0002AEFC File Offset: 0x000290FC
		// (set) Token: 0x060031F3 RID: 12787 RVA: 0x0002AEFF File Offset: 0x000290FF
		[global::Cpp2ILInjected.Token(Token = "0x170006A6")]
		public string ActiveSelectionKeyName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600370F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1864160", Offset = "0x1864160", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003710")]
			[global::Cpp2ILInjected.Address(RVA = "0x1864168", Offset = "0x1864168", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x0002AF02 File Offset: 0x00029102
		[global::Cpp2ILInjected.Token(Token = "0x6003711")]
		[global::Cpp2ILInjected.Address(RVA = "0x1864170", Offset = "0x1864170", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "add_OnLoad", MemberParameters = new object[] { typeof(Action<Preferences>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "add_OnSave", MemberParameters = new object[] { typeof(Action<Preferences>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void BindTo(Preferences preferences)
		{
			throw null;
		}

		// Token: 0x060031F5 RID: 12789
		[global::Cpp2ILInjected.Token(Token = "0x6003712")]
		protected abstract void Configuration_Save(Preferences obj);

		// Token: 0x060031F6 RID: 12790
		[global::Cpp2ILInjected.Token(Token = "0x6003713")]
		protected abstract void Configuration_OnLoad(Preferences obj);

		// Token: 0x060031F7 RID: 12791 RVA: 0x0002AF05 File Offset: 0x00029105
		[global::Cpp2ILInjected.Token(Token = "0x6003714")]
		[global::Cpp2ILInjected.Address(RVA = "0x1864228", Offset = "0x1864228", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected void Wrapped_Configuration_OnLoad(Preferences obj)
		{
			throw null;
		}

		// Token: 0x060031F8 RID: 12792
		[global::Cpp2ILInjected.Token(Token = "0x6003715")]
		protected abstract void PopulateOptionsAndLoadContent(AssetRequestMode mode);

		// Token: 0x060031F9 RID: 12793 RVA: 0x0002AF08 File Offset: 0x00029108
		[global::Cpp2ILInjected.Token(Token = "0x6003716")]
		[global::Cpp2ILInjected.Address(RVA = "0x1864278", Offset = "0x1864278", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void LoadContent(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x0002AF0B File Offset: 0x0002910B
		[global::Cpp2ILInjected.Token(Token = "0x6003717")]
		[global::Cpp2ILInjected.Address(RVA = "0x18642BC", Offset = "0x18642BC", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void CycleSelection()
		{
			throw null;
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x0002AF0E File Offset: 0x0002910E
		[global::Cpp2ILInjected.Token(Token = "0x6003718")]
		[global::Cpp2ILInjected.Address(RVA = "0x18643F4", Offset = "0x18643F4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetActiveMinimapFromLoadedConfigKey()
		{
			throw null;
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x0002AF11 File Offset: 0x00029111
		[global::Cpp2ILInjected.Token(Token = "0x6003719")]
		[global::Cpp2ILInjected.Address(RVA = "0x186440C", Offset = "0x186440C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void SetActiveFrame(string frameName)
		{
			throw null;
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x0002AF14 File Offset: 0x00029114
		[global::Cpp2ILInjected.Token(Token = "0x600371A")]
		[global::Cpp2ILInjected.Address(RVA = "0x186451C", Offset = "0x186451C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void SetActiveFrame(TCycleType frame)
		{
			throw null;
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x0002AF17 File Offset: 0x00029117
		[global::Cpp2ILInjected.Token(Token = "0x600371B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1864640", Offset = "0x1864640", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager2), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SelectionHolder()
		{
			throw null;
		}

		// Token: 0x04006424 RID: 25636
		[global::Cpp2ILInjected.Token(Token = "0x4007814")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected Dictionary<string, TCycleType> Options;

		// Token: 0x04006425 RID: 25637
		[global::Cpp2ILInjected.Token(Token = "0x4007815")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected TCycleType ActiveSelection;

		// Token: 0x04006426 RID: 25638
		[global::Cpp2ILInjected.Token(Token = "0x4007816")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected string ActiveSelectionConfigKey;

		// Token: 0x04006427 RID: 25639
		[global::Cpp2ILInjected.Token(Token = "0x4007817")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected bool LoadedContent;

		// Token: 0x04006428 RID: 25640
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007818")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string <ActiveSelectionKeyName>k__BackingField;

		// Token: 0x02000931 RID: 2353
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200066E")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06004C92 RID: 19602 RVA: 0x0002F8DC File Offset: 0x0002DADC
			[global::Cpp2ILInjected.Token(Token = "0x600371C")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B2468", Offset = "0x15B2468", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass14_0()
			{
				throw null;
			}

			// Token: 0x06004C93 RID: 19603 RVA: 0x0002F8DF File Offset: 0x0002DADF
			[global::Cpp2ILInjected.Token(Token = "0x600371D")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B2470", Offset = "0x15B2470", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <CycleSelection>b__0(TCycleType frame)
			{
				throw null;
			}

			// Token: 0x04008ACF RID: 35535
			[global::Cpp2ILInjected.Token(Token = "0x4007819")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public SelectionHolder<TCycleType> <>4__this;

			// Token: 0x04008AD0 RID: 35536
			[global::Cpp2ILInjected.Token(Token = "0x400781A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public TCycleType lastFrame;
		}

		// Token: 0x02000932 RID: 2354
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200066F")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06004C94 RID: 19604 RVA: 0x0002F8E2 File Offset: 0x0002DAE2
			[global::Cpp2ILInjected.Token(Token = "0x600371E")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B2508", Offset = "0x15B2508", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass16_0()
			{
				throw null;
			}

			// Token: 0x06004C95 RID: 19605 RVA: 0x0002F8E5 File Offset: 0x0002DAE5
			[global::Cpp2ILInjected.Token(Token = "0x600371F")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B2510", Offset = "0x15B2510", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			internal bool <SetActiveFrame>b__0(KeyValuePair<string, TCycleType> pair)
			{
				throw null;
			}

			// Token: 0x04008AD1 RID: 35537
			[global::Cpp2ILInjected.Token(Token = "0x400781B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public string frameName;
		}
	}
}
