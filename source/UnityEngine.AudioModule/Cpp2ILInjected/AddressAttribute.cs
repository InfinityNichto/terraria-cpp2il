using System;

namespace Cpp2ILInjected
{
	// Token: 0x0200000F RID: 15
	public sealed class AddressAttribute : Attribute
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002080 File Offset: 0x00000280
		public AddressAttribute()
		{
			throw null;
		}

		// Token: 0x0400000C RID: 12
		public string RVA;

		// Token: 0x0400000D RID: 13
		public string Offset;

		// Token: 0x0400000E RID: 14
		public string Length;
	}
}
