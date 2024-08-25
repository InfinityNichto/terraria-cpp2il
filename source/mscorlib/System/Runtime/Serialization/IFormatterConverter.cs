using System;
using Cpp2ILInjected;

namespace System.Runtime.Serialization
{
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x20003C5")]
	public interface IFormatterConverter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001EBE")]
		object Convert(object value, global::System.Type type);

		[global::Cpp2ILInjected.Token(Token = "0x6001EBF")]
		bool ToBoolean(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6001EC0")]
		int ToInt32(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6001EC1")]
		long ToInt64(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6001EC2")]
		float ToSingle(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6001EC3")]
		string ToString(object value);
	}
}
