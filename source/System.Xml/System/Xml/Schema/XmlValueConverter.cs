using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000128 RID: 296
	[global::Cpp2ILInjected.Token(Token = "0x200015C")]
	internal abstract class XmlValueConverter
	{
		// Token: 0x06000A85 RID: 2693
		[global::Cpp2ILInjected.Token(Token = "0x6000B20")]
		public abstract bool ToBoolean(long value);

		// Token: 0x06000A86 RID: 2694
		[global::Cpp2ILInjected.Token(Token = "0x6000B21")]
		public abstract bool ToBoolean(int value);

		// Token: 0x06000A87 RID: 2695
		[global::Cpp2ILInjected.Token(Token = "0x6000B22")]
		public abstract bool ToBoolean(double value);

		// Token: 0x06000A88 RID: 2696
		[global::Cpp2ILInjected.Token(Token = "0x6000B23")]
		public abstract bool ToBoolean(DateTime value);

		// Token: 0x06000A89 RID: 2697
		[global::Cpp2ILInjected.Token(Token = "0x6000B24")]
		public abstract bool ToBoolean(string value);

		// Token: 0x06000A8A RID: 2698
		[global::Cpp2ILInjected.Token(Token = "0x6000B25")]
		public abstract bool ToBoolean(object value);

		// Token: 0x06000A8B RID: 2699
		[global::Cpp2ILInjected.Token(Token = "0x6000B26")]
		public abstract int ToInt32(bool value);

		// Token: 0x06000A8C RID: 2700
		[global::Cpp2ILInjected.Token(Token = "0x6000B27")]
		public abstract int ToInt32(long value);

		// Token: 0x06000A8D RID: 2701
		[global::Cpp2ILInjected.Token(Token = "0x6000B28")]
		public abstract int ToInt32(double value);

		// Token: 0x06000A8E RID: 2702
		[global::Cpp2ILInjected.Token(Token = "0x6000B29")]
		public abstract int ToInt32(DateTime value);

		// Token: 0x06000A8F RID: 2703
		[global::Cpp2ILInjected.Token(Token = "0x6000B2A")]
		public abstract int ToInt32(string value);

		// Token: 0x06000A90 RID: 2704
		[global::Cpp2ILInjected.Token(Token = "0x6000B2B")]
		public abstract int ToInt32(object value);

		// Token: 0x06000A91 RID: 2705
		[global::Cpp2ILInjected.Token(Token = "0x6000B2C")]
		public abstract long ToInt64(bool value);

		// Token: 0x06000A92 RID: 2706
		[global::Cpp2ILInjected.Token(Token = "0x6000B2D")]
		public abstract long ToInt64(int value);

		// Token: 0x06000A93 RID: 2707
		[global::Cpp2ILInjected.Token(Token = "0x6000B2E")]
		public abstract long ToInt64(double value);

		// Token: 0x06000A94 RID: 2708
		[global::Cpp2ILInjected.Token(Token = "0x6000B2F")]
		public abstract long ToInt64(DateTime value);

		// Token: 0x06000A95 RID: 2709
		[global::Cpp2ILInjected.Token(Token = "0x6000B30")]
		public abstract long ToInt64(string value);

		// Token: 0x06000A96 RID: 2710
		[global::Cpp2ILInjected.Token(Token = "0x6000B31")]
		public abstract long ToInt64(object value);

		// Token: 0x06000A97 RID: 2711
		[global::Cpp2ILInjected.Token(Token = "0x6000B32")]
		public abstract decimal ToDecimal(string value);

		// Token: 0x06000A98 RID: 2712
		[global::Cpp2ILInjected.Token(Token = "0x6000B33")]
		public abstract decimal ToDecimal(object value);

		// Token: 0x06000A99 RID: 2713
		[global::Cpp2ILInjected.Token(Token = "0x6000B34")]
		public abstract double ToDouble(bool value);

		// Token: 0x06000A9A RID: 2714
		[global::Cpp2ILInjected.Token(Token = "0x6000B35")]
		public abstract double ToDouble(int value);

		// Token: 0x06000A9B RID: 2715
		[global::Cpp2ILInjected.Token(Token = "0x6000B36")]
		public abstract double ToDouble(long value);

		// Token: 0x06000A9C RID: 2716
		[global::Cpp2ILInjected.Token(Token = "0x6000B37")]
		public abstract double ToDouble(DateTime value);

		// Token: 0x06000A9D RID: 2717
		[global::Cpp2ILInjected.Token(Token = "0x6000B38")]
		public abstract double ToDouble(string value);

		// Token: 0x06000A9E RID: 2718
		[global::Cpp2ILInjected.Token(Token = "0x6000B39")]
		public abstract double ToDouble(object value);

		// Token: 0x06000A9F RID: 2719
		[global::Cpp2ILInjected.Token(Token = "0x6000B3A")]
		public abstract float ToSingle(double value);

		// Token: 0x06000AA0 RID: 2720
		[global::Cpp2ILInjected.Token(Token = "0x6000B3B")]
		public abstract float ToSingle(string value);

		// Token: 0x06000AA1 RID: 2721
		[global::Cpp2ILInjected.Token(Token = "0x6000B3C")]
		public abstract float ToSingle(object value);

		// Token: 0x06000AA2 RID: 2722
		[global::Cpp2ILInjected.Token(Token = "0x6000B3D")]
		public abstract DateTime ToDateTime(bool value);

		// Token: 0x06000AA3 RID: 2723
		[global::Cpp2ILInjected.Token(Token = "0x6000B3E")]
		public abstract DateTime ToDateTime(int value);

		// Token: 0x06000AA4 RID: 2724
		[global::Cpp2ILInjected.Token(Token = "0x6000B3F")]
		public abstract DateTime ToDateTime(long value);

		// Token: 0x06000AA5 RID: 2725
		[global::Cpp2ILInjected.Token(Token = "0x6000B40")]
		public abstract DateTime ToDateTime(double value);

		// Token: 0x06000AA6 RID: 2726
		[global::Cpp2ILInjected.Token(Token = "0x6000B41")]
		public abstract DateTime ToDateTime(DateTimeOffset value);

		// Token: 0x06000AA7 RID: 2727
		[global::Cpp2ILInjected.Token(Token = "0x6000B42")]
		public abstract DateTime ToDateTime(string value);

		// Token: 0x06000AA8 RID: 2728
		[global::Cpp2ILInjected.Token(Token = "0x6000B43")]
		public abstract DateTime ToDateTime(object value);

		// Token: 0x06000AA9 RID: 2729
		[global::Cpp2ILInjected.Token(Token = "0x6000B44")]
		public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

		// Token: 0x06000AAA RID: 2730
		[global::Cpp2ILInjected.Token(Token = "0x6000B45")]
		public abstract DateTimeOffset ToDateTimeOffset(string value);

		// Token: 0x06000AAB RID: 2731
		[global::Cpp2ILInjected.Token(Token = "0x6000B46")]
		public abstract DateTimeOffset ToDateTimeOffset(object value);

		// Token: 0x06000AAC RID: 2732
		[global::Cpp2ILInjected.Token(Token = "0x6000B47")]
		public abstract string ToString(bool value);

		// Token: 0x06000AAD RID: 2733
		[global::Cpp2ILInjected.Token(Token = "0x6000B48")]
		public abstract string ToString(int value);

		// Token: 0x06000AAE RID: 2734
		[global::Cpp2ILInjected.Token(Token = "0x6000B49")]
		public abstract string ToString(long value);

		// Token: 0x06000AAF RID: 2735
		[global::Cpp2ILInjected.Token(Token = "0x6000B4A")]
		public abstract string ToString(decimal value);

		// Token: 0x06000AB0 RID: 2736
		[global::Cpp2ILInjected.Token(Token = "0x6000B4B")]
		public abstract string ToString(float value);

		// Token: 0x06000AB1 RID: 2737
		[global::Cpp2ILInjected.Token(Token = "0x6000B4C")]
		public abstract string ToString(double value);

		// Token: 0x06000AB2 RID: 2738
		[global::Cpp2ILInjected.Token(Token = "0x6000B4D")]
		public abstract string ToString(DateTime value);

		// Token: 0x06000AB3 RID: 2739
		[global::Cpp2ILInjected.Token(Token = "0x6000B4E")]
		public abstract string ToString(DateTimeOffset value);

		// Token: 0x06000AB4 RID: 2740
		[global::Cpp2ILInjected.Token(Token = "0x6000B4F")]
		public abstract string ToString(object value);

		// Token: 0x06000AB5 RID: 2741
		[global::Cpp2ILInjected.Token(Token = "0x6000B50")]
		public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

		// Token: 0x06000AB6 RID: 2742
		[global::Cpp2ILInjected.Token(Token = "0x6000B51")]
		public abstract object ChangeType(bool value, Type destinationType);

		// Token: 0x06000AB7 RID: 2743
		[global::Cpp2ILInjected.Token(Token = "0x6000B52")]
		public abstract object ChangeType(int value, Type destinationType);

		// Token: 0x06000AB8 RID: 2744
		[global::Cpp2ILInjected.Token(Token = "0x6000B53")]
		public abstract object ChangeType(long value, Type destinationType);

		// Token: 0x06000AB9 RID: 2745
		[global::Cpp2ILInjected.Token(Token = "0x6000B54")]
		public abstract object ChangeType(decimal value, Type destinationType);

		// Token: 0x06000ABA RID: 2746
		[global::Cpp2ILInjected.Token(Token = "0x6000B55")]
		public abstract object ChangeType(double value, Type destinationType);

		// Token: 0x06000ABB RID: 2747
		[global::Cpp2ILInjected.Token(Token = "0x6000B56")]
		public abstract object ChangeType(DateTime value, Type destinationType);

		// Token: 0x06000ABC RID: 2748
		[global::Cpp2ILInjected.Token(Token = "0x6000B57")]
		public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

		// Token: 0x06000ABD RID: 2749
		[global::Cpp2ILInjected.Token(Token = "0x6000B58")]
		public abstract object ChangeType(object value, Type destinationType);

		// Token: 0x06000ABE RID: 2750
		[global::Cpp2ILInjected.Token(Token = "0x6000B59")]
		public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);

		// Token: 0x06000ABF RID: 2751 RVA: 0x00004DAB File Offset: 0x00002FAB
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
