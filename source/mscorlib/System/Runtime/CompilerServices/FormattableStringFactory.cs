using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003C2 RID: 962
	[global::Cpp2ILInjected.Token(Token = "0x2000471")]
	public static class FormattableStringFactory
	{
		// Token: 0x06001FC0 RID: 8128 RVA: 0x00019DED File Offset: 0x00017FED
		[global::Cpp2ILInjected.Token(Token = "0x6002211")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73464", Offset = "0x1B73464", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormattableString), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static global::System.FormattableString Create(string format, params object[] arguments)
		{
			throw null;
		}

		// Token: 0x020005FA RID: 1530
		[global::Cpp2ILInjected.Token(Token = "0x2000472")]
		private sealed class ConcreteFormattableString : global::System.FormattableString
		{
			// Token: 0x06004128 RID: 16680 RVA: 0x0001FE14 File Offset: 0x0001E014
			[global::Cpp2ILInjected.Token(Token = "0x6002212")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73534", Offset = "0x1B73534", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormattableString), Member = ".ctor", ReturnType = typeof(void))]
			internal ConcreteFormattableString(string format, object[] arguments)
			{
				throw null;
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x06004129 RID: 16681 RVA: 0x0001FE17 File Offset: 0x0001E017
			[global::Cpp2ILInjected.Token(Token = "0x1700046A")]
			public override string Format
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002213")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B73560", Offset = "0x1B73560", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600412A RID: 16682 RVA: 0x0001FE1A File Offset: 0x0001E01A
			[global::Cpp2ILInjected.Token(Token = "0x6002214")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73568", Offset = "0x1B73568", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override object[] GetArguments()
			{
				throw null;
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x0600412B RID: 16683 RVA: 0x0001FE1D File Offset: 0x0001E01D
			[global::Cpp2ILInjected.Token(Token = "0x1700046B")]
			public override int ArgumentCount
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002215")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B73570", Offset = "0x1B73570", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600412C RID: 16684 RVA: 0x0001FE20 File Offset: 0x0001E020
			[global::Cpp2ILInjected.Token(Token = "0x6002216")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7357C", Offset = "0x1B7357C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override object GetArgument(int index)
			{
				throw null;
			}

			// Token: 0x0600412D RID: 16685 RVA: 0x0001FE23 File Offset: 0x0001E023
			[global::Cpp2ILInjected.Token(Token = "0x6002217")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7358C", Offset = "0x1B7358C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(global::System.IFormatProvider),
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			public override string ToString(global::System.IFormatProvider formatProvider)
			{
				throw null;
			}

			// Token: 0x04001981 RID: 6529
			[global::Cpp2ILInjected.Token(Token = "0x40012B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly string _format;

			// Token: 0x04001982 RID: 6530
			[global::Cpp2ILInjected.Token(Token = "0x40012B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly object[] _arguments;
		}
	}
}
