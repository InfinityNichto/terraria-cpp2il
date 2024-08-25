using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public interface INotifyCollectionChanged
	{
		[global::Cpp2ILInjected.Token(Token = "0x14000001")]
		event NotifyCollectionChangedEventHandler CollectionChanged;
	}
}
