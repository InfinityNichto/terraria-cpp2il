using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[DefaultEvent("DoWork")]
	[global::Cpp2ILInjected.Token(Token = "0x2000330")]
	public class BackgroundWorker : Component
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001542")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A690", Offset = "0x1E3A690", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SendOrPostCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public BackgroundWorker()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001543")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A770", Offset = "0x1E3A770", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AsyncOperationCompleted(object arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004DA")]
		public bool CancellationPending
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001544")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A804", Offset = "0x1E3A804", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001545")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A80C", Offset = "0x1E3A80C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void CancelAsync()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1400000E")]
		public event DoWorkEventHandler DoWork
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001546")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A870", Offset = "0x1E3A870", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6001547")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A90C", Offset = "0x1E3A90C", Length = "0x9C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x170004DB")]
		public bool IsBusy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001548")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A9A8", Offset = "0x1E3A9A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001549")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A9B0", Offset = "0x1E3A9B0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnDoWork(DoWorkEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600154A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A9D8", Offset = "0x1E3A9D8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600154B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3AA00", Offset = "0x1E3AA00", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1400000F")]
		public event ProgressChangedEventHandler ProgressChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600154C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3AA28", Offset = "0x1E3AA28", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.Token(Token = "0x600154D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3AAC4", Offset = "0x1E3AAC4", Length = "0x9C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x600154E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3AB60", Offset = "0x1E3AB60", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ProgressReporter(object arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600154F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3ABF0", Offset = "0x1E3ABF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ReportProgress(int percentProgress)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001550")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3ABF8", Offset = "0x1E3ABF8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProgressChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "PostCore", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void ReportProgress(int percentProgress, object userState)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001551")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3ACE8", Offset = "0x1E3ACE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void RunWorkerAsync()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001552")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3ACF0", Offset = "0x1E3ACF0", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperationManager), Member = "get_SynchronizationContext", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "CreateOperation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SynchronizationContext)
		}, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new object[]
		{
			typeof(Action<object>),
			typeof(object),
			typeof(CancellationToken),
			typeof(TaskCreationOptions),
			typeof(TaskScheduler)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void RunWorkerAsync(object argument)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000010")]
		public event RunWorkerCompletedEventHandler RunWorkerCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001553")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3AEEC", Offset = "0x1E3AEEC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6001554")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3AF88", Offset = "0x1E3AF88", Length = "0x9C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x170004DC")]
		public bool WorkerReportsProgress
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001555")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3B024", Offset = "0x1E3B024", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001556")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3B02C", Offset = "0x1E3B02C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004DD")]
		public bool WorkerSupportsCancellation
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001557")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3B038", Offset = "0x1E3B038", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001558")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3B040", Offset = "0x1E3B040", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001559")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B04C", Offset = "0x1E3B04C", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "<RunWorkerAsync>b__27_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DoWorkEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RunWorkerCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "PostCore", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "OperationCompletedCore", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void WorkerThreadStart(object argument)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600155A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B1B8", Offset = "0x1E3B1B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600155B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B1BC", Offset = "0x1E3B1BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BackgroundWorker), Member = "WorkerThreadStart", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		private void <RunWorkerAsync>b__27_0(object arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001176")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _canCancelWorker;

		[global::Cpp2ILInjected.Token(Token = "0x4001177")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _workerReportsProgress;

		[global::Cpp2ILInjected.Token(Token = "0x4001178")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private bool _cancellationPending;

		[global::Cpp2ILInjected.Token(Token = "0x4001179")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
		private bool _isRunning;

		[global::Cpp2ILInjected.Token(Token = "0x400117A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private AsyncOperation _asyncOperation;

		[global::Cpp2ILInjected.Token(Token = "0x400117B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly SendOrPostCallback _operationCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x400117C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly SendOrPostCallback _progressReporter;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400117D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private DoWorkEventHandler DoWork;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400117E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private ProgressChangedEventHandler ProgressChanged;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400117F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private RunWorkerCompletedEventHandler RunWorkerCompleted;
	}
}
