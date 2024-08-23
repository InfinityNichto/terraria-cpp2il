using System;
using System.Collections;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x020002CE RID: 718
	[global::Cpp2ILInjected.Token(Token = "0x20003CD")]
	public interface INotifyDataErrorInfo
	{
		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001764 RID: 5988
		[global::Cpp2ILInjected.Token(Token = "0x170005DF")]
		bool HasErrors
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019C6")]
			get;
		}

		// Token: 0x06001765 RID: 5989
		[global::Cpp2ILInjected.Token(Token = "0x60019C7")]
		IEnumerable GetErrors(string propertyName);

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06001766 RID: 5990
		// (remove) Token: 0x06001767 RID: 5991
		[global::Cpp2ILInjected.Token(Token = "0x14000016")]
		event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
	}
}
