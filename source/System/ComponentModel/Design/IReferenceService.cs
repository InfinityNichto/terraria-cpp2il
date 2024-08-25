using System;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	[global::Cpp2ILInjected.Token(Token = "0x2000411")]
	public interface IReferenceService
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C0F")]
		object GetReference(string name);

		[global::Cpp2ILInjected.Token(Token = "0x6001C10")]
		string GetName(object reference);

		[global::Cpp2ILInjected.Token(Token = "0x6001C11")]
		object[] GetReferences(Type baseType);
	}
}
