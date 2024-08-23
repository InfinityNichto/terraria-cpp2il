using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001AF RID: 431
	[global::Cpp2ILInjected.Token(Token = "0x2000272")]
	internal class ServicePointScheduler
	{
		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00005AAA File Offset: 0x00003CAA
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x00005AAD File Offset: 0x00003CAD
		[global::Cpp2ILInjected.Token(Token = "0x170003EE")]
		private ServicePoint ServicePoint
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001129")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0877C", Offset = "0x1E0877C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600112A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08784", Offset = "0x1E08784", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00005AB0 File Offset: 0x00003CB0
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x00005AB3 File Offset: 0x00003CB3
		[global::Cpp2ILInjected.Token(Token = "0x170003EF")]
		public int MaxIdleTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600112B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0878C", Offset = "0x1E0878C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600112C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05820", Offset = "0x1E05820", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "Run", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00005AB6 File Offset: 0x00003CB6
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x00005AB9 File Offset: 0x00003CB9
		[global::Cpp2ILInjected.Token(Token = "0x170003F0")]
		public int ConnectionLimit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600112D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08850", Offset = "0x1E08850", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600112E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E056F4", Offset = "0x1E056F4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "Run", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00005ABC File Offset: 0x00003CBC
		[global::Cpp2ILInjected.Token(Token = "0x600112F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E05468", Offset = "0x1E05468", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ServicePointManager.SPKey),
			typeof(Uri),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.AsyncManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ServicePointScheduler),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<ValueTuple<object, object, object>>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime)
		{
			throw null;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00005ABF File Offset: 0x00003CBF
		[Conditional("MONO_WEB_DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001130")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E08A00", Offset = "0x1E08A00", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Debug(string message)
		{
			throw null;
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00005AC2 File Offset: 0x00003CC2
		[global::Cpp2ILInjected.Token(Token = "0x170003F1")]
		public int CurrentConnections
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001131")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08A04", Offset = "0x1E08A04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00005AC5 File Offset: 0x00003CC5
		[global::Cpp2ILInjected.Token(Token = "0x170003F2")]
		public DateTime IdleSince
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001132")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08A0C", Offset = "0x1E08A0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00005AC8 File Offset: 0x00003CC8
		[global::Cpp2ILInjected.Token(Token = "0x170003F3")]
		internal string ME
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001133")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08A14", Offset = "0x1E08A14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00005ACB File Offset: 0x00003CCB
		[global::Cpp2ILInjected.Token(Token = "0x6001134")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E08794", Offset = "0x1E08794", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "set_MaxIdleTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "set_ConnectionLimit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "SendRequest", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "CloseConnectionGroup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Run", MemberParameters = new object[] { typeof(Func<Task>) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.AsyncManualResetEvent), Member = "Set", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Run()
		{
			throw null;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00005ACE File Offset: 0x00003CCE
		[global::Cpp2ILInjected.Token(Token = "0x6001135")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E08C38", Offset = "0x1E08C38", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "<Run>b__31_0", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(ServicePointScheduler.<RunScheduler>d__32) }, MemberParameters = new object[] { typeof(ref ServicePointScheduler.<RunScheduler>d__32) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Task RunScheduler()
		{
			throw null;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00005AD1 File Offset: 0x00003CD1
		[global::Cpp2ILInjected.Token(Token = "0x6001136")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E08D08", Offset = "0x1E08D08", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.<RunScheduler>d__32), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.KeyCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "IsEmpty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void Cleanup()
		{
			throw null;
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[global::Cpp2ILInjected.Token(Token = "0x6001137")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E08EFC", Offset = "0x1E08EFC", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.<RunScheduler>d__32), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.AsyncManualResetEvent), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new object[] { typeof(ServicePointScheduler.ConnectionGroup) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void RunSchedulerIteration()
		{
			throw null;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00005AD7 File Offset: 0x00003CD7
		[global::Cpp2ILInjected.Token(Token = "0x6001138")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E09210", Offset = "0x1E09210", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.<RunScheduler>d__32), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<>.Result), Member = "get_Success", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "Continue", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "RemoveConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<>), Member = "AddLast", MemberParameters = new object[] { "T" }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "CreateOrReuseConnection", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(bool)
		}, ReturnType = typeof(ValueTuple<WebConnection, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<ValueTuple<object, object, object>>), Member = "AddLast", MemberParameters = new object[] { typeof(ValueTuple<object, object, object>) }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation)
		{
			throw null;
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00005ADA File Offset: 0x00003CDA
		[global::Cpp2ILInjected.Token(Token = "0x6001139")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E09908", Offset = "0x1E09908", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "RemoveConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
		private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection)
		{
			throw null;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00005ADD File Offset: 0x00003CDD
		[global::Cpp2ILInjected.Token(Token = "0x600113A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E09134", Offset = "0x1E09134", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "RunSchedulerIteration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "CreateOrReuseConnection", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(bool)
		}, ReturnType = typeof(ValueTuple<WebConnection, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<>), Member = "AddLast", MemberParameters = new object[] { "T" }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group)
		{
			throw null;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00005AE0 File Offset: 0x00003CE0
		[global::Cpp2ILInjected.Token(Token = "0x600113B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E09A14", Offset = "0x1E09A14", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<>), Member = "Remove", MemberParameters = new object[] { "System.Collections.Generic.LinkedListNode`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void RemoveOperation(WebOperation operation)
		{
			throw null;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00005AE3 File Offset: 0x00003CE3
		[global::Cpp2ILInjected.Token(Token = "0x600113C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E095EC", Offset = "0x1E095EC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "RemoveConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.<RunScheduler>d__32), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new object[]
		{
			typeof(ServicePointScheduler.ConnectionGroup),
			typeof(WebOperation)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "CloseIdleConnection", MemberParameters = new object[]
		{
			typeof(ServicePointScheduler.ConnectionGroup),
			typeof(WebConnection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new object[] { typeof(ServicePointScheduler.ConnectionGroup) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "OnConnectionClosed", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<ValueTuple<object, object, object>>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<ValueTuple<object, object, object>>), Member = "Remove", MemberParameters = new object[] { typeof(LinkedListNode<ValueTuple<object, object, object>>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void RemoveIdleConnection(WebConnection connection)
		{
			throw null;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00005AE6 File Offset: 0x00003CE6
		[global::Cpp2ILInjected.Token(Token = "0x600113D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E09AD4", Offset = "0x1E09AD4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.<RunScheduler>d__32), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointManager), Member = "RemoveServicePoint", MemberParameters = new object[] { typeof(ServicePoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void FinalCleanup()
		{
			throw null;
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00005AE9 File Offset: 0x00003CE9
		[global::Cpp2ILInjected.Token(Token = "0x600113E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06250", Offset = "0x1E06250", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "SendRequest", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "GetConnectionGroup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ServicePointScheduler.ConnectionGroup))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "EnqueueOperation", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void SendRequest(WebOperation operation, string groupName)
		{
			throw null;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00005AEC File Offset: 0x00003CEC
		[global::Cpp2ILInjected.Token(Token = "0x600113F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06410", Offset = "0x1E06410", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "CloseConnectionGroup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool CloseConnectionGroup(string groupName)
		{
			throw null;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00005AEF File Offset: 0x00003CEF
		[global::Cpp2ILInjected.Token(Token = "0x6001140")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E09B4C", Offset = "0x1E09B4C", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "SendRequest", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ServicePointScheduler),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name)
		{
			throw null;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00005AF2 File Offset: 0x00003CF2
		[global::Cpp2ILInjected.Token(Token = "0x6001141")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0A034", Offset = "0x1E0A034", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		private void OnConnectionCreated(WebConnection connection)
		{
			throw null;
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00005AF5 File Offset: 0x00003CF5
		[global::Cpp2ILInjected.Token(Token = "0x6001142")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0A040", Offset = "0x1E0A040", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		private void OnConnectionClosed(WebConnection connection)
		{
			throw null;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00005AF8 File Offset: 0x00003CF8
		[global::Cpp2ILInjected.Token(Token = "0x6001143")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0A05C", Offset = "0x1E0A05C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.AsyncManualResetEvent), Member = "WaitAsync", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Task<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "Start", MemberTypeParameters = new object[] { typeof(ServicePointScheduler.<WaitAsync>d__46) }, MemberParameters = new object[] { typeof(ref ServicePointScheduler.<WaitAsync>d__46) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout)
		{
			throw null;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00005AFB File Offset: 0x00003CFB
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6001144")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0A164", Offset = "0x1E0A164", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RunScheduler", ReturnType = typeof(Task))]
		private Task <Run>b__31_0()
		{
			throw null;
		}

		// Token: 0x04000A52 RID: 2642
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000D57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ServicePoint <ServicePoint>k__BackingField;

		// Token: 0x04000A53 RID: 2643
		[global::Cpp2ILInjected.Token(Token = "0x4000D58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int running;

		// Token: 0x04000A54 RID: 2644
		[global::Cpp2ILInjected.Token(Token = "0x4000D59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int maxIdleTime;

		// Token: 0x04000A55 RID: 2645
		[global::Cpp2ILInjected.Token(Token = "0x4000D5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ServicePointScheduler.AsyncManualResetEvent schedulerEvent;

		// Token: 0x04000A56 RID: 2646
		[global::Cpp2ILInjected.Token(Token = "0x4000D5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ServicePointScheduler.ConnectionGroup defaultGroup;

		// Token: 0x04000A57 RID: 2647
		[global::Cpp2ILInjected.Token(Token = "0x4000D5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups;

		// Token: 0x04000A58 RID: 2648
		[global::Cpp2ILInjected.Token(Token = "0x4000D5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations;

		// Token: 0x04000A59 RID: 2649
		[global::Cpp2ILInjected.Token(Token = "0x4000D5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections;

		// Token: 0x04000A5A RID: 2650
		[global::Cpp2ILInjected.Token(Token = "0x4000D5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int currentConnections;

		// Token: 0x04000A5B RID: 2651
		[global::Cpp2ILInjected.Token(Token = "0x4000D60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int connectionLimit;

		// Token: 0x04000A5C RID: 2652
		[global::Cpp2ILInjected.Token(Token = "0x4000D61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private DateTime idleSince;

		// Token: 0x04000A5D RID: 2653
		[global::Cpp2ILInjected.Token(Token = "0x4000D62")]
		private static int nextId;

		// Token: 0x04000A5E RID: 2654
		[global::Cpp2ILInjected.Token(Token = "0x4000D63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public readonly int ID;

		// Token: 0x04000A5F RID: 2655
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000D64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private readonly string <ME>k__BackingField;

		// Token: 0x02000427 RID: 1063
		[global::Cpp2ILInjected.Token(Token = "0x2000273")]
		private class ConnectionGroup
		{
			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x06001E47 RID: 7751 RVA: 0x00008354 File Offset: 0x00006554
			[global::Cpp2ILInjected.Token(Token = "0x170003F4")]
			public ServicePointScheduler Scheduler
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6001145")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E0A168", Offset = "0x1E0A168", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00008357 File Offset: 0x00006557
			[global::Cpp2ILInjected.Token(Token = "0x170003F5")]
			public string Name
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6001146")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E0A170", Offset = "0x1E0A170", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06001E49 RID: 7753 RVA: 0x0000835A File Offset: 0x0000655A
			[global::Cpp2ILInjected.Token(Token = "0x170003F6")]
			public bool IsDefault
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001147")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E0A178", Offset = "0x1E0A178", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001E4A RID: 7754 RVA: 0x0000835D File Offset: 0x0000655D
			[global::Cpp2ILInjected.Token(Token = "0x6001148")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E088F8", Offset = "0x1E088F8", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(ServicePoint),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "GetConnectionGroup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ServicePointScheduler.ConnectionGroup))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public ConnectionGroup(ServicePointScheduler scheduler, string name)
			{
				throw null;
			}

			// Token: 0x06001E4B RID: 7755 RVA: 0x00008360 File Offset: 0x00006560
			[global::Cpp2ILInjected.Token(Token = "0x6001149")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08E94", Offset = "0x1E08E94", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "Cleanup", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool IsEmpty()
			{
				throw null;
			}

			// Token: 0x06001E4C RID: 7756 RVA: 0x00008363 File Offset: 0x00006563
			[global::Cpp2ILInjected.Token(Token = "0x600114A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0956C", Offset = "0x1E0956C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new object[]
			{
				typeof(ServicePointScheduler.ConnectionGroup),
				typeof(WebOperation)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "CloseIdleConnection", MemberParameters = new object[]
			{
				typeof(ServicePointScheduler.ConnectionGroup),
				typeof(WebConnection)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void RemoveConnection(WebConnection connection)
			{
				throw null;
			}

			// Token: 0x06001E4D RID: 7757 RVA: 0x00008366 File Offset: 0x00006566
			[global::Cpp2ILInjected.Token(Token = "0x600114B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E096AC", Offset = "0x1E096AC", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new object[]
			{
				typeof(ServicePointScheduler.ConnectionGroup),
				typeof(WebOperation)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new object[] { typeof(ServicePointScheduler.ConnectionGroup) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<object>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(LinkedListNode<object>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void Cleanup()
			{
				throw null;
			}

			// Token: 0x06001E4E RID: 7758 RVA: 0x00008369 File Offset: 0x00006569
			[global::Cpp2ILInjected.Token(Token = "0x600114C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E09D80", Offset = "0x1E09D80", Length = "0x2B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "CloseConnectionGroup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Clear", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			public void Close()
			{
				throw null;
			}

			// Token: 0x06001E4F RID: 7759 RVA: 0x0000836C File Offset: 0x0000656C
			[global::Cpp2ILInjected.Token(Token = "0x600114D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E09D28", Offset = "0x1E09D28", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "SendRequest", MemberParameters = new object[]
			{
				typeof(WebOperation),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "AddLast", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void EnqueueOperation(WebOperation operation)
			{
				throw null;
			}

			// Token: 0x06001E50 RID: 7760 RVA: 0x0000836F File Offset: 0x0000656F
			[global::Cpp2ILInjected.Token(Token = "0x600114E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E09938", Offset = "0x1E09938", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new object[] { typeof(ServicePointScheduler.ConnectionGroup) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<object>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(LinkedListNode<object>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public WebOperation GetNextOperation()
			{
				throw null;
			}

			// Token: 0x06001E51 RID: 7761 RVA: 0x00008372 File Offset: 0x00006572
			[global::Cpp2ILInjected.Token(Token = "0x600114F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0A19C", Offset = "0x1E0A19C", Length = "0x2E0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "CreateOrReuseConnection", MemberParameters = new object[]
			{
				typeof(WebOperation),
				typeof(bool)
			}, ReturnType = typeof(ValueTuple<WebConnection, bool>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "CanReuseConnection", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new object[]
			{
				typeof(WebOperation),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			public WebConnection FindIdleConnection(WebOperation operation)
			{
				throw null;
			}

			// Token: 0x06001E52 RID: 7762 RVA: 0x00008375 File Offset: 0x00006575
			[global::Cpp2ILInjected.Token(Token = "0x6001150")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E09788", Offset = "0x1E09788", Length = "0x180")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new object[]
			{
				typeof(ServicePointScheduler.ConnectionGroup),
				typeof(WebOperation)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new object[] { typeof(ServicePointScheduler.ConnectionGroup) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.ConnectionGroup), Member = "FindIdleConnection", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(WebConnection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new object[]
			{
				typeof(WebOperation),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "AddFirst", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<object, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force)
			{
				throw null;
			}

			// Token: 0x0400128E RID: 4750
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000D65")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly ServicePointScheduler <Scheduler>k__BackingField;

			// Token: 0x0400128F RID: 4751
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000D66")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly string <Name>k__BackingField;

			// Token: 0x04001290 RID: 4752
			[global::Cpp2ILInjected.Token(Token = "0x4000D67")]
			private static int nextId;

			// Token: 0x04001291 RID: 4753
			[global::Cpp2ILInjected.Token(Token = "0x4000D68")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public readonly int ID;

			// Token: 0x04001292 RID: 4754
			[global::Cpp2ILInjected.Token(Token = "0x4000D69")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private LinkedList<WebConnection> connections;

			// Token: 0x04001293 RID: 4755
			[global::Cpp2ILInjected.Token(Token = "0x4000D6A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private LinkedList<WebOperation> queue;
		}

		// Token: 0x02000428 RID: 1064
		[global::Cpp2ILInjected.Token(Token = "0x2000274")]
		private class AsyncManualResetEvent
		{
			// Token: 0x06001E53 RID: 7763 RVA: 0x00008378 File Offset: 0x00006578
			[global::Cpp2ILInjected.Token(Token = "0x6001151")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0AA9C", Offset = "0x1E0AA9C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Task WaitAsync()
			{
				throw null;
			}

			// Token: 0x06001E54 RID: 7764 RVA: 0x0000837B File Offset: 0x0000657B
			[global::Cpp2ILInjected.Token(Token = "0x6001152")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0AAE0", Offset = "0x1E0AAE0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Wait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool WaitOne(int millisecondTimeout)
			{
				throw null;
			}

			// Token: 0x06001E55 RID: 7765 RVA: 0x0000837E File Offset: 0x0000657E
			[global::Cpp2ILInjected.Token(Token = "0x6001153")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0AB30", Offset = "0x1E0AB30", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "WaitAsync", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(int)
			}, ReturnType = typeof(Task<bool>))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Task<bool> WaitAsync(int millisecondTimeout)
			{
				throw null;
			}

			// Token: 0x06001E56 RID: 7766 RVA: 0x00008381 File Offset: 0x00006581
			[global::Cpp2ILInjected.Token(Token = "0x6001154")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08A1C", Offset = "0x1E08A1C", Length = "0x21C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler.AsyncManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "Run", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[]
			{
				"System.Func`2<Object, TResult>",
				typeof(object),
				typeof(CancellationToken),
				typeof(TaskCreationOptions),
				typeof(TaskScheduler)
			}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			public void Set()
			{
				throw null;
			}

			// Token: 0x06001E57 RID: 7767 RVA: 0x00008384 File Offset: 0x00006584
			[global::Cpp2ILInjected.Token(Token = "0x6001155")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E09080", Offset = "0x1E09080", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "RunSchedulerIteration", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x06001E58 RID: 7768 RVA: 0x00008387 File Offset: 0x00006587
			[global::Cpp2ILInjected.Token(Token = "0x6001156")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08858", Offset = "0x1E08858", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(ServicePoint),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler.AsyncManualResetEvent), Member = "Set", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public AsyncManualResetEvent(bool state)
			{
				throw null;
			}

			// Token: 0x04001294 RID: 4756
			[global::Cpp2ILInjected.Token(Token = "0x4000D6B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private TaskCompletionSource<bool> m_tcs;

			// Token: 0x020004BA RID: 1210
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000275")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x0600200A RID: 8202 RVA: 0x000087CB File Offset: 0x000069CB
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x6001157")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E0AB7C", Offset = "0x1E0AB7C", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x0600200B RID: 8203 RVA: 0x000087CE File Offset: 0x000069CE
				[global::Cpp2ILInjected.Token(Token = "0x6001158")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E0ABD8", Offset = "0x1E0ABD8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x0600200C RID: 8204 RVA: 0x000087D1 File Offset: 0x000069D1
				[global::Cpp2ILInjected.Token(Token = "0x6001159")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E0ABE0", Offset = "0x1E0ABE0", Length = "0x98")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskCompletionSource<>), Member = "TrySetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				internal bool <Set>b__4_0(object s)
				{
					throw null;
				}

				// Token: 0x04001442 RID: 5186
				[global::Cpp2ILInjected.Token(Token = "0x4000D6C")]
				public static readonly ServicePointScheduler.AsyncManualResetEvent.<>c <>9;

				// Token: 0x04001443 RID: 5187
				[global::Cpp2ILInjected.Token(Token = "0x4000D6D")]
				public static Func<object, bool> <>9__4_0;
			}
		}

		// Token: 0x02000429 RID: 1065
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000276")]
		[StructLayout(3)]
		private struct <RunScheduler>d__32 : IAsyncStateMachine
		{
			// Token: 0x06001E59 RID: 7769 RVA: 0x0000838A File Offset: 0x0000658A
			[global::Cpp2ILInjected.Token(Token = "0x600115A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0AC78", Offset = "0x1E0AC78", Length = "0x95C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromDays", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(TimeSpan)
			}, ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "Cleanup", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<>), Member = "CopyTo", MemberParameters = new object[]
			{
				"T[]",
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<ValueTuple<object, object, object>>), Member = "CopyTo", MemberParameters = new object[]
			{
				typeof(ValueTuple<object, object, object>[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Net.ServicePointScheduler.AsyncManualResetEvent", Member = "WaitAsync", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Task<bool>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Net.ServicePointScheduler.ConnectionGroup", Member = "IsEmpty", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<>), Member = "get_Task", ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "WhenAny", MemberParameters = new object[] { typeof(IEnumerable<Task>) }, ReturnType = typeof(Task<Task>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<bool>), Member = "get_Result", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<>), Member = "Remove", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new object[]
			{
				"System.Net.ServicePointScheduler.ConnectionGroup",
				typeof(WebOperation)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RunSchedulerIteration", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<ValueTuple<object, object, object>>), Member = "Remove", MemberParameters = new object[] { typeof(ValueTuple<object, object, object>) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Net.ServicePointScheduler.ConnectionGroup", Member = "RemoveConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "FinalCleanup", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ServicePointScheduler.<RunScheduler>d__32)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref ServicePointScheduler.<RunScheduler>d__32)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E5A RID: 7770 RVA: 0x0000838D File Offset: 0x0000658D
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600115B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0B5D4", Offset = "0x1E0B5D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001295 RID: 4757
			[global::Cpp2ILInjected.Token(Token = "0x4000D6E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001296 RID: 4758
			[global::Cpp2ILInjected.Token(Token = "0x4000D6F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001297 RID: 4759
			[global::Cpp2ILInjected.Token(Token = "0x4000D70")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ServicePointScheduler <>4__this;

			// Token: 0x04001298 RID: 4760
			[global::Cpp2ILInjected.Token(Token = "0x4000D71")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>[] <operationArray>5__2;

			// Token: 0x04001299 RID: 4761
			[global::Cpp2ILInjected.Token(Token = "0x4000D72")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>[] <idleArray>5__3;

			// Token: 0x0400129A RID: 4762
			[global::Cpp2ILInjected.Token(Token = "0x4000D73")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private List<Task> <taskList>5__4;

			// Token: 0x0400129B RID: 4763
			[global::Cpp2ILInjected.Token(Token = "0x4000D74")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private Task<bool> <schedulerTask>5__5;

			// Token: 0x0400129C RID: 4764
			[global::Cpp2ILInjected.Token(Token = "0x4000D75")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private bool <finalCleanup>5__6;

			// Token: 0x0400129D RID: 4765
			[global::Cpp2ILInjected.Token(Token = "0x4000D76")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200042A RID: 1066
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000277")]
		[StructLayout(3)]
		private struct <WaitAsync>d__46 : IAsyncStateMachine
		{
			// Token: 0x06001E5B RID: 7771 RVA: 0x00008390 File Offset: 0x00006590
			[global::Cpp2ILInjected.Token(Token = "0x600115C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0B5E0", Offset = "0x1E0B5E0", Length = "0x3F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "WhenAny", MemberParameters = new object[] { typeof(Task[]) }, ReturnType = typeof(Task<Task>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ServicePointScheduler.<WaitAsync>d__46)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref ServicePointScheduler.<WaitAsync>d__46)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "SetResult", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E5C RID: 7772 RVA: 0x00008393 File Offset: 0x00006593
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600115D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0B9D4", Offset = "0x1E0B9D4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400129E RID: 4766
			[global::Cpp2ILInjected.Token(Token = "0x4000D77")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400129F RID: 4767
			[global::Cpp2ILInjected.Token(Token = "0x4000D78")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x040012A0 RID: 4768
			[global::Cpp2ILInjected.Token(Token = "0x4000D79")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int millisecondTimeout;

			// Token: 0x040012A1 RID: 4769
			[global::Cpp2ILInjected.Token(Token = "0x4000D7A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Task workerTask;

			// Token: 0x040012A2 RID: 4770
			[global::Cpp2ILInjected.Token(Token = "0x4000D7B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private CancellationTokenSource <cts>5__2;

			// Token: 0x040012A3 RID: 4771
			[global::Cpp2ILInjected.Token(Token = "0x4000D7C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private Task <timeoutTask>5__3;

			// Token: 0x040012A4 RID: 4772
			[global::Cpp2ILInjected.Token(Token = "0x4000D7D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
