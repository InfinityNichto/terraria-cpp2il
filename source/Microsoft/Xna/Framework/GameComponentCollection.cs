using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000279 RID: 633
	[global::Cpp2ILInjected.Token(Token = "0x200033A")]
	public sealed class GameComponentCollection : Collection<IGameComponent>
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600137D RID: 4989 RVA: 0x0002552C File Offset: 0x0002372C
		// (remove) Token: 0x0600137E RID: 4990 RVA: 0x0002552F File Offset: 0x0002372F
		[global::Cpp2ILInjected.Token(Token = "0x1400000C")]
		public event EventHandler<GameComponentCollectionEventArgs> ComponentAdded
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014DA")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96AE8", Offset = "0xA96AE8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014DB")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96B98", Offset = "0xA96B98", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600137F RID: 4991 RVA: 0x00025532 File Offset: 0x00023732
		// (remove) Token: 0x06001380 RID: 4992 RVA: 0x00025535 File Offset: 0x00023735
		[global::Cpp2ILInjected.Token(Token = "0x1400000D")]
		public event EventHandler<GameComponentCollectionEventArgs> ComponentRemoved
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014DC")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96C48", Offset = "0xA96C48", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014DD")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96CF8", Offset = "0xA96CF8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00025538 File Offset: 0x00023738
		[global::Cpp2ILInjected.Token(Token = "0x60014DE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96DA8", Offset = "0xA96DA8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameComponentCollectionEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(IGameComponent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "ClearItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void ClearItems()
		{
			throw null;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0002553B File Offset: 0x0002373B
		[global::Cpp2ILInjected.Token(Token = "0x60014DF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96EEC", Offset = "0xA96EEC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "IndexOf", MemberParameters = new object[] { "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameComponentCollectionEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(IGameComponent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected override void InsertItem(int index, IGameComponent item)
		{
			throw null;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0002553E File Offset: 0x0002373E
		[global::Cpp2ILInjected.Token(Token = "0x60014E0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA97020", Offset = "0xA97020", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnComponentAdded(GameComponentCollectionEventArgs eventArgs)
		{
			throw null;
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00025541 File Offset: 0x00023741
		[global::Cpp2ILInjected.Token(Token = "0x60014E1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96EC4", Offset = "0xA96EC4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnComponentRemoved(GameComponentCollectionEventArgs eventArgs)
		{
			throw null;
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00025544 File Offset: 0x00023744
		[global::Cpp2ILInjected.Token(Token = "0x60014E2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA97048", Offset = "0xA97048", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "RemoveItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameComponentCollectionEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(IGameComponent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void RemoveItem(int index)
		{
			throw null;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00025547 File Offset: 0x00023747
		[global::Cpp2ILInjected.Token(Token = "0x60014E3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA97128", Offset = "0xA97128", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void SetItem(int index, IGameComponent item)
		{
			throw null;
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0002554A File Offset: 0x0002374A
		[global::Cpp2ILInjected.Token(Token = "0x60014E4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94D94", Offset = "0xA94D94", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GameComponentCollection()
		{
			throw null;
		}

		// Token: 0x04001CE8 RID: 7400
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private EventHandler<GameComponentCollectionEventArgs> ComponentAdded;

		// Token: 0x04001CE9 RID: 7401
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private EventHandler<GameComponentCollectionEventArgs> ComponentRemoved;
	}
}
