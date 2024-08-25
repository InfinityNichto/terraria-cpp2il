using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003CA")]
	public interface IEditableObject
	{
		[global::Cpp2ILInjected.Token(Token = "0x60019C0")]
		void BeginEdit();

		[global::Cpp2ILInjected.Token(Token = "0x60019C1")]
		void EndEdit();

		[global::Cpp2ILInjected.Token(Token = "0x60019C2")]
		void CancelEdit();
	}
}
