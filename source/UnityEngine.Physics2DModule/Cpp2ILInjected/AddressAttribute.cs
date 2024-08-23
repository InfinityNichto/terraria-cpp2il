using System;

namespace Cpp2ILInjected
{
	// Token: 0x02000007 RID: 7
	public sealed class AddressAttribute : Attribute
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002062 File Offset: 0x00000262
		public AddressAttribute()
		{
			throw null;
		}

		// Token: 0x04000009 RID: 9
		public string RVA;

		// Token: 0x0400000A RID: 10
		public string Offset;

		// Token: 0x0400000B RID: 11
		public string Length;
	}
}
