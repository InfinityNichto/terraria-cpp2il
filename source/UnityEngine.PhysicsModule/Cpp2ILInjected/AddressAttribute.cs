using System;

namespace Cpp2ILInjected
{
	// Token: 0x02000006 RID: 6
	public sealed class AddressAttribute : Attribute
	{
		// Token: 0x06000006 RID: 6 RVA: 0x0000205F File Offset: 0x0000025F
		public AddressAttribute()
		{
			throw null;
		}

		// Token: 0x04000008 RID: 8
		public string RVA;

		// Token: 0x04000009 RID: 9
		public string Offset;

		// Token: 0x0400000A RID: 10
		public string Length;
	}
}
