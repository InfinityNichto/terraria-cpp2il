using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Buffers
{
	// Token: 0x02000546 RID: 1350
	[global::Cpp2ILInjected.Token(Token = "0x2000665")]
	public abstract class MemoryManager<T>
	{
		// Token: 0x06002D3B RID: 11579
		[global::Cpp2ILInjected.Token(Token = "0x60031CC")]
		public abstract global::System.Span<T> GetSpan();

		// Token: 0x06002D3C RID: 11580
		[global::Cpp2ILInjected.Token(Token = "0x60031CD")]
		public abstract MemoryHandle Pin(int elementIndex = 0);

		// Token: 0x06002D3D RID: 11581 RVA: 0x0001C2FB File Offset: 0x0001A4FB
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
