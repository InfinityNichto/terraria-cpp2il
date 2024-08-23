using System;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200011B RID: 283
	[global::Cpp2ILInjected.Token(Token = "0x200014D")]
	public abstract class XmlSchemaParticle : XmlSchemaAnnotated
	{
		// Token: 0x17000302 RID: 770
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00004D45 File Offset: 0x00002F45
		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x17000328")]
		public decimal MinOccurs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCD8F4", Offset = "0x1DCD8F4", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_LessThan", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Truncate", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(decimal))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000303 RID: 771
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x00004D48 File Offset: 0x00002F48
		[XmlIgnore]
		[global::Cpp2ILInjected.Token(Token = "0x17000329")]
		public decimal MaxOccurs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCDA1C", Offset = "0x1DCDA1C", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_LessThan", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Truncate", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(decimal))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00004D4B File Offset: 0x00002F4B
		[global::Cpp2ILInjected.Token(Token = "0x6000AFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCD244", Offset = "0x1DCD244", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaGroupBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaParticle.EmptyParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected XmlSchemaParticle()
		{
			throw null;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00004D4E File Offset: 0x00002F4E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000B00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCECB0", Offset = "0x1DCECB0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaParticle.EmptyParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static XmlSchemaParticle()
		{
			throw null;
		}

		// Token: 0x04000412 RID: 1042
		[global::Cpp2ILInjected.Token(Token = "0x40005A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private decimal minOccurs;

		// Token: 0x04000413 RID: 1043
		[global::Cpp2ILInjected.Token(Token = "0x40005A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private decimal maxOccurs;

		// Token: 0x04000414 RID: 1044
		[global::Cpp2ILInjected.Token(Token = "0x40005A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlSchemaParticle.Occurs flags;

		// Token: 0x04000415 RID: 1045
		[global::Cpp2ILInjected.Token(Token = "0x40005A4")]
		internal static readonly XmlSchemaParticle Empty;

		// Token: 0x02000178 RID: 376
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x200014E")]
		private enum Occurs
		{
			// Token: 0x0400067E RID: 1662
			[global::Cpp2ILInjected.Token(Token = "0x40005A6")]
			None = 0,
			// Token: 0x0400067F RID: 1663
			[global::Cpp2ILInjected.Token(Token = "0x40005A7")]
			Min = 1,
			// Token: 0x04000680 RID: 1664
			[global::Cpp2ILInjected.Token(Token = "0x40005A8")]
			Max = 2
		}

		// Token: 0x02000179 RID: 377
		[global::Cpp2ILInjected.Token(Token = "0x200014F")]
		private class EmptyParticle : XmlSchemaParticle
		{
			// Token: 0x06000CCD RID: 3277 RVA: 0x000053C3 File Offset: 0x000035C3
			[global::Cpp2ILInjected.Token(Token = "0x6000B01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCED1C", Offset = "0x1DCED1C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaParticle), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public EmptyParticle()
			{
				throw null;
			}
		}
	}
}
