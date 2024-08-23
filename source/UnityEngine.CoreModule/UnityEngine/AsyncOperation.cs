using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000096 RID: 150
	[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
	[NativeHeader("Runtime/Misc/AsyncOperation.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000A4")]
	[StructLayout(0)]
	public class AsyncOperation : YieldInstruction
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x00002623 File Offset: 0x00000823
		[global::Cpp2ILInjected.Token(Token = "0x6000302")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B46C", Offset = "0x1F7B46C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002626 File Offset: 0x00000826
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000303")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B564", Offset = "0x1F7B564", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void InvokeCompletionEvent()
		{
			throw null;
		}

		// Token: 0x060002F6 RID: 758
		[NativeMethod(IsThreadSafe = true)]
		[StaticAccessor("AsyncOperationBindings", StaticAccessorType.DoubleColon)]
		[global::Cpp2ILInjected.Token(Token = "0x6000304")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B528", Offset = "0x1F7B528", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void InternalDestroy(IntPtr ptr);

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002F7 RID: 759
		[global::Cpp2ILInjected.Token(Token = "0x170000AD")]
		public extern bool isDone
		{
			[NativeMethod("IsDone")]
			[global::Cpp2ILInjected.Token(Token = "0x6000305")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7B594", Offset = "0x1F7B594", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ThreadContentRequest", Member = "UpdateLoad", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002629 File Offset: 0x00000829
		[global::Cpp2ILInjected.Token(Token = "0x6000306")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B5D0", Offset = "0x1F7B5D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceRequest), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AsyncOperation()
		{
			throw null;
		}

		// Token: 0x04000331 RID: 817
		[global::Cpp2ILInjected.Token(Token = "0x4000361")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		// Token: 0x04000332 RID: 818
		[global::Cpp2ILInjected.Token(Token = "0x4000362")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Action<AsyncOperation> m_completeCallback;
	}
}
