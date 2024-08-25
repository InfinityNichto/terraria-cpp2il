using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003CD")]
	public interface INotifyDataErrorInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x170005DF")]
		bool HasErrors
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019C6")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019C7")]
		IEnumerable GetErrors(string propertyName);

		[global::Cpp2ILInjected.Token(Token = "0x14000016")]
		event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
	}
}
