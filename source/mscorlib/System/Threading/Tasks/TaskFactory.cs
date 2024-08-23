using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	// Token: 0x020001B6 RID: 438
	[global::Cpp2ILInjected.Token(Token = "0x200022C")]
	public class TaskFactory<TResult>
	{
		// Token: 0x060011BB RID: 4539 RVA: 0x000176B7 File Offset: 0x000158B7
		[global::Cpp2ILInjected.Token(Token = "0x600134C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870BAC", Offset = "0x1870BAC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TaskFactory()
		{
			throw null;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x000176BA File Offset: 0x000158BA
		[global::Cpp2ILInjected.Token(Token = "0x600134D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870BD0", Offset = "0x1870BD0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "CheckMultiTaskContinuationOptions", MemberParameters = new object[] { typeof(TaskContinuationOptions) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "CheckCreationOptions", MemberParameters = new object[] { typeof(TaskCreationOptions) }, ReturnType = typeof(void))]
		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			throw null;
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x000176BD File Offset: 0x000158BD
		[global::Cpp2ILInjected.Token(Token = "0x600134E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870C28", Offset = "0x1870C28", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void FromAsyncCoreLogic(global::System.IAsyncResult iar, global::System.Func<global::System.IAsyncResult, TResult> endFunction, global::System.Action<global::System.IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
		{
			throw null;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x000176C0 File Offset: 0x000158C0
		[global::Cpp2ILInjected.Token(Token = "0x600134F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870E30", Offset = "0x1870E30", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Task<TResult> FromAsync(global::System.Func<global::System.AsyncCallback, object, global::System.IAsyncResult> beginMethod, global::System.Func<global::System.IAsyncResult, TResult> endMethod, object state)
		{
			throw null;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x000176C3 File Offset: 0x000158C3
		[global::Cpp2ILInjected.Token(Token = "0x6001350")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870E54", Offset = "0x1870E54", Length = "0x5D4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "CheckFromAsyncOptions", MemberParameters = new object[]
		{
			typeof(TaskCreationOptions),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "get_LoggingOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "TraceOperationCreation", MemberParameters = new object[]
		{
			typeof(CausalityTraceLevel),
			typeof(Task),
			typeof(string),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "TraceOperationCompletion", MemberParameters = new object[]
		{
			typeof(CausalityTraceLevel),
			typeof(Task),
			typeof(Internal.Runtime.Augments.AsyncStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 55)]
		internal static Task<TResult> FromAsyncImpl(global::System.Func<global::System.AsyncCallback, object, global::System.IAsyncResult> beginMethod, global::System.Func<global::System.IAsyncResult, TResult> endFunction, global::System.Action<global::System.IAsyncResult> endAction, object state, TaskCreationOptions creationOptions)
		{
			throw null;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000176C6 File Offset: 0x000158C6
		[global::Cpp2ILInjected.Token(Token = "0x6001351")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C3920", Offset = "0x14C3920", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Dns", Member = "GetHostAddressesAsync", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Threading.Tasks.Task`1<IPAddress[]>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Dns", Member = "GetHostEntryAsync", MemberParameters = new object[] { "System.Net.IPAddress" }, ReturnType = "System.Threading.Tasks.Task`1<IPHostEntry>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Dns", Member = "GetHostEntryAsync", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Threading.Tasks.Task`1<IPHostEntry>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Task<TResult> FromAsync<TArg1>(global::System.Func<TArg1, global::System.AsyncCallback, object, global::System.IAsyncResult> beginMethod, global::System.Func<global::System.IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
		{
			throw null;
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000176C9 File Offset: 0x000158C9
		[global::Cpp2ILInjected.Token(Token = "0x6001352")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C3940", Offset = "0x14C3940", Length = "0x57C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "CheckFromAsyncOptions", MemberParameters = new object[]
		{
			typeof(TaskCreationOptions),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "get_LoggingOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "TraceOperationCreation", MemberParameters = new object[]
		{
			typeof(CausalityTraceLevel),
			typeof(Task),
			typeof(string),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "TraceOperationCompletion", MemberParameters = new object[]
		{
			typeof(CausalityTraceLevel),
			typeof(Task),
			typeof(Internal.Runtime.Augments.AsyncStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		internal static Task<TResult> FromAsyncImpl<TArg1>(global::System.Func<TArg1, global::System.AsyncCallback, object, global::System.IAsyncResult> beginMethod, global::System.Func<global::System.IAsyncResult, TResult> endFunction, global::System.Action<global::System.IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			throw null;
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x000176CC File Offset: 0x000158CC
		[global::Cpp2ILInjected.Token(Token = "0x6001353")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C3EBC", Offset = "0x14C3EBC", Length = "0x58C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "CheckFromAsyncOptions", MemberParameters = new object[]
		{
			typeof(TaskCreationOptions),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "get_LoggingOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "TraceOperationCreation", MemberParameters = new object[]
		{
			typeof(CausalityTraceLevel),
			typeof(Task),
			typeof(string),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "TraceOperationCompletion", MemberParameters = new object[]
		{
			typeof(CausalityTraceLevel),
			typeof(Task),
			typeof(Internal.Runtime.Augments.AsyncStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(global::System.Func<TArg1, TArg2, global::System.AsyncCallback, object, global::System.IAsyncResult> beginMethod, global::System.Func<global::System.IAsyncResult, TResult> endFunction, global::System.Action<global::System.IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			throw null;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x000176CF File Offset: 0x000158CF
		[global::Cpp2ILInjected.Token(Token = "0x6001354")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C3794", Offset = "0x14C3794", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "BeginEndReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, global::System.Func<TInstance, TArgs, global::System.AsyncCallback, object, global::System.IAsyncResult> beginMethod, global::System.Func<TInstance, global::System.IAsyncResult, TResult> endMethod) where TInstance : class
		{
			throw null;
		}

		// Token: 0x040007F5 RID: 2037
		[global::Cpp2ILInjected.Token(Token = "0x4000A40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private CancellationToken m_defaultCancellationToken;

		// Token: 0x040007F6 RID: 2038
		[global::Cpp2ILInjected.Token(Token = "0x4000A41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TaskScheduler m_defaultScheduler;

		// Token: 0x040007F7 RID: 2039
		[global::Cpp2ILInjected.Token(Token = "0x4000A42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TaskCreationOptions m_defaultCreationOptions;

		// Token: 0x040007F8 RID: 2040
		[global::Cpp2ILInjected.Token(Token = "0x4000A43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TaskContinuationOptions m_defaultContinuationOptions;

		// Token: 0x020005C1 RID: 1473
		[global::Cpp2ILInjected.Token(Token = "0x200022D")]
		private sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
		{
			// Token: 0x06004068 RID: 16488 RVA: 0x0001FBE9 File Offset: 0x0001DDE9
			[global::Cpp2ILInjected.Token(Token = "0x6001355")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A30E4", Offset = "0x16A30E4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal FromAsyncTrimPromise(TInstance thisRef, global::System.Func<TInstance, global::System.IAsyncResult, TResult> endMethod)
			{
				throw null;
			}

			// Token: 0x06004069 RID: 16489 RVA: 0x0001FBEC File Offset: 0x0001DDEC
			[global::Cpp2ILInjected.Token(Token = "0x6001356")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A311C", Offset = "0x16A311C", Length = "0x268")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			internal static void CompleteFromAsyncResult(global::System.IAsyncResult asyncResult)
			{
				throw null;
			}

			// Token: 0x0600406A RID: 16490 RVA: 0x0001FBEF File Offset: 0x0001DDEF
			[global::Cpp2ILInjected.Token(Token = "0x6001357")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A3384", Offset = "0x16A3384", Length = "0x144")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
			{
				typeof(CancellationToken),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void Complete(TInstance thisRef, global::System.Func<TInstance, global::System.IAsyncResult, TResult> endMethod, global::System.IAsyncResult asyncResult, bool requiresSynchronization)
			{
				throw null;
			}

			// Token: 0x0600406B RID: 16491 RVA: 0x0001FBF2 File Offset: 0x0001DDF2
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001358")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A34C8", Offset = "0x16A34C8", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AsyncCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			static FromAsyncTrimPromise()
			{
				throw null;
			}

			// Token: 0x040018D3 RID: 6355
			[global::Cpp2ILInjected.Token(Token = "0x4000A44")]
			internal static readonly global::System.AsyncCallback s_completeFromAsyncResult;

			// Token: 0x040018D4 RID: 6356
			[global::Cpp2ILInjected.Token(Token = "0x4000A45")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TInstance m_thisRef;

			// Token: 0x040018D5 RID: 6357
			[global::Cpp2ILInjected.Token(Token = "0x4000A46")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.Func<TInstance, global::System.IAsyncResult, TResult> m_endMethod;
		}

		// Token: 0x020005C2 RID: 1474
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200022E")]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x0600406C RID: 16492 RVA: 0x0001FBF5 File Offset: 0x0001DDF5
			[global::Cpp2ILInjected.Token(Token = "0x6001359")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B25BC", Offset = "0x15B25BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass35_0()
			{
				throw null;
			}

			// Token: 0x0600406D RID: 16493 RVA: 0x0001FBF8 File Offset: 0x0001DDF8
			[global::Cpp2ILInjected.Token(Token = "0x600135A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B25C4", Offset = "0x15B25C4", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <FromAsyncImpl>b__0(global::System.IAsyncResult iar)
			{
				throw null;
			}

			// Token: 0x040018D6 RID: 6358
			[global::Cpp2ILInjected.Token(Token = "0x4000A47")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public global::System.Func<global::System.IAsyncResult, TResult> endFunction;

			// Token: 0x040018D7 RID: 6359
			[global::Cpp2ILInjected.Token(Token = "0x4000A48")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public global::System.Action<global::System.IAsyncResult> endAction;

			// Token: 0x040018D8 RID: 6360
			[global::Cpp2ILInjected.Token(Token = "0x4000A49")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Task<TResult> promise;
		}

		// Token: 0x020005C3 RID: 1475
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200022F")]
		private sealed class <>c__DisplayClass38_0<TArg1>
		{
			// Token: 0x0600406E RID: 16494 RVA: 0x0001FBFB File Offset: 0x0001DDFB
			[global::Cpp2ILInjected.Token(Token = "0x600135B")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B2DE4", Offset = "0x15B2DE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass38_0()
			{
				throw null;
			}

			// Token: 0x0600406F RID: 16495 RVA: 0x0001FBFE File Offset: 0x0001DDFE
			[global::Cpp2ILInjected.Token(Token = "0x600135C")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B2DEC", Offset = "0x15B2DEC", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <FromAsyncImpl>b__0(global::System.IAsyncResult iar)
			{
				throw null;
			}

			// Token: 0x040018D9 RID: 6361
			[global::Cpp2ILInjected.Token(Token = "0x4000A4A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public global::System.Func<global::System.IAsyncResult, TResult> endFunction;

			// Token: 0x040018DA RID: 6362
			[global::Cpp2ILInjected.Token(Token = "0x4000A4B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public global::System.Action<global::System.IAsyncResult> endAction;

			// Token: 0x040018DB RID: 6363
			[global::Cpp2ILInjected.Token(Token = "0x4000A4C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Task<TResult> promise;
		}

		// Token: 0x020005C4 RID: 1476
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000230")]
		private sealed class <>c__DisplayClass41_0<TArg1, TArg2>
		{
			// Token: 0x06004070 RID: 16496 RVA: 0x0001FC01 File Offset: 0x0001DE01
			[global::Cpp2ILInjected.Token(Token = "0x600135D")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B2FB4", Offset = "0x15B2FB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass41_0()
			{
				throw null;
			}

			// Token: 0x06004071 RID: 16497 RVA: 0x0001FC04 File Offset: 0x0001DE04
			[global::Cpp2ILInjected.Token(Token = "0x600135E")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B2FBC", Offset = "0x15B2FBC", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <FromAsyncImpl>b__0(global::System.IAsyncResult iar)
			{
				throw null;
			}

			// Token: 0x040018DC RID: 6364
			[global::Cpp2ILInjected.Token(Token = "0x4000A4D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public global::System.Func<global::System.IAsyncResult, TResult> endFunction;

			// Token: 0x040018DD RID: 6365
			[global::Cpp2ILInjected.Token(Token = "0x4000A4E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public global::System.Action<global::System.IAsyncResult> endAction;

			// Token: 0x040018DE RID: 6366
			[global::Cpp2ILInjected.Token(Token = "0x4000A4F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Task<TResult> promise;
		}
	}
}
