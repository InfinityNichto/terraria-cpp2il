using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000061")]
	public interface IUpdateable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000465")]
		void Update(ulong updateTick, float deltaTime);
	}
}
