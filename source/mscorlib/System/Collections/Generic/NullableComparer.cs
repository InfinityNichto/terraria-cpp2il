using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000535 RID: 1333
	[global::Cpp2ILInjected.Token(Token = "0x2000653")]
	[global::System.Serializable]
	internal class NullableComparer<T> : Comparer<T?> where T : struct, global::System.IComparable<T>
	{
		// Token: 0x06002CE4 RID: 11492 RVA: 0x0001C20B File Offset: 0x0001A40B
		[global::Cpp2ILInjected.Token(Token = "0x6003175")]
		public override int Compare(T? x, T? y)
		{
			throw null;
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x0001C20E File Offset: 0x0001A40E
		[global::Cpp2ILInjected.Token(Token = "0x6003176")]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x0001C211 File Offset: 0x0001A411
		[global::Cpp2ILInjected.Token(Token = "0x6003177")]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x0001C214 File Offset: 0x0001A414
		[global::Cpp2ILInjected.Token(Token = "0x6003178")]
		public NullableComparer()
		{
			throw null;
		}
	}
}
