using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000083 RID: 131
	[global::Cpp2ILInjected.Token(Token = "0x20000AA")]
	public abstract class FormattableString : global::System.IFormattable
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060005E9 RID: 1513
		[global::Cpp2ILInjected.Token(Token = "0x17000086")]
		public abstract string Format
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000683")]
			get;
		}

		// Token: 0x060005EA RID: 1514
		[global::Cpp2ILInjected.Token(Token = "0x6000684")]
		public abstract object[] GetArguments();

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060005EB RID: 1515
		[global::Cpp2ILInjected.Token(Token = "0x17000087")]
		public abstract int ArgumentCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000685")]
			get;
		}

		// Token: 0x060005EC RID: 1516
		[global::Cpp2ILInjected.Token(Token = "0x6000686")]
		public abstract object GetArgument(int index);

		// Token: 0x060005ED RID: 1517
		[global::Cpp2ILInjected.Token(Token = "0x6000687")]
		public abstract string ToString(global::System.IFormatProvider formatProvider);

		// Token: 0x060005EE RID: 1518 RVA: 0x000156C8 File Offset: 0x000138C8
		[global::Cpp2ILInjected.Token(Token = "0x6000688")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1F0B4", Offset = "0x1C1F0B4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string System.IFormattable.ToString(string ignored, global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000156CB File Offset: 0x000138CB
		[global::Cpp2ILInjected.Token(Token = "0x6000689")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1F0C8", Offset = "0x1C1F0C8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000156CE File Offset: 0x000138CE
		[global::Cpp2ILInjected.Token(Token = "0x600068A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1F130", Offset = "0x1C1F130", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.FormattableStringFactory.ConcreteFormattableString", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(global::System.FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected FormattableString()
		{
			throw null;
		}
	}
}
