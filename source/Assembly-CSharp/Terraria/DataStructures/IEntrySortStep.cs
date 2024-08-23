using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Terraria.DataStructures
{
	// Token: 0x0200042B RID: 1067
	[global::Cpp2ILInjected.Token(Token = "0x2000626")]
	public interface IEntrySortStep<T> : IComparer<T>
	{
		// Token: 0x060030D8 RID: 12504
		[global::Cpp2ILInjected.Token(Token = "0x60035F5")]
		string GetDisplayNameKey();
	}
}
