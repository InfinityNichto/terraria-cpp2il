using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200036D")]
	public interface IContextProperty
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000366")]
		string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D12")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D13")]
		void Freeze(Context newContext);

		[global::Cpp2ILInjected.Token(Token = "0x6001D14")]
		bool IsNewContextOK(Context newCtx);
	}
}
