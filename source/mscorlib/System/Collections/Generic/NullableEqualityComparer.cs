using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000539 RID: 1337
	[global::Cpp2ILInjected.Token(Token = "0x2000657")]
	[global::System.Serializable]
	internal class NullableEqualityComparer<T> : EqualityComparer<T?> where T : struct, global::System.IEquatable<T>
	{
		// Token: 0x06002CFC RID: 11516 RVA: 0x0001C24D File Offset: 0x0001A44D
		[global::Cpp2ILInjected.Token(Token = "0x600318D")]
		public override bool Equals(T? x, T? y)
		{
			throw null;
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x0001C250 File Offset: 0x0001A450
		[global::Cpp2ILInjected.Token(Token = "0x600318E")]
		public override int GetHashCode(T? obj)
		{
			throw null;
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x0001C253 File Offset: 0x0001A453
		[global::Cpp2ILInjected.Token(Token = "0x600318F")]
		internal override int IndexOf(T?[] array, T? value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x0001C256 File Offset: 0x0001A456
		[global::Cpp2ILInjected.Token(Token = "0x6003190")]
		internal override int LastIndexOf(T?[] array, T? value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x0001C259 File Offset: 0x0001A459
		[global::Cpp2ILInjected.Token(Token = "0x6003191")]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x0001C25C File Offset: 0x0001A45C
		[global::Cpp2ILInjected.Token(Token = "0x6003192")]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x0001C25F File Offset: 0x0001A45F
		[global::Cpp2ILInjected.Token(Token = "0x6003193")]
		public NullableEqualityComparer()
		{
			throw null;
		}
	}
}
