using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x020002CB RID: 715
	[global::Cpp2ILInjected.Token(Token = "0x20003CA")]
	public interface IEditableObject
	{
		// Token: 0x0600175E RID: 5982
		[global::Cpp2ILInjected.Token(Token = "0x60019C0")]
		void BeginEdit();

		// Token: 0x0600175F RID: 5983
		[global::Cpp2ILInjected.Token(Token = "0x60019C1")]
		void EndEdit();

		// Token: 0x06001760 RID: 5984
		[global::Cpp2ILInjected.Token(Token = "0x60019C2")]
		void CancelEdit();
	}
}
