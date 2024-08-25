using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	public interface IArrayPool<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x600002D")]
		T[] Rent(int minimumLength);

		[global::Cpp2ILInjected.Token(Token = "0x600002E")]
		void Return(T[] array);
	}
}
