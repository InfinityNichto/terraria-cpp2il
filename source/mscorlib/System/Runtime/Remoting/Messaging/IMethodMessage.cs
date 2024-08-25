using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003AF")]
	public interface IMethodMessage : IMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x170003B9")]
		int ArgCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E12")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003BA")]
		object[] Args
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E13")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003BB")]
		LogicalCallContext LogicalCallContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E14")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003BC")]
		global::System.Reflection.MethodBase MethodBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E15")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003BD")]
		string MethodName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E16")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003BE")]
		object MethodSignature
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E17")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003BF")]
		string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E18")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003C0")]
		string Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E19")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E1A")]
		object GetArg(int argNum);
	}
}
