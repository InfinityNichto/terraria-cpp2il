using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x02000013 RID: 19
	[global::Cpp2ILInjected.Token(Token = "0x2000019")]
	public abstract class XObject
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00002215 File Offset: 0x00000415
		[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D689D0", Offset = "0x1D689D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal XObject()
		{
			throw null;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009B RID: 155
		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		public abstract XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
			get;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002218 File Offset: 0x00000418
		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		public XElement Parent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6ECA8", Offset = "0x1D6ECA8", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XTextWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XCommentWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XContainerWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XAttributeWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000221B File Offset: 0x0000041B
		[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6ED24", Offset = "0x1D6ED24", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XObject), Member = "GetSaveOptionsFromAnnotations", ReturnType = typeof(SaveOptions))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private object AnnotationForSealedType(Type type)
		{
			throw null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000221E File Offset: 0x0000041E
		[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A4898", Offset = "0x15A4898", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(XObjectChangeEventArgs)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new object[]
		{
			typeof(object),
			typeof(XObjectChangeEventArgs)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XObject), Member = "SkipNotify", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public T Annotation<T>() where T : class
		{
			throw null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002221 File Offset: 0x00000421
		[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D692A4", Offset = "0x1D692A4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XAttribute), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XComment), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "RemoveNodes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "AddString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "AppendNode", MemberParameters = new object[] { typeof(XNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "RemoveNode", MemberParameters = new object[] { typeof(XNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElement), Member = "AppendAttribute", MemberParameters = new object[] { typeof(XAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XProcessingInstruction), Member = "set_Data", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XText), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool NotifyChanged(object sender, XObjectChangeEventArgs e)
		{
			throw null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002224 File Offset: 0x00000424
		[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D691FC", Offset = "0x1D691FC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XAttribute), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XComment), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "RemoveNodes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "AddString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "AppendNode", MemberParameters = new object[] { typeof(XNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "RemoveNode", MemberParameters = new object[] { typeof(XNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElement), Member = "AppendAttribute", MemberParameters = new object[] { typeof(XAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XProcessingInstruction), Member = "set_Data", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XText), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool NotifyChanging(object sender, XObjectChangeEventArgs e)
		{
			throw null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002227 File Offset: 0x00000427
		[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6A67C", Offset = "0x1D6A67C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "RemoveNodes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool SkipNotify()
		{
			throw null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000222A File Offset: 0x0000042A
		[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E75C", Offset = "0x1D6E75C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNode), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "AnnotationForSealedType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal SaveOptions GetSaveOptionsFromAnnotations()
		{
			throw null;
		}

		// Token: 0x0400002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal XContainer parent;

		// Token: 0x0400002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object annotations;
	}
}
