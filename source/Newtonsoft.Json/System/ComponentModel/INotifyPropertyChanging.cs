using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public interface INotifyPropertyChanging
	{
		[global::Cpp2ILInjected.Token(Token = "0x14000002")]
		event PropertyChangingEventHandler PropertyChanging;
	}
}
