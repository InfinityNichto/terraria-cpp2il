using System;
using System.Buffers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000084 RID: 132
	[global::Cpp2ILInjected.Token(Token = "0x20000AB")]
	internal sealed class Gen2GcCallback : global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x000156D1 File Offset: 0x000138D1
		[global::Cpp2ILInjected.Token(Token = "0x600068B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1F138", Offset = "0x1C1F138", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = ".ctor", ReturnType = typeof(void))]
		private Gen2GcCallback()
		{
			throw null;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000156D4 File Offset: 0x000138D4
		[global::Cpp2ILInjected.Token(Token = "0x600068C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1F140", Offset = "0x1C1F140", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.TlsOverPerCoreLockedStacksArrayPool<>), Member = "Return", MemberParameters = new object[]
		{
			"T[]",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.InteropServices.GCHandleType)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Register(global::System.Func<object, bool> callback, object targetObj)
		{
			throw null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000156D7 File Offset: 0x000138D7
		[global::Cpp2ILInjected.Token(Token = "0x600068D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1F1B8", Offset = "0x1C1F1B8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.InteropServices.GCHandleType)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.GCHandle))]
		private void Setup(global::System.Func<object, bool> callback, object targetObj)
		{
			throw null;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000156DA File Offset: 0x000138DA
		[global::Cpp2ILInjected.Token(Token = "0x600068E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1F1E0", Offset = "0x1C1F1E0", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "get_Target", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_HasShutdownStarted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "ReRegisterForFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x04000186 RID: 390
		[global::Cpp2ILInjected.Token(Token = "0x400026D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Func<object, bool> _callback;

		// Token: 0x04000187 RID: 391
		[global::Cpp2ILInjected.Token(Token = "0x400026E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Runtime.InteropServices.GCHandle _weakTargetObj;
	}
}
