using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200033E")]
	public interface IRemotingTypeInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700032A")]
		string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BBD")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BBE")]
		bool CanCastTo(global::System.Type fromType, object o);
	}
}
