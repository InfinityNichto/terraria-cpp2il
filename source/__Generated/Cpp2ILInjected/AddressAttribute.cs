using System;

namespace Cpp2ILInjected
{
	// Token: 0x02000006 RID: 6
	public sealed class AddressAttribute : Attribute
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002056 File Offset: 0x00000256
		public AddressAttribute()
		{
			throw null;
		}

		// Token: 0x04000002 RID: 2
		public string RVA;

		// Token: 0x04000003 RID: 3
		public string Offset;

		// Token: 0x04000004 RID: 4
		public string Length;
	}
}
