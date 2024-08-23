using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200023F RID: 575
	[DefaultEvent("DoWork")]
	[global::Cpp2ILInjected.Token(Token = "0x2000330")]
	public class BackgroundWorker : Component
	{
		// Token: 0x06001304 RID: 4868 RVA: 0x0000649D File Offset: 0x0000469D
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

		// Token: 0x06001305 RID: 4869 RVA: 0x000064A0 File Offset: 0x000046A0
		[global::Cpp2ILInjected.Token(Token = "0x6001543")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A770", Offset = "0x1E3A770", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AsyncOperationCompleted(object arg)
		{
			throw null;
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x000064A3 File Offset: 0x000046A3
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

		// Token: 0x06001307 RID: 4871 RVA: 0x000064A6 File Offset: 0x000046A6
		[global::Cpp2ILInjected.Token(Token = "0x6001545")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A80C", Offset = "0x1E3A80C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void CancelAsync()
		{
			throw null;
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06001308 RID: 4872 RVA: 0x000064A9 File Offset: 0x000046A9
		// (remove) Token: 0x06001309 RID: 4873 RVA: 0x000064AC File Offset: 0x000046AC
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

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x000064AF File Offset: 0x000046AF
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

		// Token: 0x0600130B RID: 4875 RVA: 0x000064B2 File Offset: 0x000046B2
		[global::Cpp2ILInjected.Token(Token = "0x6001549")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A9B0", Offset = "0x1E3A9B0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnDoWork(DoWorkEventArgs e)
		{
			throw null;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000064B5 File Offset: 0x000046B5
		[global::Cpp2ILInjected.Token(Token = "0x600154A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A9D8", Offset = "0x1E3A9D8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
		{
			throw null;
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000064B8 File Offset: 0x000046B8
		[global::Cpp2ILInjected.Token(Token = "0x600154B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3AA00", Offset = "0x1E3AA00", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
		{
			throw null;
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600130E RID: 4878 RVA: 0x000064BB File Offset: 0x000046BB
		// (remove) Token: 0x0600130F RID: 4879 RVA: 0x000064BE File Offset: 0x000046BE
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

		// Token: 0x06001310 RID: 4880 RVA: 0x000064C1 File Offset: 0x000046C1
		[global::Cpp2ILInjected.Token(Token = "0x600154E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3AB60", Offset = "0x1E3AB60", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ProgressReporter(object arg)
		{
			throw null;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000064C4 File Offset: 0x000046C4
		[global::Cpp2ILInjected.Token(Token = "0x600154F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3ABF0", Offset = "0x1E3ABF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ReportProgress(int percentProgress)
		{
			throw null;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x000064C7 File Offset: 0x000046C7
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

		// Token: 0x06001313 RID: 4883 RVA: 0x000064CA File Offset: 0x000046CA
		[global::Cpp2ILInjected.Token(Token = "0x6001551")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3ACE8", Offset = "0x1E3ACE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void RunWorkerAsync()
		{
			throw null;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000064CD File Offset: 0x000046CD
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

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06001315 RID: 4885 RVA: 0x000064D0 File Offset: 0x000046D0
		// (remove) Token: 0x06001316 RID: 4886 RVA: 0x000064D3 File Offset: 0x000046D3
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

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x000064D6 File Offset: 0x000046D6
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x000064D9 File Offset: 0x000046D9
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

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x000064DC File Offset: 0x000046DC
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x000064DF File Offset: 0x000046DF
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

		// Token: 0x0600131B RID: 4891 RVA: 0x000064E2 File Offset: 0x000046E2
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

		// Token: 0x0600131C RID: 4892 RVA: 0x000064E5 File Offset: 0x000046E5
		[global::Cpp2ILInjected.Token(Token = "0x600155A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B1B8", Offset = "0x1E3B1B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x000064E8 File Offset: 0x000046E8
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600155B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B1BC", Offset = "0x1E3B1BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BackgroundWorker), Member = "WorkerThreadStart", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		private void <RunWorkerAsync>b__27_0(object arg)
		{
			throw null;
		}

		// Token: 0x04000D79 RID: 3449
		[global::Cpp2ILInjected.Token(Token = "0x4001176")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _canCancelWorker;

		// Token: 0x04000D7A RID: 3450
		[global::Cpp2ILInjected.Token(Token = "0x4001177")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _workerReportsProgress;

		// Token: 0x04000D7B RID: 3451
		[global::Cpp2ILInjected.Token(Token = "0x4001178")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private bool _cancellationPending;

		// Token: 0x04000D7C RID: 3452
		[global::Cpp2ILInjected.Token(Token = "0x4001179")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
		private bool _isRunning;

		// Token: 0x04000D7D RID: 3453
		[global::Cpp2ILInjected.Token(Token = "0x400117A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private AsyncOperation _asyncOperation;

		// Token: 0x04000D7E RID: 3454
		[global::Cpp2ILInjected.Token(Token = "0x400117B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly SendOrPostCallback _operationCompleted;

		// Token: 0x04000D7F RID: 3455
		[global::Cpp2ILInjected.Token(Token = "0x400117C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly SendOrPostCallback _progressReporter;

		// Token: 0x04000D80 RID: 3456
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400117D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private DoWorkEventHandler DoWork;

		// Token: 0x04000D81 RID: 3457
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400117E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private ProgressChangedEventHandler ProgressChanged;

		// Token: 0x04000D82 RID: 3458
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400117F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private RunWorkerCompletedEventHandler RunWorkerCompleted;
	}
}
