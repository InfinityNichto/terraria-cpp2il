using System;
using Cpp2ILInjected;

namespace System.ComponentModel.Design
{
	// Token: 0x020002FE RID: 766
	[global::Cpp2ILInjected.Token(Token = "0x2000411")]
	public interface IReferenceService
	{
		// Token: 0x06001931 RID: 6449
		[global::Cpp2ILInjected.Token(Token = "0x6001C0F")]
		object GetReference(string name);

		// Token: 0x06001932 RID: 6450
		[global::Cpp2ILInjected.Token(Token = "0x6001C10")]
		string GetName(object reference);

		// Token: 0x06001933 RID: 6451
		[global::Cpp2ILInjected.Token(Token = "0x6001C11")]
		object[] GetReferences(Type baseType);
	}
}
