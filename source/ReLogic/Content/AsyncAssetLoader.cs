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
	[global::Cpp2ILInjected.Token(Token = "0x2000B47")]
	public class AsyncAssetLoader
	{
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

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008D0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <Remaining>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4008D0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly AssetReaderCollection _readers;

		[global::Cpp2ILInjected.Token(Token = "0x4008D10")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly ConcurrentQueue<Action> _pendingCallbacks;

		[global::Cpp2ILInjected.Token(Token = "0x4008D11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly ConcurrentQueue<Action> _pendingDelayedCallbacks;

		[global::Cpp2ILInjected.Token(Token = "0x4008D12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly HashSet<Type> _delayedLoadTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4008D13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly int _maxCreationsPerTransfer;
	}
}
