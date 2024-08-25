using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003CB")]
	public interface IRevertibleChangeTracking : IChangeTracking
	{
		[global::Cpp2ILInjected.Token(Token = "0x60019C3")]
		void RejectChanges();
	}
}
