using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting
{
	// Token: 0x020002A0 RID: 672
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200033E")]
	public interface IRemotingTypeInfo
	{
		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600199A RID: 6554
		[global::Cpp2ILInjected.Token(Token = "0x1700032A")]
		string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BBD")]
			get;
		}

		// Token: 0x0600199B RID: 6555
		[global::Cpp2ILInjected.Token(Token = "0x6001BBE")]
		bool CanCastTo(global::System.Type fromType, object o);
	}
}
