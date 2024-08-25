using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Interop;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001F3")]
	internal class OSSpecificSynchronizationContext : SynchronizationContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C788", Offset = "0x1C9C788", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private OSSpecificSynchronizationContext(object osContext)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60011D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C7B4", Offset = "0x1C9C7B4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override SynchronizationContext CreateCopy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C814", Offset = "0x1C9C814", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Send(SendOrPostCallback d, object state)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60011D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C7B0", Offset = "0x1C9C7B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern object GetOSContext();

		[global::Cpp2ILInjected.Token(Token = "0x60011D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9CA90", Offset = "0x1C9CA90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void PostInternal(object osSynchronizationContext, global::System.IntPtr callback, global::System.IntPtr arg);

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

		[global::Cpp2ILInjected.Token(Token = "0x4000996")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object m_OSSynchronizationContext;

		[global::Cpp2ILInjected.Token(Token = "0x4000997")]
		private static readonly global::System.Runtime.CompilerServices.ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache;

		[global::Cpp2ILInjected.Token(Token = "0x20001F4")]
		private delegate void InvocationEntryDelegate(global::System.IntPtr arg);

		[global::Cpp2ILInjected.Token(Token = "0x20001F5")]
		private class InvocationContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9CA64", Offset = "0x1C9CA64", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public InvocationContext(SendOrPostCallback d, object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60011DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9CA94", Offset = "0x1C9CA94", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Invoke()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000998")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private SendOrPostCallback m_Delegate;

			[global::Cpp2ILInjected.Token(Token = "0x4000999")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object m_State;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20001F6")]
		[global::System.Serializable]
		private sealed class <>c
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60011DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9CBA4", Offset = "0x1C9CBA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60011E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9CBAC", Offset = "0x1C9CBAC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400099A")]
			public static readonly OSSpecificSynchronizationContext.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x400099B")]
			public static global::System.Runtime.CompilerServices.ConditionalWeakTable<object, OSSpecificSynchronizationContext>.CreateValueCallback <>9__3_0;
		}
	}
}
