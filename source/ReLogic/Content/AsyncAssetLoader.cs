using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Content.Sources;
using Terraria.Initializers;

namespace ReLogic.Content
{
	// Token: 0x02000745 RID: 1861
	[global::Cpp2ILInjected.Token(Token = "0x2000B47")]
	public class AsyncAssetLoader
	{
		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x0002EBC5 File Offset: 0x0002CDC5
		// (set) Token: 0x06004744 RID: 18244 RVA: 0x0002EBC8 File Offset: 0x0002CDC8
		[global::Cpp2ILInjected.Token(Token = "0x17000919")]
		public int Remaining
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005401")]
			[global::Cpp2ILInjected.Address(RVA = "0x947534", Offset = "0x947534", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005402")]
			[global::Cpp2ILInjected.Address(RVA = "0x94753C", Offset = "0x94753C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x0002EBCB File Offset: 0x0002CDCB
		[global::Cpp2ILInjected.Token(Token = "0x1700091A")]
		internal int AssetsReadyForTransfer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005403")]
			[global::Cpp2ILInjected.Address(RVA = "0x947544", Offset = "0x947544", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x0002EBCE File Offset: 0x0002CDCE
		[global::Cpp2ILInjected.Token(Token = "0x6005404")]
		[global::Cpp2ILInjected.Address(RVA = "0x9475A8", Offset = "0x9475A8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public AsyncAssetLoader(AssetReaderCollection readers)
		{
			throw null;
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x0002EBD1 File Offset: 0x0002CDD1
		[global::Cpp2ILInjected.Token(Token = "0x6005405")]
		[global::Cpp2ILInjected.Address(RVA = "0x947698", Offset = "0x947698", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "CreateAssetServices", MemberParameters = new object[] { typeof(GameServiceContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public AsyncAssetLoader(AssetReaderCollection readers, int maxCreationsPerTransfer)
		{
			throw null;
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x0002EBD4 File Offset: 0x0002CDD4
		[global::Cpp2ILInjected.Token(Token = "0x6005406")]
		[global::Cpp2ILInjected.Address(RVA = "0x94694C", Offset = "0x94694C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetRepository), Member = "SetSources", MemberParameters = new object[]
		{
			typeof(IEnumerable<IContentSource>),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetRepository), Member = "TransferCompletedAssets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "TryDequeue", MemberParameters = new object[] { typeof(ref object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void TransferCompleted()
		{
			throw null;
		}

		// Token: 0x0400736C RID: 29548
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008D0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <Remaining>k__BackingField;

		// Token: 0x0400736D RID: 29549
		[global::Cpp2ILInjected.Token(Token = "0x4008D0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly AssetReaderCollection _readers;

		// Token: 0x0400736E RID: 29550
		[global::Cpp2ILInjected.Token(Token = "0x4008D10")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly ConcurrentQueue<Action> _pendingCallbacks;

		// Token: 0x0400736F RID: 29551
		[global::Cpp2ILInjected.Token(Token = "0x4008D11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly ConcurrentQueue<Action> _pendingDelayedCallbacks;

		// Token: 0x04007370 RID: 29552
		[global::Cpp2ILInjected.Token(Token = "0x4008D12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly HashSet<Type> _delayedLoadTypes;

		// Token: 0x04007371 RID: 29553
		[global::Cpp2ILInjected.Token(Token = "0x4008D13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly int _maxCreationsPerTransfer;
	}
}
