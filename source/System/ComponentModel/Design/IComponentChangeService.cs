using System;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	[global::Cpp2ILInjected.Token(Token = "0x200040C")]
	public interface IComponentChangeService
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C08")]
		void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

		[global::Cpp2ILInjected.Token(Token = "0x6001C09")]
		void OnComponentChanging(object component, MemberDescriptor member);
	}
}
