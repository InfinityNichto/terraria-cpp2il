using System;
using Cpp2ILInjected;

namespace System.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000291")]
	public interface IPermission : ISecurityEncodable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016BB")]
		void Demand();

		[global::Cpp2ILInjected.Token(Token = "0x60016BC")]
		bool IsSubsetOf(IPermission target);
	}
}
