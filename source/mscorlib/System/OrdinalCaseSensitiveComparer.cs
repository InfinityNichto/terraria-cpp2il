using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000CE RID: 206
	[global::Cpp2ILInjected.Token(Token = "0x2000100")]
	[global::System.Serializable]
	internal sealed class OrdinalCaseSensitiveComparer : global::System.OrdinalComparer, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x00015F35 File Offset: 0x00014135
		[global::Cpp2ILInjected.Token(Token = "0x6000997")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AA58", Offset = "0x1C4AA58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OrdinalComparer), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public OrdinalCaseSensitiveComparer()
		{
			throw null;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00015F38 File Offset: 0x00014138
		[global::Cpp2ILInjected.Token(Token = "0x6000998")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B298", Offset = "0x1C4B298", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		public override int Compare(string x, string y)
		{
			throw null;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00015F3B File Offset: 0x0001413B
		[global::Cpp2ILInjected.Token(Token = "0x6000999")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B2A8", Offset = "0x1C4B2A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public override bool Equals(string x, string y)
		{
			throw null;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00015F3E File Offset: 0x0001413E
		[global::Cpp2ILInjected.Token(Token = "0x600099A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B2B8", Offset = "0x1C4B2B8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode(string obj)
		{
			throw null;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00015F41 File Offset: 0x00014141
		[global::Cpp2ILInjected.Token(Token = "0x600099B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B2D8", Offset = "0x1C4B2D8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "SetType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
