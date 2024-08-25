using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.Resources
{
	[global::Cpp2ILInjected.Token(Token = "0x20004A5")]
	public interface IResourceReader : global::System.Collections.IEnumerable, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60022C1")]
		void Close();

		[global::Cpp2ILInjected.Token(Token = "0x60022C2")]
		global::System.Collections.IDictionaryEnumerator GetEnumerator();
	}
}
