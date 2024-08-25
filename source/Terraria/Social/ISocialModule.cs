using System;
using Cpp2ILInjected;

namespace Terraria.Social
{
	[global::Cpp2ILInjected.Token(Token = "0x200050E")]
	public interface ISocialModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003143")]
		void Initialize();

		[global::Cpp2ILInjected.Token(Token = "0x6003144")]
		void Shutdown();
	}
}
