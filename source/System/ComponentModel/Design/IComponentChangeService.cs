using System;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	// Token: 0x020002F9 RID: 761
	[global::Cpp2ILInjected.Token(Token = "0x200040C")]
	public interface IComponentChangeService
	{
		// Token: 0x0600192A RID: 6442
		[global::Cpp2ILInjected.Token(Token = "0x6001C08")]
		void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

		// Token: 0x0600192B RID: 6443
		[global::Cpp2ILInjected.Token(Token = "0x6001C09")]
		void OnComponentChanging(object component, MemberDescriptor member);
	}
}
