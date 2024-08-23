using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Interop;

namespace System.Threading
{
	// Token: 0x02000191 RID: 401
	[global::Cpp2ILInjected.Token(Token = "0x20001F3")]
	internal class OSSpecificSynchronizationContext : SynchronizationContext
	{
		// Token: 0x0600107F RID: 4223 RVA: 0x000173B7 File Offset: 0x000155B7
		[global::Cpp2ILInjected.Token(Token = "0x60011D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C788", Offset = "0x1C9C788", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private OSSpecificSynchronizationContext(object osContext)
		{
			throw null;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x000173BA File Offset: 0x000155BA
		[global::Cpp2ILInjected.Token(Token = "0x60011D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C47C", Offset = "0x1C9C47C", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >.CreateValueCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = "GetValue", MemberParameters = new object[] { "TKey", "CreateValueCallback<TKey, TValue>" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static OSSpecificSynchronizationContext Get()
		{
			throw null;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x000173BD File Offset: 0x000155BD
		[global::Cpp2ILInjected.Token(Token = "0x60011D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C7B4", Offset = "0x1C9C7B4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override SynchronizationContext CreateCopy()
		{
			throw null;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000173C0 File Offset: 0x000155C0
		[global::Cpp2ILInjected.Token(Token = "0x60011D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C814", Offset = "0x1C9C814", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Send(SendOrPostCallback d, object state)
		{
			throw null;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x000173C3 File Offset: 0x000155C3
		[global::Cpp2ILInjected.Token(Token = "0x60011D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C84C", Offset = "0x1C9C84C", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OSSpecificSynchronizationContext.InvocationEntryDelegate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new object[] { "TDelegate" }, MemberParameters = new object[] { "TDelegate" }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Alloc", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Runtime.InteropServices.GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "ToIntPtr", MemberParameters = new object[] { typeof(global::System.Runtime.InteropServices.GCHandle) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Post(SendOrPostCallback d, object state)
		{
			throw null;
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x000173C6 File Offset: 0x000155C6
		[Mono.Interop.MonoPInvokeCallback(typeof(OSSpecificSynchronizationContext.InvocationEntryDelegate))]
		[global::Cpp2ILInjected.Token(Token = "0x60011D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C630", Offset = "0x1C9C630", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "FromIntPtr", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(global::System.Runtime.InteropServices.GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "get_Target", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "ReportUnhandledException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void InvocationEntry(global::System.IntPtr arg)
		{
			throw null;
		}

		// Token: 0x06001085 RID: 4229
		[global::Cpp2ILInjected.Token(Token = "0x60011D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C7B0", Offset = "0x1C9C7B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern object GetOSContext();

		// Token: 0x06001086 RID: 4230
		[global::Cpp2ILInjected.Token(Token = "0x60011D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9CA90", Offset = "0x1C9CA90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void PostInternal(object osSynchronizationContext, global::System.IntPtr callback, global::System.IntPtr arg);

		// Token: 0x06001087 RID: 4231 RVA: 0x000173C9 File Offset: 0x000155C9
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60011D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9CAA8", Offset = "0x1C9CAA8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static OSSpecificSynchronizationContext()
		{
			throw null;
		}

		// Token: 0x04000770 RID: 1904
		[global::Cpp2ILInjected.Token(Token = "0x4000996")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object m_OSSynchronizationContext;

		// Token: 0x04000771 RID: 1905
		[global::Cpp2ILInjected.Token(Token = "0x4000997")]
		private static readonly global::System.Runtime.CompilerServices.ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache;

		// Token: 0x020005AF RID: 1455
		// (Invoke) Token: 0x06004030 RID: 16432
		[global::Cpp2ILInjected.Token(Token = "0x20001F4")]
		private delegate void InvocationEntryDelegate(global::System.IntPtr arg);

		// Token: 0x020005B0 RID: 1456
		[global::Cpp2ILInjected.Token(Token = "0x20001F5")]
		private class InvocationContext
		{
			// Token: 0x06004031 RID: 16433 RVA: 0x0001FB44 File Offset: 0x0001DD44
			[global::Cpp2ILInjected.Token(Token = "0x60011DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9CA64", Offset = "0x1C9CA64", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public InvocationContext(SendOrPostCallback d, object state)
			{
				throw null;
			}

			// Token: 0x06004032 RID: 16434 RVA: 0x0001FB47 File Offset: 0x0001DD47
			[global::Cpp2ILInjected.Token(Token = "0x60011DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9CA94", Offset = "0x1C9CA94", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Invoke()
			{
				throw null;
			}

			// Token: 0x040018B0 RID: 6320
			[global::Cpp2ILInjected.Token(Token = "0x4000998")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private SendOrPostCallback m_Delegate;

			// Token: 0x040018B1 RID: 6321
			[global::Cpp2ILInjected.Token(Token = "0x4000999")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object m_State;
		}

		// Token: 0x020005B1 RID: 1457
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20001F6")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06004033 RID: 16435 RVA: 0x0001FB4A File Offset: 0x0001DD4A
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60011DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9CB48", Offset = "0x1C9CB48", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004034 RID: 16436 RVA: 0x0001FB4D File Offset: 0x0001DD4D
			[global::Cpp2ILInjected.Token(Token = "0x60011DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9CBA4", Offset = "0x1C9CBA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004035 RID: 16437 RVA: 0x0001FB50 File Offset: 0x0001DD50
			[global::Cpp2ILInjected.Token(Token = "0x60011E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9CBAC", Offset = "0x1C9CBAC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext)
			{
				throw null;
			}

			// Token: 0x040018B2 RID: 6322
			[global::Cpp2ILInjected.Token(Token = "0x400099A")]
			public static readonly OSSpecificSynchronizationContext.<>c <>9;

			// Token: 0x040018B3 RID: 6323
			[global::Cpp2ILInjected.Token(Token = "0x400099B")]
			public static global::System.Runtime.CompilerServices.ConditionalWeakTable<object, OSSpecificSynchronizationContext>.CreateValueCallback <>9__3_0;
		}
	}
}
