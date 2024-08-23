using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000184 RID: 388
	[global::System.Runtime.CompilerServices.ReflectionBlocked]
	[global::Cpp2ILInjected.Token(Token = "0x20001DC")]
	public struct LockHolder : global::System.IDisposable
	{
		// Token: 0x06000FFD RID: 4093 RVA: 0x0001724C File Offset: 0x0001544C
		[global::Cpp2ILInjected.Token(Token = "0x600113B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97F24", Offset = "0x1C97F24", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public static LockHolder Hold(Lock l)
		{
			throw null;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0001724F File Offset: 0x0001544F
		[global::Cpp2ILInjected.Token(Token = "0x600113C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97F48", Offset = "0x1C97F48", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04000744 RID: 1860
		[global::Cpp2ILInjected.Token(Token = "0x400094B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Lock _lock;
	}
}
