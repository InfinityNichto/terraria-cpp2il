using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x02000096 RID: 150
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000C6")]
	public interface IConvertible
	{
		// Token: 0x060006B5 RID: 1717
		[global::Cpp2ILInjected.Token(Token = "0x600075A")]
		global::System.TypeCode GetTypeCode();

		// Token: 0x060006B6 RID: 1718
		[global::Cpp2ILInjected.Token(Token = "0x600075B")]
		bool ToBoolean(global::System.IFormatProvider provider);

		// Token: 0x060006B7 RID: 1719
		[global::Cpp2ILInjected.Token(Token = "0x600075C")]
		char ToChar(global::System.IFormatProvider provider);

		// Token: 0x060006B8 RID: 1720
		[global::Cpp2ILInjected.Token(Token = "0x600075D")]
		sbyte ToSByte(global::System.IFormatProvider provider);

		// Token: 0x060006B9 RID: 1721
		[global::Cpp2ILInjected.Token(Token = "0x600075E")]
		byte ToByte(global::System.IFormatProvider provider);

		// Token: 0x060006BA RID: 1722
		[global::Cpp2ILInjected.Token(Token = "0x600075F")]
		short ToInt16(global::System.IFormatProvider provider);

		// Token: 0x060006BB RID: 1723
		[global::Cpp2ILInjected.Token(Token = "0x6000760")]
		ushort ToUInt16(global::System.IFormatProvider provider);

		// Token: 0x060006BC RID: 1724
		[global::Cpp2ILInjected.Token(Token = "0x6000761")]
		int ToInt32(global::System.IFormatProvider provider);

		// Token: 0x060006BD RID: 1725
		[global::Cpp2ILInjected.Token(Token = "0x6000762")]
		uint ToUInt32(global::System.IFormatProvider provider);

		// Token: 0x060006BE RID: 1726
		[global::Cpp2ILInjected.Token(Token = "0x6000763")]
		long ToInt64(global::System.IFormatProvider provider);

		// Token: 0x060006BF RID: 1727
		[global::Cpp2ILInjected.Token(Token = "0x6000764")]
		ulong ToUInt64(global::System.IFormatProvider provider);

		// Token: 0x060006C0 RID: 1728
		[global::Cpp2ILInjected.Token(Token = "0x6000765")]
		float ToSingle(global::System.IFormatProvider provider);

		// Token: 0x060006C1 RID: 1729
		[global::Cpp2ILInjected.Token(Token = "0x6000766")]
		double ToDouble(global::System.IFormatProvider provider);

		// Token: 0x060006C2 RID: 1730
		[global::Cpp2ILInjected.Token(Token = "0x6000767")]
		decimal ToDecimal(global::System.IFormatProvider provider);

		// Token: 0x060006C3 RID: 1731
		[global::Cpp2ILInjected.Token(Token = "0x6000768")]
		global::System.DateTime ToDateTime(global::System.IFormatProvider provider);

		// Token: 0x060006C4 RID: 1732
		[global::Cpp2ILInjected.Token(Token = "0x6000769")]
		string ToString(global::System.IFormatProvider provider);

		// Token: 0x060006C5 RID: 1733
		[global::Cpp2ILInjected.Token(Token = "0x600076A")]
		object ToType(global::System.Type conversionType, global::System.IFormatProvider provider);
	}
}
