using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036A RID: 874
	[global::Cpp2ILInjected.Token(Token = "0x2000412")]
	internal sealed class MessageEnd
	{
		// Token: 0x06001DE3 RID: 7651 RVA: 0x000198B0 File Offset: 0x00017AB0
		[global::Cpp2ILInjected.Token(Token = "0x6002021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E3E0", Offset = "0x1B5E3E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMessageEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MessageEnd()
		{
			throw null;
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x000198B3 File Offset: 0x00017AB3
		[global::Cpp2ILInjected.Token(Token = "0x6002022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E3E8", Offset = "0x1B5E3E8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x000198B6 File Offset: 0x00017AB6
		[global::Cpp2ILInjected.Token(Token = "0x6002023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E3FC", Offset = "0x1B5E3FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMessageEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x000198B9 File Offset: 0x00017AB9
		[global::Cpp2ILInjected.Token(Token = "0x6002024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E400", Offset = "0x1B5E400", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMessageEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000198BC File Offset: 0x00017ABC
		[global::Cpp2ILInjected.Token(Token = "0x6002025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E404", Offset = "0x1B5E404", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dump(global::System.IO.Stream sout)
		{
			throw null;
		}
	}
}
