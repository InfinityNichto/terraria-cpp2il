using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x200015C")]
	internal abstract class XmlValueConverter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B20")]
		public abstract bool ToBoolean(long value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B21")]
		public abstract bool ToBoolean(int value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B22")]
		public abstract bool ToBoolean(double value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B23")]
		public abstract bool ToBoolean(DateTime value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B24")]
		public abstract bool ToBoolean(string value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B25")]
		public abstract bool ToBoolean(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B26")]
		public abstract int ToInt32(bool value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B27")]
		public abstract int ToInt32(long value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B28")]
		public abstract int ToInt32(double value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B29")]
		public abstract int ToInt32(DateTime value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B2A")]
		public abstract int ToInt32(string value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B2B")]
		public abstract int ToInt32(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B2C")]
		public abstract long ToInt64(bool value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B2D")]
		public abstract long ToInt64(int value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B2E")]
		public abstract long ToInt64(double value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B2F")]
		public abstract long ToInt64(DateTime value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B30")]
		public abstract long ToInt64(string value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B31")]
		public abstract long ToInt64(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B32")]
		public abstract decimal ToDecimal(string value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B33")]
		public abstract decimal ToDecimal(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B34")]
		public abstract double ToDouble(bool value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B35")]
		public abstract double ToDouble(int value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B36")]
		public abstract double ToDouble(long value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B37")]
		public abstract double ToDouble(DateTime value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B38")]
		public abstract double ToDouble(string value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B39")]
		public abstract double ToDouble(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B3A")]
		public abstract float ToSingle(double value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B3B")]
		public abstract float ToSingle(string value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B3C")]
		public abstract float ToSingle(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B3D")]
		public abstract DateTime ToDateTime(bool value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B3E")]
		public abstract DateTime ToDateTime(int value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B3F")]
		public abstract DateTime ToDateTime(long value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B40")]
		public abstract DateTime ToDateTime(double value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B41")]
		public abstract DateTime ToDateTime(DateTimeOffset value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B42")]
		public abstract DateTime ToDateTime(string value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B43")]
		public abstract DateTime ToDateTime(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B44")]
		public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B45")]
		public abstract DateTimeOffset ToDateTimeOffset(string value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B46")]
		public abstract DateTimeOffset ToDateTimeOffset(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B47")]
		public abstract string ToString(bool value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B48")]
		public abstract string ToString(int value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B49")]
		public abstract string ToString(long value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B4A")]
		public abstract string ToString(decimal value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B4B")]
		public abstract string ToString(float value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B4C")]
		public abstract string ToString(double value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B4D")]
		public abstract string ToString(DateTime value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B4E")]
		public abstract string ToString(DateTimeOffset value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B4F")]
		public abstract string ToString(object value);

		[global::Cpp2ILInjected.Token(Token = "0x6000B50")]
		public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

		[global::Cpp2ILInjected.Token(Token = "0x6000B51")]
		public abstract object ChangeType(bool value, Type destinationType);

		[global::Cpp2ILInjected.Token(Token = "0x6000B52")]
		public abstract object ChangeType(int value, Type destinationType);

		[global::Cpp2ILInjected.Token(Token = "0x6000B53")]
		public abstract object ChangeType(long value, Type destinationType);

		[global::Cpp2ILInjected.Token(Token = "0x6000B54")]
		public abstract object ChangeType(decimal value, Type destinationType);

		[global::Cpp2ILInjected.Token(Token = "0x6000B55")]
		public abstract object ChangeType(double value, Type destinationType);

		[global::Cpp2ILInjected.Token(Token = "0x6000B56")]
		public abstract object ChangeType(DateTime value, Type destinationType);

		[global::Cpp2ILInjected.Token(Token = "0x6000B57")]
		public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

		[global::Cpp2ILInjected.Token(Token = "0x6000B58")]
		public abstract object ChangeType(object value, Type destinationType);

		[global::Cpp2ILInjected.Token(Token = "0x6000B59")]
		public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);

		[global::Cpp2ILInjected.Token(Token = "0x6000B5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF2CC", Offset = "0x1DCF2CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XmlValueConverter()
		{
			throw null;
		}
	}
}
