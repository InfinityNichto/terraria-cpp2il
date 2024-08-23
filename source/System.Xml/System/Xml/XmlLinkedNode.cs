using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000055 RID: 85
	[global::Cpp2ILInjected.Token(Token = "0x2000072")]
	public abstract class XmlLinkedNode : XmlNode
	{
		// Token: 0x060004FA RID: 1274 RVA: 0x00003DBB File Offset: 0x00001FBB
		[global::Cpp2ILInjected.Token(Token = "0x6000572")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91420", Offset = "0x1D91420", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlCDataSection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlCharacterData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlComment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDeclaration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateCDataSection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlCDataSection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlComment))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		internal XmlLinkedNode(XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00003DBE File Offset: 0x00001FBE
		[global::Cpp2ILInjected.Token(Token = "0x1700015B")]
		public override XmlNode PreviousSibling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000573")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D93500", Offset = "0x1D93500", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00003DC1 File Offset: 0x00001FC1
		[global::Cpp2ILInjected.Token(Token = "0x1700015C")]
		public override XmlNode NextSibling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000574")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D93568", Offset = "0x1D93568", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040001E4 RID: 484
		[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal XmlLinkedNode next;
	}
}
