using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000012 RID: 18
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	public interface IArrayPool<T>
	{
		// Token: 0x0600002D RID: 45
		[global::Cpp2ILInjected.Token(Token = "0x600002D")]
		T[] Rent(int minimumLength);

		// Token: 0x0600002E RID: 46
		[global::Cpp2ILInjected.Token(Token = "0x600002E")]
		void Return(T[] array);
	}
}
