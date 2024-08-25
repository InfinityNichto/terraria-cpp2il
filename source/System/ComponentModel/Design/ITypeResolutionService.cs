using System;
using System.Reflection;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	[global::Cpp2ILInjected.Token(Token = "0x2000413")]
	public interface ITypeResolutionService
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C15")]
		Type GetType(string name);

		[global::Cpp2ILInjected.Token(Token = "0x6001C16")]
		string GetPathOfAssembly(AssemblyName name);
	}
}
