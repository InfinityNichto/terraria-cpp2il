using System;
using Cpp2ILInjected;

namespace System
{
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000C6")]
	public interface IConvertible
	{
		[global::Cpp2ILInjected.Token(Token = "0x600075A")]
		global::System.TypeCode GetTypeCode();

		[global::Cpp2ILInjected.Token(Token = "0x600075B")]
		bool ToBoolean(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x600075C")]
		char ToChar(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x600075D")]
		sbyte ToSByte(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x600075E")]
		byte ToByte(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x600075F")]
		short ToInt16(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x6000760")]
		ushort ToUInt16(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x6000761")]
		int ToInt32(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x6000762")]
		uint ToUInt32(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x6000763")]
		long ToInt64(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x6000764")]
		ulong ToUInt64(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x6000765")]
		float ToSingle(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x6000766")]
		double ToDouble(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x6000767")]
		decimal ToDecimal(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x6000768")]
		global::System.DateTime ToDateTime(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x6000769")]
		string ToString(global::System.IFormatProvider provider);

		[global::Cpp2ILInjected.Token(Token = "0x600076A")]
		object ToType(global::System.Type conversionType, global::System.IFormatProvider provider);
	}
}
