using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000039")]
	public enum TypeNameHandling
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000119")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400011A")]
		Objects = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400011B")]
		Arrays = 2,
		[global::Cpp2ILInjected.Token(Token = "0x400011C")]
		All = 3,
		[global::Cpp2ILInjected.Token(Token = "0x400011D")]
		Auto = 4
	}
}
