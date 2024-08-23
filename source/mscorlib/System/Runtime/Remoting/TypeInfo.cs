using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x020002B3 RID: 691
	[global::Cpp2ILInjected.Token(Token = "0x2000353")]
	[global::System.Serializable]
	internal class TypeInfo : IRemotingTypeInfo
	{
		// Token: 0x06001A56 RID: 6742 RVA: 0x00018F0E File Offset: 0x0001710E
		[global::Cpp2ILInjected.Token(Token = "0x6001C7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B32AF8", Offset = "0x1B32AF8", Length = "0x390")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerIdentity), Member = "CreateObjRef", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public TypeInfo(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x00018F11 File Offset: 0x00017111
		[global::Cpp2ILInjected.Token(Token = "0x17000347")]
		public string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B32E88", Offset = "0x1B32E88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00018F14 File Offset: 0x00017114
		[global::Cpp2ILInjected.Token(Token = "0x6001C7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B32E90", Offset = "0x1B32E90", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool CanCastTo(global::System.Type fromType, object o)
		{
			throw null;
		}

		// Token: 0x04000B8A RID: 2954
		[global::Cpp2ILInjected.Token(Token = "0x4000E6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string serverType;

		// Token: 0x04000B8B RID: 2955
		[global::Cpp2ILInjected.Token(Token = "0x4000E6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string[] serverHierarchy;

		// Token: 0x04000B8C RID: 2956
		[global::Cpp2ILInjected.Token(Token = "0x4000E70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string[] interfacesImplemented;
	}
}
