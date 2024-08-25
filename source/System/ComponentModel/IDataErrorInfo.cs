using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000381")]
	public interface IDataErrorInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700055C")]
		string this[string columnName]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001795")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700055D")]
		string Error
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001796")]
			get;
		}
	}
}
