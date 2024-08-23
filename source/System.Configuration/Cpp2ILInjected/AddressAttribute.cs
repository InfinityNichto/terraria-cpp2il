using System;

namespace Cpp2ILInjected
{
	// Token: 0x02000011 RID: 17
	public sealed class AddressAttribute : Attribute
	{
		// Token: 0x06000025 RID: 37 RVA: 0x000020B0 File Offset: 0x000002B0
		public AddressAttribute()
		{
			throw null;
		}

		// Token: 0x0400000B RID: 11
		public string RVA;

		// Token: 0x0400000C RID: 12
		public string Offset;

		// Token: 0x0400000D RID: 13
		public string Length;
	}
}
