using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B0F")]
	public class AsyncActionDispatcher : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008EF")]
		public int ActionsRemaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005302")]
			[global::Cpp2ILInjected.Address(RVA = "0x940608", Offset = "0x940608", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlockingCollection<>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008F0")]
		public bool IsDisposed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005303")]
			[global::Cpp2ILInjected.Address(RVA = "0x940650", Offset = "0x940650", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005304")]
			[global::Cpp2ILInjected.Address(RVA = "0x940658", Offset = "0x940658", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008F1")]
		public bool IsRunning
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005305")]
			[global::Cpp2ILInjected.Address(RVA = "0x940664", Offset = "0x940664", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005306")]
		[global::Cpp2ILInjected.Address(RVA = "0x94067C", Offset = "0x94067C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlockingCollection<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Queue(Action action)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005307")]
		[global::Cpp2ILInjected.Address(RVA = "0x9406D4", Offset = "0x9406D4", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void Start()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005308")]
		[global::Cpp2ILInjected.Address(RVA = "0x940818", Offset = "0x940818", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncActionDispatcher), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Join", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Stop()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005309")]
		[global::Cpp2ILInjected.Address(RVA = "0x9408A0", Offset = "0x9408A0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlockingCollection<>), Member = "Take", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void LoaderThreadStart()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600530A")]
		[global::Cpp2ILInjected.Address(RVA = "0x940998", Offset = "0x940998", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncActionDispatcher), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlockingCollection<>), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600530B")]
		[global::Cpp2ILInjected.Address(RVA = "0x940A1C", Offset = "0x940A1C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600530C")]
		[global::Cpp2ILInjected.Address(RVA = "0x940A2C", Offset = "0x940A2C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlockingCollection<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public AsyncActionDispatcher()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008AE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Thread _actionThread;

		[global::Cpp2ILInjected.Token(Token = "0x4008AE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly BlockingCollection<Action> _actionQueue;

		[global::Cpp2ILInjected.Token(Token = "0x4008AE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly CancellationTokenSource _threadCancellation;

		[global::Cpp2ILInjected.Token(Token = "0x4008AEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _isRunning;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008AEB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool <IsDisposed>k__BackingField;
	}
}
