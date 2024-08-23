using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x02000293 RID: 659
	[global::Cpp2ILInjected.Token(Token = "0x200038A")]
	public interface ITypedList
	{
		// Token: 0x0600155C RID: 5468
		[global::Cpp2ILInjected.Token(Token = "0x60017A7")]
		string GetListName(PropertyDescriptor[] listAccessors);

		// Token: 0x0600155D RID: 5469
		[global::Cpp2ILInjected.Token(Token = "0x60017A8")]
		PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors);
	}
}
