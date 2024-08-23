using System;
using Cpp2ILInjected;

namespace System.Security
{
	// Token: 0x020001FF RID: 511
	[global::Cpp2ILInjected.Token(Token = "0x2000291")]
	public interface IPermission : ISecurityEncodable
	{
		// Token: 0x060014BC RID: 5308
		[global::Cpp2ILInjected.Token(Token = "0x60016BB")]
		void Demand();

		// Token: 0x060014BD RID: 5309
		[global::Cpp2ILInjected.Token(Token = "0x60016BC")]
		bool IsSubsetOf(IPermission target);
	}
}
