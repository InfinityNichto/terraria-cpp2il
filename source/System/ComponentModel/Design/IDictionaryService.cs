using System;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	[global::Cpp2ILInjected.Token(Token = "0x200040F")]
	public interface IDictionaryService
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C0C")]
		object GetValue(object key);

		[global::Cpp2ILInjected.Token(Token = "0x6001C0D")]
		void SetValue(object key, object value);
	}
}
