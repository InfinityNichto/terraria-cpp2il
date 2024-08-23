using System;
using Cpp2ILInjected;

namespace System.Runtime.Serialization
{
	// Token: 0x0200031F RID: 799
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x20003C5")]
	public interface IFormatterConverter
	{
		// Token: 0x06001C85 RID: 7301
		[global::Cpp2ILInjected.Token(Token = "0x6001EBE")]
		object Convert(object value, global::System.Type type);

		// Token: 0x06001C86 RID: 7302
		[global::Cpp2ILInjected.Token(Token = "0x6001EBF")]
		bool ToBoolean(object value);

		// Token: 0x06001C87 RID: 7303
		[global::Cpp2ILInjected.Token(Token = "0x6001EC0")]
		int ToInt32(object value);

		// Token: 0x06001C88 RID: 7304
		[global::Cpp2ILInjected.Token(Token = "0x6001EC1")]
		long ToInt64(object value);

		// Token: 0x06001C89 RID: 7305
		[global::Cpp2ILInjected.Token(Token = "0x6001EC2")]
		float ToSingle(object value);

		// Token: 0x06001C8A RID: 7306
		[global::Cpp2ILInjected.Token(Token = "0x6001EC3")]
		string ToString(object value);
	}
}
