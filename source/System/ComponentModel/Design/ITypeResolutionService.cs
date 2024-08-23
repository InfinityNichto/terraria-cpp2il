using System;
using System.Reflection;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	// Token: 0x02000300 RID: 768
	[global::Cpp2ILInjected.Token(Token = "0x2000413")]
	public interface ITypeResolutionService
	{
		// Token: 0x06001937 RID: 6455
		[global::Cpp2ILInjected.Token(Token = "0x6001C15")]
		Type GetType(string name);

		// Token: 0x06001938 RID: 6456
		[global::Cpp2ILInjected.Token(Token = "0x6001C16")]
		string GetPathOfAssembly(AssemblyName name);
	}
}
