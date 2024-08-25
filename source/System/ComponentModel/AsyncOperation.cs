using System;
using System.Net;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200032E")]
	public sealed class AsyncOperation
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001532")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A214", Offset = "0x1E3A214", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private AsyncOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001533")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A250", Offset = "0x1E3A250", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D7")]
		public object UserSuppliedState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001534")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A2FC", Offset = "0x1E3A2FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D8")]
		public SynchronizationContext SynchronizationContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001535")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A304", Offset = "0x1E3A304", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001536")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A30C", Offset = "0x1E3A30C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "PostProgressChanged", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			"System.Net.WebClient.ProgressData"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Post(SendOrPostCallback d, object arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001537")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A36C", Offset = "0x1E3A36C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "PostCore", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void PostOperationCompleted(SendOrPostCallback d, object arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001538")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A46C", Offset = "0x1E3A46C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "VerifyNotCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "OperationCompletedCore", ReturnType = typeof(void))]
		public void OperationCompleted()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001539")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A314", Offset = "0x1E3A314", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperation), Member = "PostOperationCompleted", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "ReportProgress", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "WorkerThreadStart", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "VerifyNotCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "VerifyDelegateNotNull", MemberParameters = new object[] { typeof(SendOrPostCallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void PostCore(SendOrPostCallback d, object arg, bool markCompleted)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600153A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A388", Offset = "0x1E3A388", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperation), Member = "OperationCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "WorkerThreadStart", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void OperationCompletedCore()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600153B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A48C", Offset = "0x1E3A48C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperation), Member = "OperationCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperation), Member = "PostCore", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void VerifyNotCompleted()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600153C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A4E8", Offset = "0x1E3A4E8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperation), Member = "PostCore", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void VerifyDelegateNotNull(SendOrPostCallback d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600153D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A554", Offset = "0x1E3A554", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperationManager), Member = "CreateOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "RunWorkerAsync", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600153E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A5D0", Offset = "0x1E3A5D0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal AsyncOperation()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001173")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly SynchronizationContext _syncContext;

		[global::Cpp2ILInjected.Token(Token = "0x4001174")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly object _userSuppliedState;

		[global::Cpp2ILInjected.Token(Token = "0x4001175")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _alreadyCompleted;
	}
}
