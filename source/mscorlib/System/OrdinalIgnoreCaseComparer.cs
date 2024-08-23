using System;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000CF RID: 207
	[global::Cpp2ILInjected.Token(Token = "0x2000101")]
	[global::System.Serializable]
	internal sealed class OrdinalIgnoreCaseComparer : global::System.OrdinalComparer, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060008F4 RID: 2292 RVA: 0x00015F44 File Offset: 0x00014144
		[global::Cpp2ILInjected.Token(Token = "0x600099C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AA60", Offset = "0x1C4AA60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OrdinalComparer), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public OrdinalIgnoreCaseComparer()
		{
			throw null;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00015F47 File Offset: 0x00014147
		[global::Cpp2ILInjected.Token(Token = "0x600099D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B384", Offset = "0x1C4B384", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		public override int Compare(string x, string y)
		{
			throw null;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00015F4A File Offset: 0x0001414A
		[global::Cpp2ILInjected.Token(Token = "0x600099E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B39C", Offset = "0x1C4B39C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		public override bool Equals(string x, string y)
		{
			throw null;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00015F4D File Offset: 0x0001414D
		[global::Cpp2ILInjected.Token(Token = "0x600099F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B3B4", Offset = "0x1C4B3B4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode(string obj)
		{
			throw null;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00015F50 File Offset: 0x00014150
		[global::Cpp2ILInjected.Token(Token = "0x60009A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B418", Offset = "0x1C4B418", Length = "0xAC")]
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
