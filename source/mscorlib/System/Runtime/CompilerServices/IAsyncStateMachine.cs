using System;
using Cpp2ILInjected;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x2000473")]
	public interface IAsyncStateMachine
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002218")]
		void MoveNext();

		[global::Cpp2ILInjected.Token(Token = "0x6002219")]
		void SetStateMachine(IAsyncStateMachine stateMachine);
	}
}
