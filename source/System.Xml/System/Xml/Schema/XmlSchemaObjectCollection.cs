using System;
using System.Collections;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200011A RID: 282
	[DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x200014C")]
	public class XmlSchemaObjectCollection : CollectionBase
	{
		// Token: 0x06000A5D RID: 2653 RVA: 0x00004D33 File Offset: 0x00002F33
		[global::Cpp2ILInjected.Token(Token = "0x6000AF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCEC00", Offset = "0x1DCEC00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		public XmlSchemaObjectCollection()
		{
			throw null;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00004D36 File Offset: 0x00002F36
		[global::Cpp2ILInjected.Token(Token = "0x6000AF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCDBD8", Offset = "0x1DCDBD8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new object[] { typeof(XmlSchemaContentProcessing) }, ReturnType = typeof(XmlSchemaComplexType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "get_List", ReturnType = typeof(IList))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int Add(XmlSchemaObject item)
		{
			throw null;
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00004D39 File Offset: 0x00002F39
		[global::Cpp2ILInjected.Token(Token = "0x6000AF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCEC08", Offset = "0x1DCEC08", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void OnInsert(int index, object item)
		{
			throw null;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00004D3C File Offset: 0x00002F3C
		[global::Cpp2ILInjected.Token(Token = "0x6000AFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCEC24", Offset = "0x1DCEC24", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void OnSet(int index, object oldValue, object newValue)
		{
			throw null;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00004D3F File Offset: 0x00002F3F
		[global::Cpp2ILInjected.Token(Token = "0x6000AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCEC78", Offset = "0x1DCEC78", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void OnClear()
		{
			throw null;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00004D42 File Offset: 0x00002F42
		[global::Cpp2ILInjected.Token(Token = "0x6000AFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCEC94", Offset = "0x1DCEC94", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void OnRemove(int index, object item)
		{
			throw null;
		}

		// Token: 0x04000411 RID: 1041
		[global::Cpp2ILInjected.Token(Token = "0x40005A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlSchemaObject parent;
	}
}
