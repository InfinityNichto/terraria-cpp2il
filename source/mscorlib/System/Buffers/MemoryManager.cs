using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Buffers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000665")]
	public abstract class MemoryManager<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031CC")]
		public abstract global::System.Span<T> GetSpan();

		[global::Cpp2ILInjected.Token(Token = "0x60031CD")]
		public abstract MemoryHandle Pin(int elementIndex = 0);

		[global::Cpp2ILInjected.Token(Token = "0x60031CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9E24", Offset = "0x17C9E24", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected internal virtual bool TryGetArray(out global::System.ArraySegment<T> segment)
		{
			throw null;
		}
	}
}
